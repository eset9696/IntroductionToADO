using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Academy
{
	public partial class NewGroup : Form
	{
		int days = 0;
		public System.Windows.Forms.ComboBox comboBoxDirection { get { return cbGroupDirection; } }

		SqlConnection connection;
		SqlDataReader reader;
		public NewGroup(SqlConnection connection)
		{
			InitializeComponent();
			this.connection = connection;
			
			LoadLearningData(cbGroupLearningForm, @"SELECT LForm_name FROM LearningForm");
			LoadLearningData(cbGroupLearningTime, @"SELECT LStandartTime FROM LearningTime");
			LoadLearningDays();
			
		}

		private void LoadLearningData(System.Windows.Forms.ComboBox comboBox, string commandLine)
		{
			try
			{
				SqlCommand cmd = new SqlCommand(commandLine, connection);
				connection.Open();
				reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					comboBox.Items.Add(reader[0]);
				}
			}
			catch (Exception loadLearningDataException)
			{
				MessageBox.Show(this, loadLearningDataException.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				reader?.Close();
				connection?.Close();
			}
		}

		private void LoadLearningDays()
		{
			for (int i = 0; i < Convert.ToInt32(DayOfWeek.Saturday); i++)
			{
				chlbDaysOfWeek.Items.Add(DayOfWeek.Monday + i);
			}
		}

		private void btnNewGroupOk_Click(object sender, EventArgs e)
		{
			try
			{
				string commandLine = $@"IF NOT EXISTS (SELECT group_name FROM Groups WHERE group_name = '{rtbNewGroupName.Text}') 
									BEGIN 
										INSERT INTO Groups(group_name, direction, learning_form, learning_time, learning_days)
										VALUES ('{rtbNewGroupName.Text}', 
										(SELECT direction_id FROM Directions WHERE direction_name = '{cbGroupDirection.Text}'),
										(SELECT LForm_id FROM LearningForm WHERE LForm_name = '{cbGroupLearningForm.Text}'),
										(SELECT LTime_id FROM LearningTime WHERE LStandartTime = '{cbGroupLearningTime.Text}'),
										{days})
									END";
				SqlCommand cmd = new SqlCommand(commandLine, connection);
				connection.Open();
				cmd.ExecuteNonQuery();
			}
			catch (Exception addGroupException)
			{
				MessageBox.Show(this, addGroupException.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally 
			{ 
				connection?.Close();
				this.Close();
			}
			
		}

		private void btnNewGroupClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void chlbDaysOfWeek_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			int index = Convert.ToInt32(chlbDaysOfWeek.SelectedItem);
			switch (index)
			{
				case 1:
					days += !chlbDaysOfWeek.CheckedItems.Contains(chlbDaysOfWeek.SelectedItem) ? 1 : -1;
					break;
				case 2:
					days += !chlbDaysOfWeek.CheckedItems.Contains(chlbDaysOfWeek.SelectedItem) ? 2 : -2;
					break;
				case 3:
					days += !chlbDaysOfWeek.CheckedItems.Contains(chlbDaysOfWeek.SelectedItem) ? 4 : -4;
					break;
				case 4:
					days += !chlbDaysOfWeek.CheckedItems.Contains(chlbDaysOfWeek.SelectedItem) ? 8 : -8;
					break;
				case 5:
					days += !chlbDaysOfWeek.CheckedItems.Contains(chlbDaysOfWeek.SelectedItem) ? 16 : -16;
					break;
				case 6:
					days += !chlbDaysOfWeek.CheckedItems.Contains(chlbDaysOfWeek.SelectedItem) ? 32 : -32;
					break;
			}
		}
	}
}

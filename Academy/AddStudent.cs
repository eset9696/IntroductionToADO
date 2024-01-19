using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
	public partial class AddStudent : Form
	{
		SqlConnection connection;
		SqlDataReader reader;
		public AddStudent(SqlConnection connection)
		{
			InitializeComponent();
			this.connection = connection;
			LoadGroupsToComboBox();
		}

		public void LoadGroupsToComboBox()
		{
			string commandLine = $@"SELECT group_name FROM Groups";
			SqlCommand cmd = new SqlCommand(commandLine, connection);
			connection.Open();
			reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				cbGroups.Items.Add(reader[0]);
			}
			reader.Close();
			connection.Close();
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void labelFirstName_Click(object sender, EventArgs e)
		{

		}

		int getGroupId(string groupName)
		{
			int id = 0;
			string query = $@"SELECT group_id FROM Groups WHERE group_name = '{groupName}'";
			connection.Open();
			SqlCommand cmd = new SqlCommand(query, connection);
			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				id = Convert.ToInt32(reader[0]);
			}
			connection.Close();
			return id;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			int group_id = getGroupId(cbGroups.SelectedItem.ToString());
			string insertCommand = $@"IF NOT EXISTS (SELECT * FROM Students WHERE last_name = '{rbLastName.Text}' 
			AND first_name = '{rb_FirstName}' AND middle_name = '{rbMiddleName}' AND birth_date = '{dtpBirthDate.Text}' 
			AND [group] = (SELECT group_id FROM Groups WHERE group_name = '{cbGroups.SelectedItem}')) 
			BEGIN INSERT INTO Students (last_name, first_name, middle_name, birth_date, [group]) 
			VALUES (@last_name, @first_name, @middle_name, @birth_date, @group) END";
			connection.Open();
			SqlCommand cmd = new SqlCommand(insertCommand, connection);
			cmd.Parameters.AddWithValue("@last_name", rbLastName.Text);
			cmd.Parameters.AddWithValue("@first_name", rb_FirstName.Text);
			cmd.Parameters.AddWithValue("@middle_name", rbMiddleName.Text);
			cmd.Parameters.AddWithValue("@birth_date", dtpBirthDate.Value.Date);
			cmd.Parameters.AddWithValue("@group", group_id);
			cmd.ExecuteNonQuery();
			connection.Close();
		}
	}
}

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
		public System.Windows.Forms.ComboBox groupCombo 
		{ 
			get 
			{ 
				return cbGroups; 
			} 
		}
		public AddStudent(SqlConnection connection)
		{
			InitializeComponent();
			this.connection = connection;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			try
			{
				string insertCommand = $@"
			IF NOT EXISTS (SELECT stud_id FROM Students WHERE last_name = @last_name AND first_name = @first_name AND 
			middle_name = @middle_name AND birth_date = @birth_date) 
			BEGIN 
				INSERT INTO Students (last_name, first_name, middle_name, birth_date, [group]) 
				VALUES (@last_name, @first_name, @middle_name, @birth_date, (SELECT group_id FROM Groups WHERE group_name = @group)) 
			END";
				connection.Open();
				SqlCommand cmd = new SqlCommand(insertCommand, connection);
				cmd.Parameters.AddWithValue("@last_name", rbLastName.Text);
				cmd.Parameters.AddWithValue("@first_name", rb_FirstName.Text);
				cmd.Parameters.AddWithValue("@middle_name", rbMiddleName.Text);
				cmd.Parameters.AddWithValue("@birth_date", dtpBirthDate.Value.Date);
				cmd.Parameters.AddWithValue("@group", cbGroups.SelectedItem.ToString());
				cmd.ExecuteNonQuery();
			}
			catch (Exception excaption)
			{
				MessageBox.Show(this, excaption.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				connection?.Close();
			}
			this?.Close();
		}
	}
}

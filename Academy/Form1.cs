using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
	public partial class Form1 : Form
	{
		string connectionString;
		SqlConnection connection;
		DataTable table;
		SqlDataReader reader;

		public Form1()
		{
			InitializeComponent();
			connectionString = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
			connection = new SqlConnection(connectionString);
			LoadGroupsToComboBox(cbGroups);
			LoadSpecialitiesToComboBox();
		}

		void LoadGroupsToComboBox(System.Windows.Forms.ComboBox comboBox)
		{
			try
			{
				string commandLine = $@"SELECT group_name FROM Groups";
				SqlCommand cmd = new SqlCommand(commandLine, connection);
				connection.Open();
				reader = cmd.ExecuteReader();
				comboBox.Items.Add("ALL");
				while (reader.Read())
				{
					comboBox.Items.Add(reader[0]);
				}
			}
			catch (Exception e)
			{
				MessageBox.Show(this, e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{ 
				reader?.Close();
				connection?.Close();
			}
		}

		private void LoadSpecialitiesToComboBox()
		{
			try
			{
				string commandLine = $@"SELECT speciality_name FROM Specialities";
				SqlCommand cmd = new SqlCommand(commandLine, connection);
				connection.Open();
				reader = cmd.ExecuteReader();
				cbSpecialities.Items.Add("ALL");
				while (reader.Read())
				{
					cbSpecialities.Items.Add(reader[0]);
				}
			}
			catch (Exception e)
			{
				MessageBox.Show(this, e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				reader?.Close();
				connection?.Close();
			}
		}

		private void LoadDataToTable(string commandLine)
		{
			try
			{
				SqlCommand cmd = new SqlCommand(commandLine, connection);
				connection.Open();
				SqlDataReader reader = cmd.ExecuteReader();
				table = new DataTable();
				for (int i = 0; i < reader.FieldCount; i++) table.Columns.Add(reader.GetName(i));
				while (reader.Read())
				{
					DataRow row = table.NewRow();
					for (int i = 0; i < reader.FieldCount; i++) row[i] = reader[i];
					row["birth_date"] = Convert.ToDateTime(reader["birth_date"]).ToString("dd.MM.yyyy");
					if(commandLine.Contains("work_since")) row["work_since"] = Convert.ToDateTime(reader["work_since"]).ToString("dd.MM.yyyy");
					table.Rows.Add(row);
				}
			}
			catch (Exception e)
			{
				MessageBox.Show(this, e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally 
			{
				reader?.Close();
				connection?.Close();
			}
		}

		private void btnAddStudent_Click(object sender, EventArgs e)
		{
			AddStudent addStudent = new AddStudent(connection);
			LoadGroupsToComboBox(addStudent.groupCombo);
			DialogResult result = addStudent.ShowDialog(this);

		}

		private void cbGroups_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbGroups.SelectedItem.ToString() == "ALL")
			{
				string commandLine = $@"SELECT stud_id, last_name, first_name, middle_name, birth_date, group_name
				FROM Students, Groups WHERE group_id = [group] ORDER BY last_name";
				LoadDataToTable(commandLine);
			}
			else
			{
				string commandLine = $@"SELECT stud_id, last_name, first_name, middle_name, birth_date, group_name
				FROM Students, Groups WHERE group_id = [group] AND group_name = '{cbGroups.SelectedItem}'";
				LoadDataToTable(commandLine);
			}
			dgvStudents.DataSource = table;
		}

		private void cbSpecialities_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbSpecialities.SelectedItem.ToString() == "ALL")
			{
				string commandLine = $@"SELECT teacher_id, last_name, first_name, middle_name, birth_date, work_since, rate
				FROM Teachers";
				LoadDataToTable(commandLine);
			}
			else
			{
				string commandLine = $@"SELECT teacher_id, last_name, first_name, middle_name, birth_date, work_since, rate
				FROM Teachers, SpecialitiesTeachersRelation, Specialities WHERE teacher_id = teacher AND speciality_id = speciality AND speciality_name = '{cbSpecialities.SelectedItem}'";
				LoadDataToTable(commandLine);
			}
			dgvTeachers.DataSource = table;
		}

		private void btnDeleteStudent_Click(object sender, EventArgs e)
		{
			try
			{
				connection.Open();
				for (int i = 0; i < dgvStudents.SelectedRows.Count; i++)
				{
					string commandLine = $@"DELETE FROM Students WHERE stud_id = {dgvStudents.SelectedRows[i].Cells[0].Value}";
					SqlCommand cmd = new SqlCommand(commandLine, connection);
					cmd.ExecuteNonQuery();
				}
			}
			catch (Exception deleteException)
			{
				MessageBox.Show(this, deleteException.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				connection.Close();
			}
		}
	}
}

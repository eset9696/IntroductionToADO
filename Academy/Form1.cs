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
			LoadSpecialitiesToComboBox(cbSpecialities);
			LoadDirectionsToComboBox();
		}

		private void LoadGroupsToComboBox(System.Windows.Forms.ComboBox comboBox)
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

		private void LoadSpecialitiesToComboBox(System.Windows.Forms.ComboBox comboBox)
		{
			try
			{
				string commandLine = $@"SELECT speciality_name FROM Specialities";
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
				if(!commandLine.Contains("work_since")) labelStudentsCount.Text = table.Rows.Count.ToString();
				else if(commandLine.Contains("work_since")) labelTeachersCount.Text = table.Rows.Count.ToString();
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

		void LoadDirectionsToComboBox()
		{
			string commandLine = $@"SELECT direction_name FROM Directions";
			SqlCommand cmd = new SqlCommand(commandLine, connection);
			connection.Open();
			reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				cbDirections.Items.Add(reader[0]);
			}
			reader.Close();
			connection.Close();
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
				connection?.Close();
			}
		}

		private void btnDeleteTeacher_Click(object sender, EventArgs e)
		{
			try
			{
				connection.Open();
				for (int i = 0; i < dgvTeachers.SelectedRows.Count; i++)
				{
					string commandLine = $@"DELETE FROM Teachers WHERE stud_id = {dgvTeachers.SelectedRows[i].Cells[0].Value}";
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
				connection?.Close();
			}
		}

		private void btnAddTeacher_Click(object sender, EventArgs e)
		{
			AddTeacher addTeacher = new AddTeacher(connection);
			DialogResult result = addTeacher.ShowDialog(this);
		}

		private void rtbSearch_TextChanged(object sender, EventArgs e)
		{
			string commandLine = $@"SELECT Students.last_name, Students.first_name, Students.middle_name, Students.birth_date, Groups.group_name 
			FROM Students, Groups WHERE Students.[group] = Groups.group_id AND (Students.last_name LIKE '{rtbSearch.Text}%' 
			OR Students.first_name LIKE '{rtbSearch.Text}%' OR Students.middle_name LIKE '{rtbSearch.Text}%')";
			LoadDataToTable(commandLine);
			dgvStudents.DataSource = table;
			/*SqlCommand cmd = new SqlCommand(commandLine, connection);
			connection.Open();*/
		}

		private void cbDirections_SelectedIndexChanged(object sender, EventArgs e)
		{
			string commandLine = $@"SELECT last_name, first_name, middle_name, birth_date, group_name, direction_name 
			FROM Students, Groups, Directions
			WHERE direction = direction_id AND [group] = group_id AND direction_name = '{cbDirections.SelectedItem}'";
			LoadDataToTable(commandLine);
			dgvStudents.DataSource = table;
		}

		private void dgvStudents_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			StudentInfo studInfo = new StudentInfo(connection, Convert.ToInt32(dgvStudents.CurrentCell.Value.ToString()));
			//studInfo.studId = Convert.ToInt32(dgvStudents.CurrentCell.Value.ToString());
			DialogResult result = studInfo.ShowDialog(this);
		}
	}
}

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
			LoadDirectionsToComboBox(cbGroupsDirections);
			LoadDirectionsToComboBox(cbDirections);
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

		private void LoadDirectionsToComboBox(System.Windows.Forms.ComboBox comboBox)
		{
			try
			{
				string commandLine = $@"SELECT direction_name FROM Directions";
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

		private void LoadDataToTable(System.Windows.Forms.DataGridView dataGridView, string commandLine)
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
					if (commandLine.Contains("birth_date")) row["birth_date"] = Convert.ToDateTime(reader["birth_date"]).ToString("dd.MM.yyyy");
					if(commandLine.Contains("work_since")) row["work_since"] = Convert.ToDateTime(reader["work_since"]).ToString("dd.MM.yyyy");
					table.Rows.Add(row);
				}
				dataGridView.DataSource = table;
				if(tbAcademy.SelectedTab == tabPageStudents) labelStudentsCount.Text = table.Rows.Count.ToString();
				if(tbAcademy.SelectedTab == tabPageTeachers) labelTeachersCount.Text = table.Rows.Count.ToString();
				if (tbAcademy.SelectedTab == tabPageGroups) labelGroupsCount.Text = table.Rows.Count.ToString();
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
			string subLine = " ";
			if (cbGroups.SelectedItem.ToString() != "ALL")
				subLine = $@"AND group_name = '{cbGroups.SelectedItem}'";
			string commandLine = $@"SELECT stud_id, last_name, first_name, middle_name, birth_date, group_name
				FROM Students, Groups WHERE group_id = [group] {subLine} ORDER BY last_name";
			
			LoadDataToTable(dgvStudents, commandLine);
		}

		private void cbSpecialities_SelectedIndexChanged(object sender, EventArgs e)
		{
			string commandLine = $@"SELECT teacher_id, last_name, first_name, middle_name, birth_date, work_since, rate
				FROM Teachers";
			if (cbSpecialities.SelectedItem.ToString() != "ALL") 
				commandLine += $@", SpecialitiesTeachersRelation, Specialities WHERE teacher_id = teacher AND speciality_id = speciality AND speciality_name = '{cbSpecialities.SelectedItem}'";
			LoadDataToTable(dgvTeachers, commandLine);
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
			string commandLine = $@"SELECT Students.stud_id, Students.last_name, Students.first_name, Students.middle_name, Students.birth_date, Groups.group_name 
			FROM Students, Groups WHERE Students.[group] = Groups.group_id AND (Students.last_name LIKE '{rtbStudSearch.Text}%' 
			OR Students.first_name LIKE '{rtbStudSearch.Text}%' OR Students.middle_name LIKE '{rtbStudSearch.Text}%')";
			LoadDataToTable(dgvStudents, commandLine);
		}

		private void cbDirections_SelectedIndexChanged(object sender, EventArgs e)
		{
			string commandLine = $@"SELECT last_name, first_name, middle_name, birth_date, group_name, direction_name 
			FROM Students, Groups, Directions
			WHERE direction = direction_id AND [group] = group_id";
			if(cbDirections.SelectedItem.ToString() != "ALL")
				commandLine += $@" AND direction_name = '{cbDirections.SelectedItem}'";
			LoadDataToTable(dgvStudents, commandLine);
		}
		
		private void dgvStudents_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			StudentInfo studInfo = new StudentInfo(connection, Convert.ToInt32(dgvStudents.CurrentCell.Value.ToString()));
			DialogResult result = studInfo.ShowDialog(this);
		}

		private void rtbTeacherSearch_TextChanged(object sender, EventArgs e)
		{
			string commandLine = $@"SELECT Teachers.last_name, Teachers.first_name, Teachers.middle_name, Teachers.birth_date, 
			Teachers.work_since, Teachers.rate
			FROM Teachers 
			WHERE (Teachers.last_name LIKE '{rtbTeacherSearch.Text}%' 
			OR Teachers.first_name LIKE '{rtbTeacherSearch.Text}%' OR Teachers.middle_name LIKE '{rtbTeacherSearch.Text}%')";
			LoadDataToTable(dgvTeachers, commandLine);
		}

		private void cbGroupsDirections_SelectedIndexChanged(object sender, EventArgs e)
		{
			string commandLine = $@"SELECT Groups.group_name, Directions.direction_name FROM Groups, Directions
				WHERE Directions.direction_id = Groups.direction";
			if (cbGroupsDirections.SelectedItem.ToString() != "ALL") 
				commandLine += $@" AND Directions.direction_name = '{cbGroupsDirections.Text}'";
			LoadDataToTable(dgvGroups, commandLine);
		}

		private void btnAddGroup_Click(object sender, EventArgs e)
		{
			NewGroup newGroup = new NewGroup(connection);
			LoadDirectionsToComboBox(newGroup.comboBoxDirection);
			newGroup.ShowDialog(this);
		}
	}
}

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
			LoadGroupsToComboBox();
		}

		void LoadTablesToComboBox()
		{
			string commandLine = @"SELECT table_name FROM information_schema.tables";
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

		private void cbGroups_SelectedIndexChanged(object sender, EventArgs e)
		{
			string commandLine = $@"SELECT Students.stud_id, Students.last_name, Students.first_name, Students.middle_name
			FROM Students WHERE Students.[group] = (SELECT group_id FROM Groups WHERE group_name = '{cbGroups.SelectedItem}')";
			SqlCommand cmd = new SqlCommand(commandLine, connection);
			connection.Open();
			SqlDataReader reader = cmd.ExecuteReader();
			table = new DataTable();
			for (int i = 0; i < reader.FieldCount; i++) table.Columns.Add(reader.GetName(i));
			while (reader.Read())
			{
				DataRow row = table.NewRow();
				for(int i = 0; i < reader.FieldCount; i++)row[i] = reader[i];
				table.Rows.Add(row);
			}
			dgwTables.DataSource = table;
			reader.Close();
			connection.Close();
		}

		private void btnAddStudent_Click(object sender, EventArgs e)
		{
			AddStudent ad = new AddStudent(connection);
			ad.ShowDialog();
		}
	}
}

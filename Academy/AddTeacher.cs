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
	public partial class AddTeacher : Form
	{
		SqlConnection connection;
		public AddTeacher(SqlConnection connection)
		{
			InitializeComponent();
			this.connection = connection;
			LoadSpecialitiesToCheckedListBox();
		}

		private void LoadSpecialitiesToCheckedListBox()
		{
			string commandLine = $@"SELECT speciality_name FROM Specialities";
			SqlCommand cmd = new SqlCommand(commandLine, connection);
			connection.Open();
			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				clbSpecialities.Items.Add(reader[0]);
			}
			reader.Close();
			connection?.Close();
		}
		private void btnOk_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close ();
		}
	}
}

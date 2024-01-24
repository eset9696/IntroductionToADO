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
using System.IO;
using System.Collections;

namespace Academy
{
	public partial class StudentInfo : Form
	{
		SqlConnection connection;
		int studId;
		public StudentInfo(SqlConnection connection, int studId)
		{
			InitializeComponent();
			this.connection = connection;
			this.studId = studId;
			LoadStudName();
			LoadStudStatistics();
			LoadAvatar();
		}

		private void LoadStudName()
		{
			string commandLine = $@"SELECT Students.last_name, Students.first_name, Students.middle_name, Students.birth_date, Groups.group_name
			FROM Students, Groups WHERE Students.stud_id = {studId} AND Students.[group] = Groups.group_id";
			SqlCommand cmd = new SqlCommand(commandLine, connection);
			connection.Open();
			SqlDataReader reader = cmd.ExecuteReader();
			reader.Read();
			labelStudName.Text = $"{reader[0]} {reader[1]} {reader[2]}";
			labelBirthDate.Text += Convert.ToDateTime(reader[3]).ToString("dd.MM.yyyy");
			labelGroup.Text += reader[4].ToString();
			reader?.Close();
			connection?.Close();
        }
		private void LoadStudStatistics()
		{
			string commandLine = $@"SELECT AVG(Attendance.present * 100), AVG(Grades.grade_1 + Grades.grade_2)/2  
			FROM Attendance, Students, Grades WHERE {studId} = Attendance.student AND {studId} = Grades.student";
			SqlCommand cmd = new SqlCommand(commandLine , connection);
			connection.Open();
			SqlDataReader reader = cmd.ExecuteReader();
			reader.Read();
			labelAttend.Text += reader[0];
			labelAVGGrade.Text += reader[1];
			reader.Close();
			connection.Close();
		}

		private void LoadAvatar()
		{
			string commandLine = $@"SELECT Images.image  
			FROM Images, Students WHERE Students.stud_id = {studId} AND Students.image = Images.image_id";
			SqlCommand cmd = new SqlCommand(commandLine, connection);
			connection.Open();
			SqlDataReader reader = cmd.ExecuteReader();
			reader.Read();
			byte[] image = reader[0] as byte[];
			MemoryStream memoryStream = new MemoryStream(image);
			pbAvatarStudent.Image = Image.FromStream(memoryStream);
			reader.Close();
			connection.Close();
		}

		private void TestLoad()
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.ShowDialog(this);
			byte[] image = File.ReadAllBytes(openFileDialog.FileName);
			MemoryStream memoryStream = new MemoryStream(image);
			pbAvatarStudent.Image = Image.FromStream(memoryStream);
		}

		private void btnSetStudentAvatar_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.ShowDialog(this);
			if (openFileDialog.FileName.Length == 0) return;
			byte[] image = File.ReadAllBytes(openFileDialog.FileName);
			string image_name = openFileDialog.SafeFileName;
			SqlCommand cmd = new SqlCommand();
			connection.Open();
			cmd.Connection = connection;
			cmd.CommandText = @"INSERT INTO Images (image, image_name) output INSERTED.image_id VALUES (@image, @image_name)";
			cmd.Parameters.Add("@image", SqlDbType.Image, 1000000);
			cmd.Parameters.AddWithValue("@image_name", image_name);
			cmd.Parameters["@image"].Value = image;
			int image_id = (int)cmd.ExecuteScalar();
			SetAvatarForStudent(image_id);
			connection.Close();
			LoadAvatar();
		}

		private void SetAvatarForStudent(int image_id)
		{
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = connection;
			cmd.CommandText = $@"UPDATE Students SET Students.image = {image_id} WHERE Students.stud_id = {studId}";
			cmd.ExecuteNonQuery();
		}
	}
}

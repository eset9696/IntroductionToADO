using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Library
{
	internal class Library
	{
		SqlConnection connection;
		SqlCommand cmd { get; set; }
		public Library(string connectionString) 
		{
			connection = new SqlConnection(connectionString);
		}
		public void InsertAutorQuery(string firstName, string lastName)
		{
			try
			{
				connection.Open();
				string command = $@"IF NOT EXISTS (SELECT * FROM Authors WHERE last_name = '{lastName}' AND first_name = '{firstName}') BEGIN INSERT INTO Authors (last_name, first_name) VALUES ('{lastName}','{firstName}') END";
				cmd = new SqlCommand(command, connection);
				cmd.ExecuteNonQuery();
			}
			catch(Exception e)
			{ 
				Console.WriteLine(e.Message); 
			}
			finally 
			{ 
				if(connection != null) connection.Close(); 
			}
			
		}
		public void InsertBookQuery(string lastName, string firstName, string title, string price, string pages)
		{
			try
			{
				connection.Open();
				string command = $@"IF NOT EXISTS (SELECT id FROM Authors WHERE last_name = '{lastName}' AND first_name = '{firstName}') 
									BEGIN INSERT INTO Authors (author, title, price, pages) VALUES ('{lastName}','{firstName}') END
									INSERT INTO Books(author, title, price, pages) VALUES ((SELECT id FROM Authors WHERE last_name = '{lastName}' AND first_name = '{firstName}'), '{title}', {price}, {pages})";
				cmd = new SqlCommand(command, connection);
				cmd.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				if (connection != null) connection.Close();
			}

		}

		public void SelectAuthors()
		{
			try
			{
				connection.Open();
				string command = $@"SELECT * FROM Authors";
				cmd = new SqlCommand(command, connection);
				SqlDataReader rdr = cmd.ExecuteReader();
				Console.WriteLine($"{rdr.GetName(0).PadRight(10)} {rdr.GetName(1).PadRight(15)} {rdr.GetName(2).PadRight(15)}");
				while (rdr.Read())
				{
					Console.WriteLine($"{rdr[0].ToString().PadRight(10)} {rdr[1].ToString().PadRight(10)} {rdr[2].ToString().PadRight(10)}");
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				if (connection != null) connection.Close();
			}

		}
	}
}

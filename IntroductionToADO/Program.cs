using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace IntroductionToADO
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Library;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
			SqlConnection connection = new SqlConnection(connectionString);
			connection.Open();
			showMainMenu(connection);
			connection.Close();
		}

		static void showMainMenu(SqlConnection connection)
		{
			Console.WriteLine("Выберите опцию: \n1 - Добавить нового автора\n2 - Добавить новую книгу\n3 - Добавить новую книгу и автора\n4 - Показать всех авторов в базе" +
				"\n5 - Показать все книги в базе\n6 - Удалить автора из базы\n7 - Удалить книгу из базы");
			int option = Convert.ToInt32(Console.ReadLine());
			chooseOptionOfMainMenu(connection, option);
		}

		static void chooseOptionOfMainMenu(SqlConnection connection, int option)
		{
			if(option == 1)
			{
				string[] authorName = addAuthor();
				addAuthorQuery(connection, authorName[0], authorName[1]);
			}
			else if (option == 2)
			{
				string[] book = addBook();
				addBookQuery(connection, book[0], book[1], book[3]);
			}
			else if (option == 3)
			{
				string[] authorName = addAuthor();
				addAuthorQuery(connection, authorName[0], authorName[1]);
				string[] book = addBook();
				addBookQuery(connection, book[0], book[1], book[3]);
			}
			else if (option == 4)
			{
				selectAuthorsQuery(connection);
			}
			else if (option == 5)
			{
				selectAuthorsAndBooksQuery(connection);
			}
			else if (option == 6)
			{
				deleteAuthorQuery(connection);
			}
			else if (option == 7)
			{
				selectAuthorsQuery(connection);
			}
		}

		static string[] addAuthor()
		{
			string[] name = new string[2];
			Console.WriteLine("Введите имя и фамилию автора");
			name = Console.ReadLine().Split(' ');
			return name;
		}

		static string[] addBook()
		{
			string[] book = new string[3];
			Console.WriteLine("Введите название книги, цену и количество страниц");
			book = Console.ReadLine().Split(' ');
			return book;
		}

		static void addAuthorQuery(SqlConnection connection, string authorsFirstName, string authorsLastName) 
		{
			string newAuthor = $@"IF NOT EXISTS (SELECT * FROM Authors WHERE Authors.first_name = '{authorsFirstName}' AND Authors.last_name = '{authorsLastName}') BEGIN INSERT INTO Authors (first_name, last_name) VALUES('{authorsFirstName}', '{authorsLastName}') END";
			
			SqlCommand insertCommand = new SqlCommand(newAuthor, connection);
			insertCommand.ExecuteNonQuery();
		}

		static void addBookQuery(SqlConnection connection, string title, string price, string pages)
		{
			int author_id = chooseAuthorId(connection);
			string newBook = $@"INSERT INTO Books (author, title, price, pages) VALUES('{author_id}', '{title}', {price}, {pages})";
		}

		static int chooseAuthorId(SqlConnection connection)
		{
			selectAuthorsQuery(connection);
			int id = Convert.ToInt32(Console.ReadLine());
			return id;
		}

		static void selectAuthorsQuery(SqlConnection connection)
		{
			string query = @"SELECT * FROM Authors";
			SqlCommand selectCommand = new SqlCommand(query, connection);
			SqlDataReader rdr = selectCommand.ExecuteReader();
			while (rdr.Read())
			{
				Console.WriteLine($"{rdr[0]} {rdr[1]} {rdr[2]}");
			}
		}

		static void selectAuthorsAndBooksQuery(SqlConnection connection)
		{
			string query = @"SELECT Authors.last_name, Authors.first_name, Books.title FROM Authors, Books WHERE Authors.id = Books.author";
			SqlCommand selectCommand = new SqlCommand(query, connection);
			SqlDataReader rdr = selectCommand.ExecuteReader();
			while (rdr.Read())
			{
				Console.WriteLine($"{rdr[0]} {rdr[1]}\t\t{rdr[2]}");
			}
			rdr.Close();
		}

		static void deleteAuthorQuery(SqlConnection connection)
		{
			Console.WriteLine("Введите id автора");
			int id = Convert.ToInt32((Console.ReadLine()));	
			string query = $@"DELETE FROM Authors WHERE Authors.id = {id}";
			SqlCommand deleteCommand = new SqlCommand(query, connection);
		}
	}
}

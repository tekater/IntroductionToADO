using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using System.Threading;


namespace IntroductionToADO
{
	class Program
	{
		static void Main(string[] args)
		{
			// Соединение:
			string connection_string = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
			SqlConnection connection = new SqlConnection(connection_string); // Создаём соединение с сервером, при создании оно не активно

			connection.Open();      // Открываем соединение, поскольку автоматически оно не открывается.

			// Вставка:
			//string insert_string = @"INSERT INTO Authors (first_name,last_name) VALUES ('Steven','Hocking')";
			string insert_string = @"INSERT INTO Books (author,title,price,pages) VALUES (4,'The Steven Hawkings Universe',500,1000)";
			SqlCommand cmd = new SqlCommand(insert_string,connection); // Указываем запроc,затем базу

			//cmd.ExecuteNonQuery(); // INSERT,UPDATE,DELETE 

			// Выборка:
			string select_string = @"SELECT Authors.last_name + ' ' + Authors.first_name , Books.title FROM Books , Authors WHERE Books.author = Authors.id";
			cmd.CommandText = (select_string);

			SqlDataReader rdr = cmd.ExecuteReader();
			while (rdr.Read())
			{
				Console.WriteLine($"{rdr[0]} \t {rdr[1]}");
            }
			rdr.Close();
			int choose = 1;
            Console.WriteLine($"\n\nВведите действие:\n[1] - добавить книгу\n[?] - выйти.\n");
			//choose = Convert.ToInt32(Console.Read());
            switch (choose)
			{
				case 0:
					break;
				case 1:
					{
                        Console.WriteLine("\nВведите имя Автора книги:");
                        string first_name = Console.ReadLine();
						Console.WriteLine("\nВведите Фамилию Автора книги:");
						string last_name = Console.ReadLine();

						SqlCommand author_cmd = new SqlCommand($"INSERT INTO Authors (first_name,last_name) VALUES ('{first_name}','{last_name}')", connection);
						author_cmd.ExecuteNonQuery();

						author_cmd.CommandText = ($"SELECT Authors.id FROM Authors WHERE Authors.first_name = '{first_name}' AND Authors.last_name = '{last_name}'");
						SqlDataReader author_rdr = author_cmd.ExecuteReader();
						author_rdr.Read();

                        Console.WriteLine("\nВведите название книги:");
						string book = Console.ReadLine();
						Console.WriteLine("\nВведите стоимость книги:n");
						//int price = Convert.ToInt32(Console.ReadLine());
						string price = (Console.ReadLine());
						Console.WriteLine("\nВведите количество страниц книги:n");
						//int pages = Convert.ToInt32(Console.ReadLine());
						string pages = (Console.ReadLine());

						SqlCommand book_cmd = new SqlCommand($"INSERT INTO Books (author,title,price,pages) VALUES ({author_rdr[0]},'{book}',{price},{pages})", connection);
						author_rdr.Close();
						book_cmd.ExecuteNonQuery();
					}
					break;
			}

			Thread.Sleep(3000);
			
						connection.Close();		// Соединения обязательно нужно закрывать.
		}
	}
}

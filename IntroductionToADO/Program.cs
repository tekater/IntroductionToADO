﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


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
			string select_string = @"SELECT * FROM Authors";
			cmd.CommandText = (select_string);

			SqlDataReader rdr = cmd.ExecuteReader();
			while (rdr.Read())
			{
				Console.WriteLine($"{rdr[0]} {rdr[1]} {rdr[2]}");
            }


			connection.Close();		// Соединения обязательно нужно закрывать.
		}
	}
}

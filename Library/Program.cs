using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading;

namespace Library
{
	class Program
	{
		SqlConnection connection;
		SqlCommand cmd;
		static void Main(string[] args)
		{
			string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            Console.WriteLine(connectionString);

			Library library = new Library(connectionString);
			library.InsertAuthor("Stroustrup", "Bjarne");
			library.SelectAuthors();
			Thread.Sleep(6000);
		}
	}
}

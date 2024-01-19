using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Crime
{
	class Program
	{
		string connectionString;
		SqlConnection connection;
		public SqlCommand cmd { get; set; }
		static void Main(string[] args)
		{
		}
	}
}

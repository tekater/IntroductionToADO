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

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Academy
{
	public partial class StudentInfo : Form
	{
		string connectionString;
		SqlConnection connection;
		SqlDataReader reader;
		DataTable table;
		public StudentInfo(string point)
		{
			InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
			connection = new SqlConnection(connectionString);

			Load_StudentName(point);
			Load_StudentGroup(point);
			Load_StudentAge(point);
		}

		void Load_StudentName(string last_name)
		{
			connection.Open();

			string StudentFullName = @"
SELECT 
	last_name, firts_name, middle_name 
FROM 
	Students 
WHERE 
	last_name = @last_name
									";

			SqlCommand cmd = new SqlCommand(StudentFullName, connection);
			cmd.Parameters.AddWithValue("@last_name", last_name);
			reader = cmd.ExecuteReader();

			while (reader.Read())
			{
				tbName.Text = $"{reader[0]} {reader[1]} {reader[2]}";
			}

			reader.Close();
			connection.Close();
		}
		void Load_StudentGroup(string last_name)
		{
			connection.Open();
			string StudentFullName =	@"
SELECT 
	group_name 
FROM 
	Students, Groups 
WHERE 
	last_name = @last_name 
AND 
	[group] = group_id
								";
			SqlCommand cmd = new SqlCommand(StudentFullName, connection);
			cmd.Parameters.AddWithValue("@last_name", last_name);
			reader = cmd.ExecuteReader();

			while (reader.Read())
			{
				tbGroup.Text = $"{reader[0]}";
			}

			reader.Close();
			connection.Close();
		}
		void Load_StudentAge(string last_name)
		{
			connection.Open();
			string StudentFullName = $@"
SELECT 
	{DateTime.Today.Year} - YEAR(birth_date)
FROM
	Students
WHERE
	last_name = @last_name
										";
			SqlCommand cmd = new SqlCommand(StudentFullName, connection);
			cmd.Parameters.AddWithValue("@last_name", last_name);
			reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				tbAge.Text = $"{reader[0]}";
			}

			reader.Close();
			connection.Close();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}

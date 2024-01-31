using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
	public partial class Form1 : Form
	{
		string connectionString;
		SqlConnection connection;
		DataTable table;
		SqlDataReader reader;
		public Form1()
		{
			InitializeComponent();

			connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
			connection = new SqlConnection(connectionString);

			//LoadTablesToComboBox();
			LoadGroupsToComboBox(cbGroup);
			SelectStudents();
			LoadDirectionsToComboBox();
			rbStudents.Checked = true;
			LoadDataToComboBox(cbDirectionOnGroupTab, "Directions", "direction_name", "Выберите направление");
		}

		public void LoadDataToComboBox
			(
			System.Windows.Forms.ComboBox comboBox,
			string sourceTable,
			string sourceColumn,
			string invite = "Выберите значение",
			string condition = null
			)
		{
			string commandLine = $@"SELECT {sourceColumn} FROM {sourceTable} ";
			if(condition != null)
			{
				commandLine += condition;
			}
			SqlCommand cmd = new SqlCommand(commandLine, connection);
/*
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = connection;
			cmd.Parameters.Add("@table_name", SqlDbType.Structured sourceTable);
			cmd.Parameters.Add("@column_name", sourceColumn);
			cmd.CommandText = @"SELECT @column_name FROM @table_name";
*/
			connection.Open();
			reader = cmd.ExecuteReader();
			comboBox.Items.Add(invite);

			while (reader.Read())
			{
				comboBox.Items.Add(reader[0]);
			}

			reader.Close();
			connection.Close();
			comboBox.SelectedItem = invite;           
		}

		// Случайно сгенерированные ивенты///////////////////////////////////////////////////////////
		private void Form1_Load(object sender, EventArgs e) { }
		private void tpStudents_Click(object sender, EventArgs e) { }
	
		private void lblStudCount_Click(object sender, EventArgs e) { }
		private void label1_Click(object sender, EventArgs e) { }
		//////////////////////////////////////////////////////////////////////////////////////////////

		void LoadTablesToComboBox()
		{
			string commandLine = $@"SELECT table_name FROM information_schema.tables";
			SqlCommand cmd = new SqlCommand(commandLine, connection);

			connection.Open();
			reader = cmd.ExecuteReader();

			while (reader.Read())
			{
				cbGroup.Items.Add(reader[0]);
			}

			reader.Close();
			connection.Close();
		}

		void LoadGroupsToComboBox(System.Windows.Forms.ComboBox combobox)
		{
			string commandLine = @"SELECT group_name FROM Groups";
			SqlCommand cmd = new SqlCommand(commandLine, connection);

			connection.Open();
			reader = cmd.ExecuteReader();

			while (reader.Read())
			{
				//cbGroup.Items.Add(reader[0]);
				combobox.Items.Add(reader[0]);
			}

			reader.Close();
			connection.Close();
		}

		public void LoadDataFromStorageToComboBox
			(
			System.Windows.Forms.ComboBox comboBox,
			string table_name,
			string column_name,
			string invite = "Выберите значение",
			string condition = null
			)
		{
			TableStorage storage = new TableStorage();
			storage.GetDataFromBase(table_name,column_name,condition);
			DataRow[] rows = storage.Set.Tables[0].Select();

			for(int i = 0; i < rows.Length;i++)
			{
				comboBox.Items.Add(rows[i][column_name]);
			}
		}

		public void SelectDataFromTable
			(
			System.Windows.Forms.DataGridView dataGridView,
			string commandLine
			//string table_name,
			//params string[] columns
			)
		{
			/*SqlCommand cmd = new SqlCommand();
			cmd.Connection = connection;
			cmd.CommandText = "SELECT ";

			for(int i = 0; i < columns.Length; i++)
			{
				cmd.Parameters.Add($"{columns[i]}", columns[i]);

				cmd.CommandText += $"{columns[i]}";
				cmd.CommandText += i == columns.Length - 1 ? " " : ", ";
			}
			cmd.CommandText += $"FROM {table_name}";
			*/
			SqlCommand cmd = new SqlCommand(commandLine, connection);

			connection.Open();
			reader = cmd.ExecuteReader();
			table = new DataTable();

			for(int i = 0; i <reader.FieldCount; i++)
			{
				table.Columns.Add(reader.GetName(i));
			}

			while(reader.Read())
			{
				DataRow row = table.NewRow();
				for(int i = 0; i < reader.FieldCount;i++)
				{
					row[i] = reader[i];
				}
				table.Rows.Add(row);
			}
			dataGridView.DataSource = table;

			reader.Close();
			connection.Close();
		}

		void SelectStudents(string group = "")
		{
			string commandLine =
				@"
SELECT 
	last_name,
	firts_name,
	middle_name,
	birth_date, 
	group_name			
FROM 
	Students JOIN Groups 
ON 
	[group] = group_id
				";
			if (group.Length != 0)
			{
				commandLine += $" WHERE [group_name] = '{group}'";
			}
			SqlCommand cmd = new SqlCommand(commandLine, connection);

			connection.Open();
			reader = cmd.ExecuteReader();
			table = new DataTable();

			for (int i = 0; i < reader.FieldCount; i++)
			{
				table.Columns.Add(reader.GetName(i));
			}

			while (reader.Read())
			{
				DataRow row = table.NewRow();
				for (int i = 0; i < reader.FieldCount; i++)
				{
					row[i] = reader[i];
				}
				row["birth_date"] = Convert.ToDateTime(reader["birth_date"]).ToString("dd.MM.yyyy");
				table.Rows.Add(row);
			}

			dgvStudents.DataSource = table;

			reader.Close();
			if (group.Length > 0)
			{
				cmd.CommandText =
					$@"
SELECT 
	COUNT(stud_id) 
FROM 
	Students JOIN Groups
ON
	Students.[group] = Groups.group_id
WHERE 
	[group_name] = '{group}'
GROUP BY
	group_name
					";
				lblStudCount.Text = $"Количество студентов: {Convert.ToInt32(cmd.ExecuteScalar()).ToString()}";
			}
			else
			{
				cmd.CommandText =
					$@"
SELECT 
	COUNT(stud_id) 
FROM 
	Students
					";
				lblStudCount.Text = $"Количество студентов: {Convert.ToInt32(cmd.ExecuteScalar()).ToString()}";
			}
			connection.Close();
		}

		private void cbGroups_SelectedIndexChanged(object sender, EventArgs e)
		{
			SelectStudents(cbGroup.SelectedItem.ToString().Trim());
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			AddStudent add_student = new AddStudent();
			LoadGroupsToComboBox(add_student.GroupCombo);
			DialogResult result = add_student.ShowDialog(this);
			if (result == DialogResult.OK)
			{
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = connection;
				cmd.Parameters.Add("@last_name", add_student.FullName.Split(' ')[0]);
				cmd.Parameters.Add("@firts_name", add_student.FullName.Split(' ')[1]);
				if (add_student.FullName.Split(' ').Length == 3)
				{
					cmd.Parameters.Add("@middle_name", add_student.FullName.Split(' ')[2]);
				}
				cmd.Parameters.Add("@birth_date", add_student.BirthDate.ToString("yyyy-MM-dd"));
				cmd.Parameters.Add("@group", add_student.Group);
				cmd.CommandText =
					@"
IF NOT EXISTS 
	(SELECT stud_id FROM Students WHERE last_name = @last_name AND firts_name = @firts_name AND middle_name = @middle_name)
BEGIN
INSERT INTO
	Students (last_name, firts_name, middle_name, birth_date, [group])
VALUES 
	(@last_name, @firts_name, @middle_name, @birth_date, (SELECT group_id FROM Groups WHERE group_name = @group))
END
					";
				connection.Open();

				cmd.ExecuteNonQuery();

				connection.Close();

				cbGroup.SelectedItem = add_student.Group;

				SelectStudents();

			}
		}

		public void LoadDirectionsToComboBox()
		{
			string commandLine = @"SELECT direction_name FROM Directions";
			SqlCommand cmd = new SqlCommand(commandLine, connection);
			connection.Open();
			reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				cbDirections.Items.Add(reader[0]);
			}
			reader.Close();
			connection.Close();
		}

		private void cbDirections_SelectedIndexChanged(object sender, EventArgs e)
		{
			dgvStudents.DataSource = null;
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = connection;
			if (cbDirections.SelectedItem != null)
			{
				cmd.Parameters.Add("@direction", cbDirections.SelectedItem);
			}

			if (rbStudents.Checked)
			{
				cmd.CommandText =
					@"
SELECT 
	last_name, firts_name, middle_name, birth_date, group_name, direction_name
FROM
	Students 
JOIN 
	Groups
ON
	Students.[group] = Groups.group_id
JOIN
	Directions
ON
	Groups.direction = Directions.direction_id
					";
				if (cbDirections.SelectedItem != null)
				{
					cmd.CommandText +=
						@"
 WHERE
	Directions.direction_name = @direction
						";
				}
			}
			if (rbGroups.Checked)
			{
				cmd.CommandText =
					@"
SELECT 
	group_name, direction_name
FROM
	Groups
JOIN
	Directions
ON
	Groups.direction = Directions.direction_id
					";
				if (cbDirections.SelectedItem != null)
				{
					cmd.CommandText +=
						@"
 WHERE
	Directions.direction_name = @direction
						";
				}
			}
			connection.Open();

			reader = cmd.ExecuteReader();
			table = new DataTable();
			for (int i = 0; i < reader.FieldCount; i++)
			{
				table.Columns.Add(reader.GetName(i));
			}

			while (reader.Read())
			{
				DataRow row = table.NewRow();
				for (int i = 0; i < reader.FieldCount; i++)
				{
					row[i] = reader[i];
				}
				table.Rows.Add(row);
			}
			dgvStudents.DataSource = table;
			reader.Close();
			int studCount = dgvStudents.RowCount - 1;
			lblStudCount.Text = $"Количество элементов: {studCount}";
			connection.Close();
		}
		private void rbGroups_CheckedChanged(object sender, EventArgs e)
		{
			if (rbStudents.Checked)
			{
				cbDirections_SelectedIndexChanged(sender, e);
			}
		}

		private void rbStudents_CheckedChanged(object sender, EventArgs e)
		{
			if (rbGroups.Checked)
			{
				cbDirections_SelectedIndexChanged(sender, e);
			}
		}

		private void cbDirectionOnGroupTab_SelectedIndexChanged(object sender, EventArgs e)
		{
			//SelectDataFromTable(dgvGroups, "Groups", "group_name", "direction");
			string commandLine =
				$@"
SELECT 
	group_name, direction_name 
FROM 
	Groups
JOIN
	Directions
ON
	Groups.direction = Directions.direction_id";
			if(cbDirectionOnGroupTab.SelectedIndex != 0)
			{
				commandLine += $@" WHERE direction_name = '{cbDirectionOnGroupTab.SelectedItem}'";
			}
			SelectDataFromTable(dgvGroups, commandLine);
			lblGroupsCount.Text = $"Количество элементов: {dgvGroups.Rows.Count - 1}";
		}

		private void btnGroupsAdd_Click(object sender, EventArgs e)
		{
			AddGroup add = new AddGroup(this);

			//LoadDataToComboBox(add.CBDirection, "Directions", "direction_name", "Выберите направление обучения");
			//LoadDataToComboBox(add.CBLearningForm, "LearningForms", "form_name", "Выберите форму обучения");
			//LoadDataToComboBox(add.CBLearningTime, "LearningTimes", "time_name", "Выберите время обучения");

			DialogResult result = add.ShowDialog();
			if(result == DialogResult.OK)
			{

			}
		}

		private void tbSearch_TextChanged(object sender, EventArgs e)
		{
			string name = tbSearch.Text;
			dgvStudents.DataSource = null;
			string commandLine =
				@"
SELECT 
	last_name,
	firts_name,
	middle_name,
	birth_date, 
	group_name			
FROM 
	Students JOIN Groups 
ON 
	[group] = group_id
				";

				commandLine += $" WHERE CONCAT(last_name, ' ', firts_name, ' ', middle_name) LIKE @name";

			SqlCommand cmd = new SqlCommand(commandLine, connection);
			cmd.Parameters.AddWithValue("@name", $"%{name}%");

			connection.Open();
			reader = cmd.ExecuteReader();
			table = new DataTable();

			for (int i = 0; i < reader.FieldCount; i++)
			{
				table.Columns.Add(reader.GetName(i));
			}

			while (reader.Read())
			{
				DataRow row = table.NewRow();
				for (int i = 0; i < reader.FieldCount; i++) row[i] = reader[i];
				table.Rows.Add(row);
			}
			dgvStudents.DataSource = table;

			reader.Close();
			connection.Close();

			//SelectDataFromTable(dgvStudents, commandLine);

			/*
			SqlCommand cmd = new SqlCommand(commandLine, connection);

			connection.Open();
			reader = cmd.ExecuteReader();
			table = new DataTable();

			for (int i = 0; i < reader.FieldCount; i++)
			{
				table.Columns.Add(reader.GetName(i));
			}

			while (reader.Read())
			{
				DataRow row = table.NewRow();
				for (int i = 0; i < reader.FieldCount; i++)
				{
					row[i] = reader[i];
				}
				row["birth_date"] = Convert.ToDateTime(reader["birth_date"]).ToString("dd.MM.yyyy");
				table.Rows.Add(row);
			}

			dgvStudents.DataSource = table;

			reader.Close();
			connection.Close();*/

		}
		private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string collumName = dgvStudents.Columns[e.ColumnIndex].Name;
			if (collumName == "last_name")
			{
				string cellName = dgvStudents.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
				StudentInfo studentInfo = new StudentInfo(cellName);
				studentInfo.ShowDialog();
			}
		}
	}
}

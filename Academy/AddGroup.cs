using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.InteropServices;

namespace Academy
{
	public partial class AddGroup : Form
	{
		Form1 mainForm;
		private string connectionString;
		SqlConnection connection;
		SqlDataAdapter adapter; //Вытягивает результаты запросов из Базы и сохраняет их в DataSet
		DataSet set;
		SqlCommandBuilder builder;

		string[] week = new string[] { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
		CheckBox[] cbWeek;
		public System.Windows.Forms.ComboBox CBDirection { get => cbDirection; }
		public System.Windows.Forms.ComboBox CBLearningForm { get => cbLearningForm; }
		public System.Windows.Forms.ComboBox CBLearningTime { get => cbTime; }
		public AddGroup(Form1 mainForm)
		{
			this.mainForm = mainForm;
			InitializeComponent();

			connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
			connection = new SqlConnection(connectionString);

			GetDataFromBase();

			mainForm.LoadDataToComboBox(cbLearningForm, "LearningForms", "form_name", "Выберите форму обучения");
			//mainForm.LoadDataToComboBox(cbDirection,"Directions","direction_name","Выберите направление обучения");
			mainForm.LoadDataToComboBox(cbTime, "LearningTimes", "time_name", "Выберите время обучения");

			cbWeek = new CheckBox[7];
		}

		private void cbMonday_CheckedChanged(object sender, EventArgs e){}

		private void LoadComboBox(string sourceTable){}
		byte GetBitSet()
		{
			byte days = 0;
			/*AllocConsole();

            Console.WriteLine("Days:\t");

            for (int i =0; i < lcbWeek.CheckedItems.Count;i++)
			{
				Console.Write(lcbWeek.CheckedItems[i] + "\t");
			}

            Console.WriteLine();
            Console.WriteLine("Nums:\t");

			for(int i = 0;i < lcbWeek.CheckedIndices.Count;i++)
			{
				Console.WriteLine(lcbWeek.CheckedIndices[i]+"\t");
            }

            Console.WriteLine();
            Console.WriteLine("\n---------------------------------------------------\n");
*/
			for (int i = 0; i < lcbWeek.CheckedIndices.Count; i++)
			{
				/*byte day = (byte)Math.Pow(2, lcbWeek.CheckedIndices[i]);
				days += day;*/
				byte day = 1;
				day <<= lcbWeek.CheckedIndices[i];
				days |= day;
				/*
				 --------------------------------------------------------------------------------------------------------------------

				<< (побитовый сдвиг влево) - это бинарный оператор, который сдвигает число на заданное количество бит влево.
											 Сдвиг числа на 1 бит	влево увеличивает число в два		раза	(выполняет умножение числа на 2)
											 Сдвиг числа на 2 бита	влево увеличивает число в четыре	раза	(выполняет умножение числа на 4)
											 Сдвиг числа на 3 бит	влево увеличивает число в восемь	раз		(выполняет умножение числа на 8)
				 --------------------------------------------------------------------------------------------------------------------

				| (побитовое сложение, побитовый OR) - если соответствующий бит хотя бы в одном операнде == 1, то этот же бит результата будет 1. 

				 --------------------------------------------------------------------------------------------------------------------

				Все побитовые операторы можно комбинировать с оператором присваивания
				
				 --------------------------------------------------------------------------------------------------------------------
				 
				 */
			}

			return days;
		}
		//[DllImport("kernel32.dll")]
		//[return: MarshalAs(UnmanagedType.Bool)]
		//static extern bool AllocConsole();
		void GetDataFromBase()
		{
			try 
			{
				set = new DataSet();
				string cmd = $@"SELECT * FROM Directions";
				adapter = new SqlDataAdapter(cmd, connection);
				builder = new SqlCommandBuilder(adapter);

				adapter.Fill(set, "Directions");
				adapter.SelectCommand.CommandText = $@"SELECT * FROM LearningTimes";
				builder.DataAdapter = adapter;

				adapter.Fill(set, "LearningTimes"); // Можно произвольно указывать имя
			}
			catch (Exception e)
			{
				MessageBox.Show(this, e.Message);
			}
		}

		string GenerateGroupName()
		{
			if(!AllCombosOK())
			{
				return "Что-то пошло не так";
			}
			string group_name = "";
			if(CBLearningForm.SelectedItem.ToString() != "Годичные курсы")
			{
				if(cbLearningForm.SelectedItem.ToString() == "Полустационар")
					group_name += lcbWeek.SelectedItem.ToString() == "Сб" ? "S" : "V";
				{
					group_name += 
						set.Tables["Directions"].Select($"direction_name = '{CBDirection.SelectedItem.ToString()}'")[0]["direction_code_name"].ToString().Trim();
					group_name += 
						set.Tables["LearningTimes"].Select($"time_name = '{CBLearningTime.SelectedItem.ToString()}'")[0]["time_code_name"].ToString().Trim();
				}
			}
			group_name += "_";
			return group_name;
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			tbGroupName.Text = GenerateGroupName();
		}

		private void cbLearningForm_SelectedIndexChanged(object sender, EventArgs e)
		{
			/*cbDirection.Items.Clear();
			if (cbLearningForm.SelectedIndex != 0) { 
			mainForm.LoadDataFromStorageToComboBox
				(
				cbDirection,
				"Directions, LearningForms, LearningFormsDirectionsRelation",
				"direction_name",
				"Выберите форму обучения",
				$@"

	LearningFormsDirectionsRelation.learning_form = LearningForms.form_id
AND
	LearningFormsDirectionsRelation.direction = Directions.direction_id
AND
	form_name = '{cbLearningForm.SelectedItem.ToString()}'
	"
				);
			}*/
			int selectedIndexInDirection = cbDirection.SelectedIndex;
			string directionName = cbDirection.SelectedItem?.ToString();

			cbDirection.Items.Clear();
			if (cbLearningForm.SelectedIndex != 0)
				mainForm.LoadDataFromStorageToComboBox
								(
								cbDirection,
								"Directions, LearningForms, LearningFormsDirectionsRelation",
								"direction_name",
								"Выберите форму обучения",
								$@"
		LearningFormsDirectionsRelation.learning_form	= LearningForms.form_id
AND		LearningFormsDirectionsRelation.direction		= Directions.direction_id
AND		form_name = '{cbLearningForm.SelectedItem.ToString()}'
"
								);
			//cbDirection.SelectedIndex = selectedIndexInDirection < cbDirection.Items.Count ? selectedIndexInDirection : -1;
			bool badDirection = false;
			if (selectedIndexInDirection < cbDirection.Items.Count)
			{
				cbDirection.SelectedIndex = selectedIndexInDirection;
			}
			else
			{
				badDirection = true;
			}
			if (directionName != cbDirection.SelectedItem?.ToString()) badDirection = true;
			if (badDirection)
			{
				cbDirection.SelectedIndex = -1;
				cbDirection.Text = "Выберите направление обучения";
				MessageBox.Show(this, "На данной фломе обучения нет такого направления", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
				cbDirection.Select();
			}
		}

		private void lcbWeek_SelectedIndexChanged(object sender, EventArgs e)
		{
			lblLearningDays.Text = $"Дни обучения: {GetBitSet()}";
		}
		bool ComboBoxOK(ComboBox comboBox)
		{
			if(comboBox.SelectedItem == null)
			{
				return false;
			}
			if(comboBox.SelectedItem.ToString().Contains(" обучения"))
			{
				return false;
			}
			return true;
		}
		bool AllCombosOK()
		{
			string message = "";
			if(cbLearningForm.SelectedIndex == 0)
			{
				message = "Выберите форму обучения";
			}
			else if(cbDirection.SelectedItem == null || cbDirection.SelectedItem.ToString() == "Выберите направление обучения")
			{
				message = "Выберите направление обучения";
			}
			else if (cbTime.SelectedIndex == 0)
			{
				message = "Выберите время обучения";
			}
			if(message.Length > 0)
			{
				MessageBox.Show
					(
					this,
					message,
					"Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
					);
				return false;
			}
			return true;
		}
		private void btnCreateGroup_Click(object sender, EventArgs e)
		{
			if(AllCombosOK() == false)
			{
				return;
			}
			bool wrong_days = false;

			if (cbLearningForm.SelectedItem.ToString() == "Стационар"		&& lcbWeek.CheckedItems.Count != 3)
			{
				wrong_days = true;
			}
			if (cbLearningForm.SelectedItem.ToString() == "Полустационар"	&& lcbWeek.CheckedItems.Count != 1)
			{
				wrong_days = true;
			}
			if (cbLearningForm.SelectedItem.ToString() == "Годичные курсы"	&& lcbWeek.CheckedItems.Count != 2)
			{
				wrong_days = true;
			}

			if(wrong_days)
			{
				MessageBox.Show
					(
					this,
					"Проверьте дни обучения",
					"Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
					);
			}
			else
			{
				MessageBox.Show
					(
					this,
					"Done.",
					"Info",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
					);
			}

			if(wrong_days)
			{
				return;
			}

			TableStorage storage = new TableStorage();
			storage.GetDataFromBase("Directions");
			storage.GetDataFromBase("LearningTimes");
			storage.GetDataFromBase("Groups");

			if (storage.Set.Tables["Groups"].Select($"group_name = '{tbGroupName.Text}'").Length == 0)
			{
				DataRow row = storage.Set.Tables["Groups"].NewRow();

			row["group_name"]		= tbGroupName.Text;
			row["direction"]		= storage.Set.Tables["Directions"].Select($"direction_name = '{cbDirection.SelectedItem.ToString()}'")[0]["direction_id"];
			row["learning_time"]	= storage.Set.Tables["LearningTimes"].Select($"time_name = '{cbTime.SelectedItem.ToString()}'")[0]["time_id"];
			row["learning_days"]	= GetBitSet();

			storage.Set.Tables["Groups"].Rows.Add(row);
			storage.Adapter.Update(storage.Set,"Groups");
			this.Close();

			}
			else
			{
				MessageBox.Show(this, "Такая группа уже есть", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}

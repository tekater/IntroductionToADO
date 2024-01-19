using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
	public partial class AddStudent : Form
	{
		public string FullName { get; set; }
		public DateTime BirthDate { get; set; }

		public string Group { get; set; }
		public ComboBox GroupCombo
		{
			get
			{
				return cbGroups;
			}
		}

		public AddStudent()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			FullName = textBoxFullName.Text;
			BirthDate = dtpBirthDate.Value;
			Group = cbGroups.SelectedItem.ToString();
			this.Close();
		}
	}
}

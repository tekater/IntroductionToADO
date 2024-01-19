namespace Academy
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cbGroup = new System.Windows.Forms.ComboBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tpStudents = new System.Windows.Forms.TabPage();
			this.lblStudCount = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.dgvStudents = new System.Windows.Forms.DataGridView();
			this.tpTeachers = new System.Windows.Forms.TabPage();
			this.tabControl1.SuspendLayout();
			this.tpStudents.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
			this.SuspendLayout();
			// 
			// cbGroup
			// 
			this.cbGroup.FormattingEnabled = true;
			this.cbGroup.Location = new System.Drawing.Point(6, 6);
			this.cbGroup.Name = "cbGroup";
			this.cbGroup.Size = new System.Drawing.Size(299, 21);
			this.cbGroup.TabIndex = 0;
			this.cbGroup.SelectedIndexChanged += new System.EventHandler(this.cbGroups_SelectedIndexChanged);
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tpStudents);
			this.tabControl1.Controls.Add(this.tpTeachers);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(764, 399);
			this.tabControl1.TabIndex = 1;
			// 
			// tpStudents
			// 
			this.tpStudents.Controls.Add(this.lblStudCount);
			this.tpStudents.Controls.Add(this.btnAdd);
			this.tpStudents.Controls.Add(this.dgvStudents);
			this.tpStudents.Controls.Add(this.cbGroup);
			this.tpStudents.Location = new System.Drawing.Point(4, 22);
			this.tpStudents.Name = "tpStudents";
			this.tpStudents.Padding = new System.Windows.Forms.Padding(3);
			this.tpStudents.Size = new System.Drawing.Size(756, 373);
			this.tpStudents.TabIndex = 0;
			this.tpStudents.Text = "Студенты";
			this.tpStudents.UseVisualStyleBackColor = true;
			this.tpStudents.Click += new System.EventHandler(this.tpStudents_Click);
			// 
			// lblStudCount
			// 
			this.lblStudCount.AutoSize = true;
			this.lblStudCount.Location = new System.Drawing.Point(311, 14);
			this.lblStudCount.Name = "lblStudCount";
			this.lblStudCount.Size = new System.Drawing.Size(120, 13);
			this.lblStudCount.TabIndex = 3;
			this.lblStudCount.Text = "Количество студентов";
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.Location = new System.Drawing.Point(675, 6);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Добавить";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// dgvStudents
			// 
			this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStudents.Location = new System.Drawing.Point(7, 34);
			this.dgvStudents.Name = "dgvStudents";
			this.dgvStudents.Size = new System.Drawing.Size(743, 333);
			this.dgvStudents.TabIndex = 1;
			// 
			// tpTeachers
			// 
			this.tpTeachers.Location = new System.Drawing.Point(4, 22);
			this.tpTeachers.Name = "tpTeachers";
			this.tpTeachers.Padding = new System.Windows.Forms.Padding(3);
			this.tpTeachers.Size = new System.Drawing.Size(756, 373);
			this.tpTeachers.TabIndex = 1;
			this.tpTeachers.Text = "Преподаватели";
			this.tpTeachers.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tpStudents.ResumeLayout(false);
			this.tpStudents.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox cbGroup;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tpStudents;
		private System.Windows.Forms.TabPage tpTeachers;
		private System.Windows.Forms.DataGridView dgvStudents;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label lblStudCount;
	}
}


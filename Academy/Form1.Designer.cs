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
			this.btnAddGroup = new System.Windows.Forms.Button();
			this.rbStudents = new System.Windows.Forms.RadioButton();
			this.rbGroups = new System.Windows.Forms.RadioButton();
			this.lblSpeciality = new System.Windows.Forms.Label();
			this.lblGroup = new System.Windows.Forms.Label();
			this.cbDirections = new System.Windows.Forms.ComboBox();
			this.lblStudCount = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.dgvStudents = new System.Windows.Forms.DataGridView();
			this.tpTeachers = new System.Windows.Forms.TabPage();
			this.tabPageGroups = new System.Windows.Forms.TabPage();
			this.lblGroupsCount = new System.Windows.Forms.Label();
			this.cbDirectionOnGroupTab = new System.Windows.Forms.ComboBox();
			this.dgvGroups = new System.Windows.Forms.DataGridView();
			this.btnGroupsAdd = new System.Windows.Forms.Button();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.tabControl1.SuspendLayout();
			this.tpStudents.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
			this.tabPageGroups.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
			this.SuspendLayout();
			// 
			// cbGroup
			// 
			this.cbGroup.FormattingEnabled = true;
			this.cbGroup.Location = new System.Drawing.Point(92, 6);
			this.cbGroup.Name = "cbGroup";
			this.cbGroup.Size = new System.Drawing.Size(241, 21);
			this.cbGroup.TabIndex = 0;
			this.cbGroup.SelectedIndexChanged += new System.EventHandler(this.cbGroups_SelectedIndexChanged);
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tpStudents);
			this.tabControl1.Controls.Add(this.tpTeachers);
			this.tabControl1.Controls.Add(this.tabPageGroups);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(796, 530);
			this.tabControl1.TabIndex = 1;
			// 
			// tpStudents
			// 
			this.tpStudents.Controls.Add(this.tbSearch);
			this.tpStudents.Controls.Add(this.btnAddGroup);
			this.tpStudents.Controls.Add(this.rbStudents);
			this.tpStudents.Controls.Add(this.rbGroups);
			this.tpStudents.Controls.Add(this.lblSpeciality);
			this.tpStudents.Controls.Add(this.lblGroup);
			this.tpStudents.Controls.Add(this.cbDirections);
			this.tpStudents.Controls.Add(this.lblStudCount);
			this.tpStudents.Controls.Add(this.btnAdd);
			this.tpStudents.Controls.Add(this.dgvStudents);
			this.tpStudents.Controls.Add(this.cbGroup);
			this.tpStudents.Location = new System.Drawing.Point(4, 22);
			this.tpStudents.Name = "tpStudents";
			this.tpStudents.Padding = new System.Windows.Forms.Padding(3);
			this.tpStudents.Size = new System.Drawing.Size(788, 504);
			this.tpStudents.TabIndex = 0;
			this.tpStudents.Text = "Студенты";
			this.tpStudents.UseVisualStyleBackColor = true;
			this.tpStudents.Click += new System.EventHandler(this.tpStudents_Click);
			// 
			// btnAddGroup
			// 
			this.btnAddGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddGroup.Location = new System.Drawing.Point(677, 35);
			this.btnAddGroup.Name = "btnAddGroup";
			this.btnAddGroup.Size = new System.Drawing.Size(105, 23);
			this.btnAddGroup.TabIndex = 9;
			this.btnAddGroup.Text = "Добавить Группу";
			this.btnAddGroup.UseVisualStyleBackColor = true;
			// 
			// rbStudents
			// 
			this.rbStudents.AutoSize = true;
			this.rbStudents.Location = new System.Drawing.Point(101, 59);
			this.rbStudents.Name = "rbStudents";
			this.rbStudents.Size = new System.Drawing.Size(67, 17);
			this.rbStudents.TabIndex = 8;
			this.rbStudents.TabStop = true;
			this.rbStudents.Text = "Students";
			this.rbStudents.UseVisualStyleBackColor = true;
			this.rbStudents.CheckedChanged += new System.EventHandler(this.rbStudents_CheckedChanged);
			// 
			// rbGroups
			// 
			this.rbGroups.AutoSize = true;
			this.rbGroups.Location = new System.Drawing.Point(10, 59);
			this.rbGroups.Name = "rbGroups";
			this.rbGroups.Size = new System.Drawing.Size(59, 17);
			this.rbGroups.TabIndex = 7;
			this.rbGroups.TabStop = true;
			this.rbGroups.Text = "Groups";
			this.rbGroups.UseVisualStyleBackColor = true;
			this.rbGroups.CheckedChanged += new System.EventHandler(this.rbGroups_CheckedChanged);
			// 
			// lblSpeciality
			// 
			this.lblSpeciality.AutoSize = true;
			this.lblSpeciality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblSpeciality.Location = new System.Drawing.Point(6, 30);
			this.lblSpeciality.Name = "lblSpeciality";
			this.lblSpeciality.Size = new System.Drawing.Size(80, 20);
			this.lblSpeciality.TabIndex = 6;
			this.lblSpeciality.Text = "Speciality:";
			// 
			// lblGroup
			// 
			this.lblGroup.AutoSize = true;
			this.lblGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblGroup.Location = new System.Drawing.Point(5, 6);
			this.lblGroup.Name = "lblGroup";
			this.lblGroup.Size = new System.Drawing.Size(58, 20);
			this.lblGroup.TabIndex = 5;
			this.lblGroup.Text = "Group:";
			this.lblGroup.Click += new System.EventHandler(this.label1_Click);
			// 
			// cbDirections
			// 
			this.cbDirections.FormattingEnabled = true;
			this.cbDirections.Location = new System.Drawing.Point(92, 30);
			this.cbDirections.Name = "cbDirections";
			this.cbDirections.Size = new System.Drawing.Size(241, 21);
			this.cbDirections.TabIndex = 4;
			this.cbDirections.SelectedIndexChanged += new System.EventHandler(this.cbDirections_SelectedIndexChanged);
			// 
			// lblStudCount
			// 
			this.lblStudCount.AutoSize = true;
			this.lblStudCount.Location = new System.Drawing.Point(187, 61);
			this.lblStudCount.Name = "lblStudCount";
			this.lblStudCount.Size = new System.Drawing.Size(120, 13);
			this.lblStudCount.TabIndex = 3;
			this.lblStudCount.Text = "Количество студентов";
			this.lblStudCount.Click += new System.EventHandler(this.lblStudCount_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.Location = new System.Drawing.Point(677, 6);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(105, 23);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Добавить";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// dgvStudents
			// 
			this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvStudents.Location = new System.Drawing.Point(9, 82);
			this.dgvStudents.Name = "dgvStudents";
			this.dgvStudents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvStudents.Size = new System.Drawing.Size(773, 416);
			this.dgvStudents.TabIndex = 1;
			this.dgvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellContentClick);
			// 
			// tpTeachers
			// 
			this.tpTeachers.Location = new System.Drawing.Point(4, 22);
			this.tpTeachers.Name = "tpTeachers";
			this.tpTeachers.Padding = new System.Windows.Forms.Padding(3);
			this.tpTeachers.Size = new System.Drawing.Size(788, 504);
			this.tpTeachers.TabIndex = 1;
			this.tpTeachers.Text = "Преподаватели";
			this.tpTeachers.UseVisualStyleBackColor = true;
			// 
			// tabPageGroups
			// 
			this.tabPageGroups.BackColor = System.Drawing.SystemColors.Control;
			this.tabPageGroups.Controls.Add(this.lblGroupsCount);
			this.tabPageGroups.Controls.Add(this.cbDirectionOnGroupTab);
			this.tabPageGroups.Controls.Add(this.dgvGroups);
			this.tabPageGroups.Controls.Add(this.btnGroupsAdd);
			this.tabPageGroups.Location = new System.Drawing.Point(4, 22);
			this.tabPageGroups.Name = "tabPageGroups";
			this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageGroups.Size = new System.Drawing.Size(788, 504);
			this.tabPageGroups.TabIndex = 2;
			this.tabPageGroups.Text = "Группы";
			// 
			// lblGroupsCount
			// 
			this.lblGroupsCount.AutoSize = true;
			this.lblGroupsCount.Location = new System.Drawing.Point(406, 7);
			this.lblGroupsCount.Name = "lblGroupsCount";
			this.lblGroupsCount.Size = new System.Drawing.Size(130, 13);
			this.lblGroupsCount.TabIndex = 13;
			this.lblGroupsCount.Text = "Количество элементов: ";
			// 
			// cbDirectionOnGroupTab
			// 
			this.cbDirectionOnGroupTab.FormattingEnabled = true;
			this.cbDirectionOnGroupTab.Location = new System.Drawing.Point(9, 7);
			this.cbDirectionOnGroupTab.Name = "cbDirectionOnGroupTab";
			this.cbDirectionOnGroupTab.Size = new System.Drawing.Size(380, 21);
			this.cbDirectionOnGroupTab.TabIndex = 12;
			this.cbDirectionOnGroupTab.SelectedIndexChanged += new System.EventHandler(this.cbDirectionOnGroupTab_SelectedIndexChanged);
			// 
			// dgvGroups
			// 
			this.dgvGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvGroups.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvGroups.Location = new System.Drawing.Point(9, 35);
			this.dgvGroups.Name = "dgvGroups";
			this.dgvGroups.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dgvGroups.Size = new System.Drawing.Size(785, 463);
			this.dgvGroups.TabIndex = 11;
			// 
			// btnGroupsAdd
			// 
			this.btnGroupsAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGroupsAdd.Location = new System.Drawing.Point(677, 6);
			this.btnGroupsAdd.Name = "btnGroupsAdd";
			this.btnGroupsAdd.Size = new System.Drawing.Size(105, 23);
			this.btnGroupsAdd.TabIndex = 10;
			this.btnGroupsAdd.Text = "Добавить Группу";
			this.btnGroupsAdd.UseVisualStyleBackColor = true;
			this.btnGroupsAdd.Click += new System.EventHandler(this.btnGroupsAdd_Click);
			// 
			// tbSearch
			// 
			this.tbSearch.Location = new System.Drawing.Point(351, 5);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(274, 20);
			this.tbSearch.TabIndex = 10;
			this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(820, 554);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tpStudents.ResumeLayout(false);
			this.tpStudents.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
			this.tabPageGroups.ResumeLayout(false);
			this.tabPageGroups.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
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
		private System.Windows.Forms.ComboBox cbDirections;
		private System.Windows.Forms.Label lblGroup;
		private System.Windows.Forms.Label lblSpeciality;
		private System.Windows.Forms.RadioButton rbStudents;
		private System.Windows.Forms.RadioButton rbGroups;
		private System.Windows.Forms.Button btnAddGroup;
		private System.Windows.Forms.TabPage tabPageGroups;
		private System.Windows.Forms.DataGridView dgvGroups;
		private System.Windows.Forms.Button btnGroupsAdd;
		private System.Windows.Forms.ComboBox cbDirectionOnGroupTab;
		private System.Windows.Forms.Label lblGroupsCount;
		private System.Windows.Forms.TextBox tbSearch;
	}
}


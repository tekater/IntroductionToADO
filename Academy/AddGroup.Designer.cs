namespace Academy
{
	partial class AddGroup
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
			this.tbGroupName = new System.Windows.Forms.TextBox();
			this.cbDirection = new System.Windows.Forms.ComboBox();
			this.cbLearningForm = new System.Windows.Forms.ComboBox();
			this.cbTime = new System.Windows.Forms.ComboBox();
			this.lcbWeek = new System.Windows.Forms.CheckedListBox();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.lblLearningDays = new System.Windows.Forms.Label();
			this.btnCreateGroup = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbGroupName
			// 
			this.tbGroupName.Location = new System.Drawing.Point(3, 154);
			this.tbGroupName.Name = "tbGroupName";
			this.tbGroupName.Size = new System.Drawing.Size(326, 20);
			this.tbGroupName.TabIndex = 6;
			this.tbGroupName.Text = "Название группы";
			// 
			// cbDirection
			// 
			this.cbDirection.FormattingEnabled = true;
			this.cbDirection.Location = new System.Drawing.Point(54, 56);
			this.cbDirection.Name = "cbDirection";
			this.cbDirection.Size = new System.Drawing.Size(275, 21);
			this.cbDirection.TabIndex = 8;
			this.cbDirection.Text = "Выберите направление Обучения";
			// 
			// cbLearningForm
			// 
			this.cbLearningForm.FormattingEnabled = true;
			this.cbLearningForm.Location = new System.Drawing.Point(54, 12);
			this.cbLearningForm.Name = "cbLearningForm";
			this.cbLearningForm.Size = new System.Drawing.Size(275, 21);
			this.cbLearningForm.TabIndex = 9;
			this.cbLearningForm.Text = "Форма Обучения";
			this.cbLearningForm.SelectedIndexChanged += new System.EventHandler(this.cbLearningForm_SelectedIndexChanged);
			// 
			// cbTime
			// 
			this.cbTime.FormattingEnabled = true;
			this.cbTime.Location = new System.Drawing.Point(54, 101);
			this.cbTime.Name = "cbTime";
			this.cbTime.Size = new System.Drawing.Size(275, 21);
			this.cbTime.TabIndex = 10;
			this.cbTime.Text = "Время Обучения";
			// 
			// lcbWeek
			// 
			this.lcbWeek.CheckOnClick = true;
			this.lcbWeek.ColumnWidth = 64;
			this.lcbWeek.FormattingEnabled = true;
			this.lcbWeek.Items.AddRange(new object[] {
            "Пн",
            "Вт",
            "Ср",
            "Чт",
            "Пт",
            "Сб",
            "Вс"});
			this.lcbWeek.Location = new System.Drawing.Point(3, 13);
			this.lcbWeek.MultiColumn = true;
			this.lcbWeek.Name = "lcbWeek";
			this.lcbWeek.Size = new System.Drawing.Size(45, 109);
			this.lcbWeek.TabIndex = 11;
			this.lcbWeek.SelectedIndexChanged += new System.EventHandler(this.lcbWeek_SelectedIndexChanged);
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(254, 180);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(75, 23);
			this.btnGenerate.TabIndex = 12;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// lblLearningDays
			// 
			this.lblLearningDays.AutoSize = true;
			this.lblLearningDays.Location = new System.Drawing.Point(0, 138);
			this.lblLearningDays.Name = "lblLearningDays";
			this.lblLearningDays.Size = new System.Drawing.Size(77, 13);
			this.lblLearningDays.TabIndex = 13;
			this.lblLearningDays.Text = "Дни обучения";
			// 
			// btnCreateGroup
			// 
			this.btnCreateGroup.Location = new System.Drawing.Point(3, 180);
			this.btnCreateGroup.Name = "btnCreateGroup";
			this.btnCreateGroup.Size = new System.Drawing.Size(245, 23);
			this.btnCreateGroup.TabIndex = 14;
			this.btnCreateGroup.Text = "Создать группу";
			this.btnCreateGroup.UseVisualStyleBackColor = true;
			this.btnCreateGroup.Click += new System.EventHandler(this.btnCreateGroup_Click);
			// 
			// AddGroup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(341, 214);
			this.Controls.Add(this.btnCreateGroup);
			this.Controls.Add(this.lblLearningDays);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.lcbWeek);
			this.Controls.Add(this.cbTime);
			this.Controls.Add(this.cbLearningForm);
			this.Controls.Add(this.cbDirection);
			this.Controls.Add(this.tbGroupName);
			this.Name = "AddGroup";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "AddGroup";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox tbGroupName;
		private System.Windows.Forms.ComboBox cbDirection;
		private System.Windows.Forms.ComboBox cbLearningForm;
		private System.Windows.Forms.ComboBox cbTime;
		private System.Windows.Forms.CheckedListBox lcbWeek;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Label lblLearningDays;
		private System.Windows.Forms.Button btnCreateGroup;
	}
}
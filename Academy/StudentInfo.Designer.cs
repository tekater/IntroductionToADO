namespace Academy
{
	partial class StudentInfo
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
			this.tbName = new System.Windows.Forms.TextBox();
			this.lblFIO = new System.Windows.Forms.Label();
			this.tbGroup = new System.Windows.Forms.TextBox();
			this.lblGroups = new System.Windows.Forms.Label();
			this.lblAge = new System.Windows.Forms.Label();
			this.tbAge = new System.Windows.Forms.TextBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(16, 32);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(302, 20);
			this.tbName.TabIndex = 0;
			this.tbName.Text = "Имя";
			// 
			// lblFIO
			// 
			this.lblFIO.AutoSize = true;
			this.lblFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblFIO.Location = new System.Drawing.Point(12, 9);
			this.lblFIO.Name = "lblFIO";
			this.lblFIO.Size = new System.Drawing.Size(125, 20);
			this.lblFIO.TabIndex = 1;
			this.lblFIO.Text = "ФИО Студента";
			this.lblFIO.Click += new System.EventHandler(this.label1_Click);
			// 
			// tbGroup
			// 
			this.tbGroup.Location = new System.Drawing.Point(16, 98);
			this.tbGroup.Name = "tbGroup";
			this.tbGroup.Size = new System.Drawing.Size(302, 20);
			this.tbGroup.TabIndex = 2;
			this.tbGroup.Text = "Группа";
			// 
			// lblGroups
			// 
			this.lblGroups.AutoSize = true;
			this.lblGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblGroups.Location = new System.Drawing.Point(12, 75);
			this.lblGroups.Name = "lblGroups";
			this.lblGroups.Size = new System.Drawing.Size(139, 20);
			this.lblGroups.TabIndex = 3;
			this.lblGroups.Text = "Группа Студента";
			// 
			// lblAge
			// 
			this.lblAge.AutoSize = true;
			this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblAge.Location = new System.Drawing.Point(12, 144);
			this.lblAge.Name = "lblAge";
			this.lblAge.Size = new System.Drawing.Size(150, 20);
			this.lblAge.TabIndex = 5;
			this.lblAge.Text = "Возраст Студента";
			// 
			// tbAge
			// 
			this.tbAge.Location = new System.Drawing.Point(16, 167);
			this.tbAge.Name = "tbAge";
			this.tbAge.Size = new System.Drawing.Size(302, 20);
			this.tbAge.TabIndex = 4;
			this.tbAge.Text = "Возраст";
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(242, 337);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 6;
			this.btnOk.Text = "Ok";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// StudentInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(331, 372);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.lblAge);
			this.Controls.Add(this.tbAge);
			this.Controls.Add(this.lblGroups);
			this.Controls.Add(this.tbGroup);
			this.Controls.Add(this.lblFIO);
			this.Controls.Add(this.tbName);
			this.Name = "StudentInfo";
			this.Text = "StudentInfo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Label lblFIO;
		private System.Windows.Forms.TextBox tbGroup;
		private System.Windows.Forms.Label lblGroups;
		private System.Windows.Forms.Label lblAge;
		private System.Windows.Forms.TextBox tbAge;
		private System.Windows.Forms.Button btnOk;
	}
}
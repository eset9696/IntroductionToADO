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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvStudents = new System.Windows.Forms.DataGridView();
			this.cbGroups = new System.Windows.Forms.ComboBox();
			this.btnAddStudent = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btnAddTeacher = new System.Windows.Forms.Button();
			this.dgvTeachers = new System.Windows.Forms.DataGridView();
			this.cbSpecialities = new System.Windows.Forms.ComboBox();
			this.labelSpeciality = new System.Windows.Forms.Label();
			this.btnDeleteStudent = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvStudents
			// 
			dataGridViewCellStyle1.NullValue = null;
			this.dgvStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvStudents.BackgroundColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.NullValue = null;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.NullValue = null;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvStudents.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvStudents.Location = new System.Drawing.Point(6, 33);
			this.dgvStudents.Name = "dgvStudents";
			dataGridViewCellStyle4.Format = "d";
			dataGridViewCellStyle4.NullValue = null;
			this.dgvStudents.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvStudents.Size = new System.Drawing.Size(756, 332);
			this.dgvStudents.TabIndex = 1;
			// 
			// cbGroups
			// 
			this.cbGroups.FormattingEnabled = true;
			this.cbGroups.Location = new System.Drawing.Point(59, 6);
			this.cbGroups.Name = "cbGroups";
			this.cbGroups.Size = new System.Drawing.Size(161, 21);
			this.cbGroups.TabIndex = 2;
			this.cbGroups.SelectedIndexChanged += new System.EventHandler(this.cbGroups_SelectedIndexChanged);
			// 
			// btnAddStudent
			// 
			this.btnAddStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddStudent.Location = new System.Drawing.Point(606, 371);
			this.btnAddStudent.Name = "btnAddStudent";
			this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
			this.btnAddStudent.TabIndex = 3;
			this.btnAddStudent.Text = "Add";
			this.btnAddStudent.UseVisualStyleBackColor = true;
			this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(776, 426);
			this.tabControl1.TabIndex = 4;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.btnDeleteStudent);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.cbGroups);
			this.tabPage1.Controls.Add(this.dgvStudents);
			this.tabPage1.Controls.Add(this.btnAddStudent);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(768, 400);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Студенты";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(6, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "Group:";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.btnAddTeacher);
			this.tabPage2.Controls.Add(this.dgvTeachers);
			this.tabPage2.Controls.Add(this.cbSpecialities);
			this.tabPage2.Controls.Add(this.labelSpeciality);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(768, 400);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Преподаватели";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// btnAddTeacher
			// 
			this.btnAddTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddTeacher.Location = new System.Drawing.Point(687, 371);
			this.btnAddTeacher.Name = "btnAddTeacher";
			this.btnAddTeacher.Size = new System.Drawing.Size(75, 23);
			this.btnAddTeacher.TabIndex = 3;
			this.btnAddTeacher.Text = "Add";
			this.btnAddTeacher.UseVisualStyleBackColor = true;
			// 
			// dgvTeachers
			// 
			this.dgvTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvTeachers.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTeachers.Location = new System.Drawing.Point(10, 33);
			this.dgvTeachers.Name = "dgvTeachers";
			this.dgvTeachers.Size = new System.Drawing.Size(752, 332);
			this.dgvTeachers.TabIndex = 2;
			// 
			// cbSpecialities
			// 
			this.cbSpecialities.FormattingEnabled = true;
			this.cbSpecialities.Location = new System.Drawing.Point(75, 6);
			this.cbSpecialities.Name = "cbSpecialities";
			this.cbSpecialities.Size = new System.Drawing.Size(293, 21);
			this.cbSpecialities.TabIndex = 1;
			this.cbSpecialities.SelectedIndexChanged += new System.EventHandler(this.cbSpecialities_SelectedIndexChanged);
			// 
			// labelSpeciality
			// 
			this.labelSpeciality.AutoSize = true;
			this.labelSpeciality.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelSpeciality.Location = new System.Drawing.Point(3, 7);
			this.labelSpeciality.Name = "labelSpeciality";
			this.labelSpeciality.Size = new System.Drawing.Size(66, 16);
			this.labelSpeciality.TabIndex = 0;
			this.labelSpeciality.Text = "Speciality";
			// 
			// btnDeleteStudent
			// 
			this.btnDeleteStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDeleteStudent.Location = new System.Drawing.Point(687, 371);
			this.btnDeleteStudent.Name = "btnDeleteStudent";
			this.btnDeleteStudent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnDeleteStudent.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteStudent.TabIndex = 5;
			this.btnDeleteStudent.Text = "Delete";
			this.btnDeleteStudent.UseVisualStyleBackColor = true;
			this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView dgvStudents;
		private System.Windows.Forms.ComboBox cbGroups;
		private System.Windows.Forms.Button btnAddStudent;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAddTeacher;
		private System.Windows.Forms.DataGridView dgvTeachers;
		private System.Windows.Forms.ComboBox cbSpecialities;
		private System.Windows.Forms.Label labelSpeciality;
		private System.Windows.Forms.Button btnDeleteStudent;
	}
}


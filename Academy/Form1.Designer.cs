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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvStudents = new System.Windows.Forms.DataGridView();
			this.cbGroups = new System.Windows.Forms.ComboBox();
			this.btnAddStudent = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.labelStudentsCount = new System.Windows.Forms.Label();
			this.cbDirections = new System.Windows.Forms.ComboBox();
			this.labelDirection = new System.Windows.Forms.Label();
			this.rtbSearch = new System.Windows.Forms.RichTextBox();
			this.btnDeleteStudent = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.labelTeachersCount = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnDeleteTeacher = new System.Windows.Forms.Button();
			this.btnAddTeacher = new System.Windows.Forms.Button();
			this.dgvTeachers = new System.Windows.Forms.DataGridView();
			this.cbSpecialities = new System.Windows.Forms.ComboBox();
			this.labelSpeciality = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvStudents
			// 
			dataGridViewCellStyle13.NullValue = null;
			this.dgvStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
			this.dgvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvStudents.BackgroundColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle14.NullValue = null;
			dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
			this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle15.NullValue = null;
			dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvStudents.DefaultCellStyle = dataGridViewCellStyle15;
			this.dgvStudents.Location = new System.Drawing.Point(6, 44);
			this.dgvStudents.Name = "dgvStudents";
			this.dgvStudents.ReadOnly = true;
			dataGridViewCellStyle16.Format = "d";
			dataGridViewCellStyle16.NullValue = null;
			this.dgvStudents.RowsDefaultCellStyle = dataGridViewCellStyle16;
			this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvStudents.Size = new System.Drawing.Size(756, 321);
			this.dgvStudents.TabIndex = 1;
			this.dgvStudents.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStudents_CellMouseDoubleClick);
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
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(776, 426);
			this.tabControl1.TabIndex = 4;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.labelStudentsCount);
			this.tabPage1.Controls.Add(this.cbDirections);
			this.tabPage1.Controls.Add(this.labelDirection);
			this.tabPage1.Controls.Add(this.rtbSearch);
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
			this.tabPage1.Text = "Students";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(6, 374);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 16);
			this.label2.TabIndex = 9;
			this.label2.Text = "Students:";
			// 
			// labelStudentsCount
			// 
			this.labelStudentsCount.AutoSize = true;
			this.labelStudentsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelStudentsCount.Location = new System.Drawing.Point(74, 374);
			this.labelStudentsCount.Name = "labelStudentsCount";
			this.labelStudentsCount.Size = new System.Drawing.Size(14, 16);
			this.labelStudentsCount.TabIndex = 9;
			this.labelStudentsCount.Text = "0";
			// 
			// cbDirections
			// 
			this.cbDirections.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbDirections.FormattingEnabled = true;
			this.cbDirections.Location = new System.Drawing.Point(295, 4);
			this.cbDirections.Name = "cbDirections";
			this.cbDirections.Size = new System.Drawing.Size(168, 24);
			this.cbDirections.TabIndex = 8;
			this.cbDirections.SelectedIndexChanged += new System.EventHandler(this.cbDirections_SelectedIndexChanged);
			// 
			// labelDirection
			// 
			this.labelDirection.AutoSize = true;
			this.labelDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelDirection.Location = new System.Drawing.Point(226, 7);
			this.labelDirection.Name = "labelDirection";
			this.labelDirection.Size = new System.Drawing.Size(63, 16);
			this.labelDirection.TabIndex = 7;
			this.labelDirection.Text = "Direction:";
			// 
			// rtbSearch
			// 
			this.rtbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rtbSearch.Location = new System.Drawing.Point(557, 6);
			this.rtbSearch.Name = "rtbSearch";
			this.rtbSearch.Size = new System.Drawing.Size(205, 32);
			this.rtbSearch.TabIndex = 6;
			this.rtbSearch.Text = "";
			this.rtbSearch.TextChanged += new System.EventHandler(this.rtbSearch_TextChanged);
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
			this.tabPage2.Controls.Add(this.labelTeachersCount);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.btnDeleteTeacher);
			this.tabPage2.Controls.Add(this.btnAddTeacher);
			this.tabPage2.Controls.Add(this.dgvTeachers);
			this.tabPage2.Controls.Add(this.cbSpecialities);
			this.tabPage2.Controls.Add(this.labelSpeciality);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(768, 400);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Teachers";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// labelTeachersCount
			// 
			this.labelTeachersCount.AutoSize = true;
			this.labelTeachersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelTeachersCount.Location = new System.Drawing.Point(84, 372);
			this.labelTeachersCount.Name = "labelTeachersCount";
			this.labelTeachersCount.Size = new System.Drawing.Size(14, 16);
			this.labelTeachersCount.TabIndex = 5;
			this.labelTeachersCount.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(10, 372);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "Teachers:";
			// 
			// btnDeleteTeacher
			// 
			this.btnDeleteTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDeleteTeacher.Location = new System.Drawing.Point(687, 371);
			this.btnDeleteTeacher.Name = "btnDeleteTeacher";
			this.btnDeleteTeacher.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteTeacher.TabIndex = 4;
			this.btnDeleteTeacher.Text = "Delete";
			this.btnDeleteTeacher.UseVisualStyleBackColor = true;
			this.btnDeleteTeacher.Click += new System.EventHandler(this.btnDeleteTeacher_Click);
			// 
			// btnAddTeacher
			// 
			this.btnAddTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddTeacher.Location = new System.Drawing.Point(606, 371);
			this.btnAddTeacher.Name = "btnAddTeacher";
			this.btnAddTeacher.Size = new System.Drawing.Size(75, 23);
			this.btnAddTeacher.TabIndex = 3;
			this.btnAddTeacher.Text = "Add";
			this.btnAddTeacher.UseVisualStyleBackColor = true;
			this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
			// 
			// dgvTeachers
			// 
			this.dgvTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvTeachers.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTeachers.Location = new System.Drawing.Point(10, 33);
			this.dgvTeachers.Name = "dgvTeachers";
			this.dgvTeachers.ReadOnly = true;
			this.dgvTeachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.comboBox1);
			this.tabPage3.Controls.Add(this.button1);
			this.tabPage3.Controls.Add(this.dataGridView1);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(768, 400);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Groups";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(6, 90);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(756, 257);
			this.dataGridView1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(687, 371);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(7, 7);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Students";
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
		private System.Windows.Forms.Button btnDeleteTeacher;
		private System.Windows.Forms.RichTextBox rtbSearch;
		private System.Windows.Forms.Label labelDirection;
		private System.Windows.Forms.ComboBox cbDirections;
		private System.Windows.Forms.Label labelStudentsCount;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelTeachersCount;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}


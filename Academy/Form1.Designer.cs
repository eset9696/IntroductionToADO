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
			this.tbAcademy = new System.Windows.Forms.TabControl();
			this.tabPageStudents = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.labelStudentsCount = new System.Windows.Forms.Label();
			this.cbDirections = new System.Windows.Forms.ComboBox();
			this.labelDirection = new System.Windows.Forms.Label();
			this.rtbStudSearch = new System.Windows.Forms.RichTextBox();
			this.btnDeleteStudent = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPageTeachers = new System.Windows.Forms.TabPage();
			this.rtbTeacherSearch = new System.Windows.Forms.RichTextBox();
			this.labelTeachersCount = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnDeleteTeacher = new System.Windows.Forms.Button();
			this.btnAddTeacher = new System.Windows.Forms.Button();
			this.dgvTeachers = new System.Windows.Forms.DataGridView();
			this.cbSpecialities = new System.Windows.Forms.ComboBox();
			this.labelSpeciality = new System.Windows.Forms.Label();
			this.tabPageGroups = new System.Windows.Forms.TabPage();
			this.labelNumOfGroups = new System.Windows.Forms.Label();
			this.labelGroupsCount = new System.Windows.Forms.Label();
			this.cbGroupsDirections = new System.Windows.Forms.ComboBox();
			this.btnAddGroup = new System.Windows.Forms.Button();
			this.dgvGroups = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
			this.tbAcademy.SuspendLayout();
			this.tabPageStudents.SuspendLayout();
			this.tabPageTeachers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
			this.tabPageGroups.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
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
			this.dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
			this.dgvStudents.Location = new System.Drawing.Point(6, 44);
			this.dgvStudents.Name = "dgvStudents";
			this.dgvStudents.ReadOnly = true;
			dataGridViewCellStyle4.Format = "d";
			dataGridViewCellStyle4.NullValue = null;
			this.dgvStudents.RowsDefaultCellStyle = dataGridViewCellStyle4;
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
			// tbAcademy
			// 
			this.tbAcademy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbAcademy.Controls.Add(this.tabPageStudents);
			this.tbAcademy.Controls.Add(this.tabPageTeachers);
			this.tbAcademy.Controls.Add(this.tabPageGroups);
			this.tbAcademy.Location = new System.Drawing.Point(12, 12);
			this.tbAcademy.Name = "tbAcademy";
			this.tbAcademy.SelectedIndex = 0;
			this.tbAcademy.Size = new System.Drawing.Size(776, 426);
			this.tbAcademy.TabIndex = 4;
			// 
			// tabPageStudents
			// 
			this.tabPageStudents.Controls.Add(this.label2);
			this.tabPageStudents.Controls.Add(this.labelStudentsCount);
			this.tabPageStudents.Controls.Add(this.cbDirections);
			this.tabPageStudents.Controls.Add(this.labelDirection);
			this.tabPageStudents.Controls.Add(this.rtbStudSearch);
			this.tabPageStudents.Controls.Add(this.btnDeleteStudent);
			this.tabPageStudents.Controls.Add(this.label1);
			this.tabPageStudents.Controls.Add(this.cbGroups);
			this.tabPageStudents.Controls.Add(this.dgvStudents);
			this.tabPageStudents.Controls.Add(this.btnAddStudent);
			this.tabPageStudents.Location = new System.Drawing.Point(4, 22);
			this.tabPageStudents.Name = "tabPageStudents";
			this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageStudents.Size = new System.Drawing.Size(768, 400);
			this.tabPageStudents.TabIndex = 0;
			this.tabPageStudents.Text = "Students";
			this.tabPageStudents.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
			this.labelStudentsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
			// rtbStudSearch
			// 
			this.rtbStudSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbStudSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rtbStudSearch.Location = new System.Drawing.Point(524, 4);
			this.rtbStudSearch.Name = "rtbStudSearch";
			this.rtbStudSearch.Size = new System.Drawing.Size(238, 24);
			this.rtbStudSearch.TabIndex = 6;
			this.rtbStudSearch.Text = "";
			this.rtbStudSearch.TextChanged += new System.EventHandler(this.rtbSearch_TextChanged);
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
			// tabPageTeachers
			// 
			this.tabPageTeachers.Controls.Add(this.rtbTeacherSearch);
			this.tabPageTeachers.Controls.Add(this.labelTeachersCount);
			this.tabPageTeachers.Controls.Add(this.label3);
			this.tabPageTeachers.Controls.Add(this.btnDeleteTeacher);
			this.tabPageTeachers.Controls.Add(this.btnAddTeacher);
			this.tabPageTeachers.Controls.Add(this.dgvTeachers);
			this.tabPageTeachers.Controls.Add(this.cbSpecialities);
			this.tabPageTeachers.Controls.Add(this.labelSpeciality);
			this.tabPageTeachers.Location = new System.Drawing.Point(4, 22);
			this.tabPageTeachers.Name = "tabPageTeachers";
			this.tabPageTeachers.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageTeachers.Size = new System.Drawing.Size(768, 400);
			this.tabPageTeachers.TabIndex = 1;
			this.tabPageTeachers.Text = "Teachers";
			this.tabPageTeachers.UseVisualStyleBackColor = true;
			// 
			// rtbTeacherSearch
			// 
			this.rtbTeacherSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rtbTeacherSearch.Location = new System.Drawing.Point(550, 6);
			this.rtbTeacherSearch.Name = "rtbTeacherSearch";
			this.rtbTeacherSearch.Size = new System.Drawing.Size(205, 21);
			this.rtbTeacherSearch.TabIndex = 6;
			this.rtbTeacherSearch.Text = "";
			this.rtbTeacherSearch.TextChanged += new System.EventHandler(this.rtbTeacherSearch_TextChanged);
			// 
			// labelTeachersCount
			// 
			this.labelTeachersCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
			this.dgvTeachers.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
			// tabPageGroups
			// 
			this.tabPageGroups.Controls.Add(this.labelNumOfGroups);
			this.tabPageGroups.Controls.Add(this.labelGroupsCount);
			this.tabPageGroups.Controls.Add(this.cbGroupsDirections);
			this.tabPageGroups.Controls.Add(this.btnAddGroup);
			this.tabPageGroups.Controls.Add(this.dgvGroups);
			this.tabPageGroups.Location = new System.Drawing.Point(4, 22);
			this.tabPageGroups.Name = "tabPageGroups";
			this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageGroups.Size = new System.Drawing.Size(768, 400);
			this.tabPageGroups.TabIndex = 2;
			this.tabPageGroups.Text = "Groups";
			this.tabPageGroups.UseVisualStyleBackColor = true;
			// 
			// labelNumOfGroups
			// 
			this.labelNumOfGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelNumOfGroups.AutoSize = true;
			this.labelNumOfGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelNumOfGroups.Location = new System.Drawing.Point(6, 374);
			this.labelNumOfGroups.Name = "labelNumOfGroups";
			this.labelNumOfGroups.Size = new System.Drawing.Size(57, 16);
			this.labelNumOfGroups.TabIndex = 3;
			this.labelNumOfGroups.Text = "Groups: ";
			// 
			// labelGroupsCount
			// 
			this.labelGroupsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelGroupsCount.AutoSize = true;
			this.labelGroupsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelGroupsCount.Location = new System.Drawing.Point(69, 374);
			this.labelGroupsCount.Name = "labelGroupsCount";
			this.labelGroupsCount.Size = new System.Drawing.Size(14, 16);
			this.labelGroupsCount.TabIndex = 3;
			this.labelGroupsCount.Text = "0";
			// 
			// cbGroupsDirections
			// 
			this.cbGroupsDirections.FormattingEnabled = true;
			this.cbGroupsDirections.Location = new System.Drawing.Point(7, 7);
			this.cbGroupsDirections.Name = "cbGroupsDirections";
			this.cbGroupsDirections.Size = new System.Drawing.Size(335, 21);
			this.cbGroupsDirections.TabIndex = 2;
			this.cbGroupsDirections.SelectedIndexChanged += new System.EventHandler(this.cbGroupsDirections_SelectedIndexChanged);
			// 
			// btnAddGroup
			// 
			this.btnAddGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddGroup.Location = new System.Drawing.Point(687, 371);
			this.btnAddGroup.Name = "btnAddGroup";
			this.btnAddGroup.Size = new System.Drawing.Size(75, 23);
			this.btnAddGroup.TabIndex = 1;
			this.btnAddGroup.Text = "Add";
			this.btnAddGroup.UseVisualStyleBackColor = true;
			this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
			// 
			// dgvGroups
			// 
			this.dgvGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvGroups.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgvGroups.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvGroups.Location = new System.Drawing.Point(6, 34);
			this.dgvGroups.Name = "dgvGroups";
			this.dgvGroups.Size = new System.Drawing.Size(756, 331);
			this.dgvGroups.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tbAcademy);
			this.Name = "Form1";
			this.Text = "Main data";
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
			this.tbAcademy.ResumeLayout(false);
			this.tabPageStudents.ResumeLayout(false);
			this.tabPageStudents.PerformLayout();
			this.tabPageTeachers.ResumeLayout(false);
			this.tabPageTeachers.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
			this.tabPageGroups.ResumeLayout(false);
			this.tabPageGroups.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView dgvStudents;
		private System.Windows.Forms.ComboBox cbGroups;
		private System.Windows.Forms.Button btnAddStudent;
		private System.Windows.Forms.TabControl tbAcademy;
		private System.Windows.Forms.TabPage tabPageStudents;
		private System.Windows.Forms.TabPage tabPageTeachers;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAddTeacher;
		private System.Windows.Forms.DataGridView dgvTeachers;
		private System.Windows.Forms.ComboBox cbSpecialities;
		private System.Windows.Forms.Label labelSpeciality;
		private System.Windows.Forms.Button btnDeleteStudent;
		private System.Windows.Forms.Button btnDeleteTeacher;
		private System.Windows.Forms.RichTextBox rtbStudSearch;
		private System.Windows.Forms.Label labelDirection;
		private System.Windows.Forms.ComboBox cbDirections;
		private System.Windows.Forms.Label labelStudentsCount;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelTeachersCount;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TabPage tabPageGroups;
		private System.Windows.Forms.ComboBox cbGroupsDirections;
		private System.Windows.Forms.Button btnAddGroup;
		private System.Windows.Forms.DataGridView dgvGroups;
		private System.Windows.Forms.RichTextBox rtbTeacherSearch;
		private System.Windows.Forms.Label labelGroupsCount;
		private System.Windows.Forms.Label labelNumOfGroups;
	}
}


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
			this.labelStudName = new System.Windows.Forms.Label();
			this.pbAvatarStudent = new System.Windows.Forms.PictureBox();
			this.labelBirthDate = new System.Windows.Forms.Label();
			this.labelGroup = new System.Windows.Forms.Label();
			this.labelAttend = new System.Windows.Forms.Label();
			this.labelAVGGrade = new System.Windows.Forms.Label();
			this.btnSetStudentAvatar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbAvatarStudent)).BeginInit();
			this.SuspendLayout();
			// 
			// labelStudName
			// 
			this.labelStudName.AutoSize = true;
			this.labelStudName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelStudName.Location = new System.Drawing.Point(140, 12);
			this.labelStudName.Name = "labelStudName";
			this.labelStudName.Size = new System.Drawing.Size(262, 20);
			this.labelStudName.TabIndex = 0;
			this.labelStudName.Text = "last name,  first name,  middle name";
			// 
			// pbAvatarStudent
			// 
			this.pbAvatarStudent.Location = new System.Drawing.Point(12, 12);
			this.pbAvatarStudent.Name = "pbAvatarStudent";
			this.pbAvatarStudent.Size = new System.Drawing.Size(105, 99);
			this.pbAvatarStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbAvatarStudent.TabIndex = 1;
			this.pbAvatarStudent.TabStop = false;
			// 
			// labelBirthDate
			// 
			this.labelBirthDate.AutoSize = true;
			this.labelBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelBirthDate.Location = new System.Drawing.Point(140, 49);
			this.labelBirthDate.Name = "labelBirthDate";
			this.labelBirthDate.Size = new System.Drawing.Size(86, 20);
			this.labelBirthDate.TabIndex = 2;
			this.labelBirthDate.Text = "Birth date: ";
			// 
			// labelGroup
			// 
			this.labelGroup.AutoSize = true;
			this.labelGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelGroup.Location = new System.Drawing.Point(305, 49);
			this.labelGroup.Name = "labelGroup";
			this.labelGroup.Size = new System.Drawing.Size(62, 20);
			this.labelGroup.TabIndex = 2;
			this.labelGroup.Text = "Group: ";
			// 
			// labelAttend
			// 
			this.labelAttend.AutoSize = true;
			this.labelAttend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelAttend.Location = new System.Drawing.Point(140, 91);
			this.labelAttend.Name = "labelAttend";
			this.labelAttend.Size = new System.Drawing.Size(96, 20);
			this.labelAttend.TabIndex = 3;
			this.labelAttend.Text = "Attendance:";
			// 
			// labelAVGGrade
			// 
			this.labelAVGGrade.AutoSize = true;
			this.labelAVGGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelAVGGrade.Location = new System.Drawing.Point(305, 91);
			this.labelAVGGrade.Name = "labelAVGGrade";
			this.labelAVGGrade.Size = new System.Drawing.Size(97, 20);
			this.labelAVGGrade.TabIndex = 3;
			this.labelAVGGrade.Text = "AVG grade: ";
			// 
			// btnSetStudentAvatar
			// 
			this.btnSetStudentAvatar.Location = new System.Drawing.Point(30, 117);
			this.btnSetStudentAvatar.Name = "btnSetStudentAvatar";
			this.btnSetStudentAvatar.Size = new System.Drawing.Size(75, 23);
			this.btnSetStudentAvatar.TabIndex = 4;
			this.btnSetStudentAvatar.Text = "Change";
			this.btnSetStudentAvatar.UseVisualStyleBackColor = true;
			this.btnSetStudentAvatar.Click += new System.EventHandler(this.btnSetStudentAvatar_Click);
			// 
			// StudentInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(550, 173);
			this.Controls.Add(this.btnSetStudentAvatar);
			this.Controls.Add(this.labelAVGGrade);
			this.Controls.Add(this.labelAttend);
			this.Controls.Add(this.labelGroup);
			this.Controls.Add(this.labelBirthDate);
			this.Controls.Add(this.pbAvatarStudent);
			this.Controls.Add(this.labelStudName);
			this.Name = "StudentInfo";
			this.Text = "Student info";
			((System.ComponentModel.ISupportInitialize)(this.pbAvatarStudent)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelStudName;
		private System.Windows.Forms.PictureBox pbAvatarStudent;
		private System.Windows.Forms.Label labelBirthDate;
		private System.Windows.Forms.Label labelGroup;
		private System.Windows.Forms.Label labelAttend;
		private System.Windows.Forms.Label labelAVGGrade;
		private System.Windows.Forms.Button btnSetStudentAvatar;
	}
}
﻿namespace Academy
{
	partial class AddStudent
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
			this.rbLastName = new System.Windows.Forms.RichTextBox();
			this.rb_FirstName = new System.Windows.Forms.RichTextBox();
			this.rbMiddleName = new System.Windows.Forms.RichTextBox();
			this.cbGroups = new System.Windows.Forms.ComboBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCLose = new System.Windows.Forms.Button();
			this.labelLastName = new System.Windows.Forms.Label();
			this.labelFirstName = new System.Windows.Forms.Label();
			this.labelGroup = new System.Windows.Forms.Label();
			this.labelMiddleName = new System.Windows.Forms.Label();
			this.labelBithDate = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// rbLastName
			// 
			this.rbLastName.Location = new System.Drawing.Point(12, 41);
			this.rbLastName.Name = "rbLastName";
			this.rbLastName.Size = new System.Drawing.Size(264, 27);
			this.rbLastName.TabIndex = 0;
			this.rbLastName.Text = "";
			// 
			// rb_FirstName
			// 
			this.rb_FirstName.Location = new System.Drawing.Point(282, 41);
			this.rb_FirstName.Name = "rb_FirstName";
			this.rb_FirstName.Size = new System.Drawing.Size(264, 27);
			this.rb_FirstName.TabIndex = 0;
			this.rb_FirstName.Text = "";
			// 
			// rbMiddleName
			// 
			this.rbMiddleName.Location = new System.Drawing.Point(12, 98);
			this.rbMiddleName.Name = "rbMiddleName";
			this.rbMiddleName.Size = new System.Drawing.Size(264, 27);
			this.rbMiddleName.TabIndex = 0;
			this.rbMiddleName.Text = "";
			// 
			// cbGroups
			// 
			this.cbGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbGroups.FormattingEnabled = true;
			this.cbGroups.Location = new System.Drawing.Point(552, 41);
			this.cbGroups.Name = "cbGroups";
			this.cbGroups.Size = new System.Drawing.Size(127, 21);
			this.cbGroups.TabIndex = 1;
			// 
			// dtpBirthDate
			// 
			this.dtpBirthDate.Location = new System.Drawing.Point(286, 105);
			this.dtpBirthDate.Name = "dtpBirthDate";
			this.dtpBirthDate.Size = new System.Drawing.Size(264, 20);
			this.dtpBirthDate.TabIndex = 2;
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOk.Location = new System.Drawing.Point(523, 415);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 3;
			this.btnOk.Text = "Ok";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCLose
			// 
			this.btnCLose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCLose.Location = new System.Drawing.Point(604, 415);
			this.btnCLose.Name = "btnCLose";
			this.btnCLose.Size = new System.Drawing.Size(75, 23);
			this.btnCLose.TabIndex = 4;
			this.btnCLose.Text = "Close";
			this.btnCLose.UseVisualStyleBackColor = true;
			// 
			// labelLastName
			// 
			this.labelLastName.AutoSize = true;
			this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelLastName.Location = new System.Drawing.Point(12, 14);
			this.labelLastName.Name = "labelLastName";
			this.labelLastName.Size = new System.Drawing.Size(96, 24);
			this.labelLastName.TabIndex = 5;
			this.labelLastName.Text = "Last name";
			// 
			// labelFirstName
			// 
			this.labelFirstName.AutoSize = true;
			this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelFirstName.Location = new System.Drawing.Point(278, 14);
			this.labelFirstName.Name = "labelFirstName";
			this.labelFirstName.Size = new System.Drawing.Size(98, 24);
			this.labelFirstName.TabIndex = 5;
			this.labelFirstName.Text = "First name";
			// 
			// labelGroup
			// 
			this.labelGroup.AutoSize = true;
			this.labelGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelGroup.Location = new System.Drawing.Point(548, 9);
			this.labelGroup.Name = "labelGroup";
			this.labelGroup.Size = new System.Drawing.Size(63, 24);
			this.labelGroup.TabIndex = 5;
			this.labelGroup.Text = "Group";
			this.labelGroup.Click += new System.EventHandler(this.labelFirstName_Click);
			// 
			// labelMiddleName
			// 
			this.labelMiddleName.AutoSize = true;
			this.labelMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelMiddleName.Location = new System.Drawing.Point(12, 71);
			this.labelMiddleName.Name = "labelMiddleName";
			this.labelMiddleName.Size = new System.Drawing.Size(125, 24);
			this.labelMiddleName.TabIndex = 5;
			this.labelMiddleName.Text = "middle name:";
			// 
			// labelBithDate
			// 
			this.labelBithDate.AutoSize = true;
			this.labelBithDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelBithDate.Location = new System.Drawing.Point(282, 71);
			this.labelBithDate.Name = "labelBithDate";
			this.labelBithDate.Size = new System.Drawing.Size(88, 24);
			this.labelBithDate.TabIndex = 5;
			this.labelBithDate.Text = "Birth date";
			// 
			// AddStudent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(691, 457);
			this.Controls.Add(this.labelGroup);
			this.Controls.Add(this.labelFirstName);
			this.Controls.Add(this.labelBithDate);
			this.Controls.Add(this.labelMiddleName);
			this.Controls.Add(this.labelLastName);
			this.Controls.Add(this.btnCLose);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.dtpBirthDate);
			this.Controls.Add(this.cbGroups);
			this.Controls.Add(this.rbMiddleName);
			this.Controls.Add(this.rb_FirstName);
			this.Controls.Add(this.rbLastName);
			this.Name = "AddStudent";
			this.Text = "AddStudent";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox rbLastName;
		private System.Windows.Forms.RichTextBox rb_FirstName;
		private System.Windows.Forms.RichTextBox rbMiddleName;
		private System.Windows.Forms.ComboBox cbGroups;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.DateTimePicker dtpBirthDate;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCLose;
		private System.Windows.Forms.Label labelLastName;
		private System.Windows.Forms.Label labelFirstName;
		private System.Windows.Forms.Label labelGroup;
		private System.Windows.Forms.Label labelMiddleName;
		private System.Windows.Forms.Label labelBithDate;
	}
}
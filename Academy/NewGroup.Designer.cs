namespace Academy
{
	partial class NewGroup
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
			this.cbGroupDirection = new System.Windows.Forms.ComboBox();
			this.cbGroupLearningForm = new System.Windows.Forms.ComboBox();
			this.cbGroupLearningTime = new System.Windows.Forms.ComboBox();
			this.rtbNewGroupName = new System.Windows.Forms.RichTextBox();
			this.chlbDaysOfWeek = new System.Windows.Forms.CheckedListBox();
			this.btnNewGroupClose = new System.Windows.Forms.Button();
			this.btnNewGroupOk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cbGroupDirection
			// 
			this.cbGroupDirection.FormattingEnabled = true;
			this.cbGroupDirection.Location = new System.Drawing.Point(13, 13);
			this.cbGroupDirection.Name = "cbGroupDirection";
			this.cbGroupDirection.Size = new System.Drawing.Size(389, 21);
			this.cbGroupDirection.TabIndex = 0;
			this.cbGroupDirection.Text = "Direction";
			// 
			// cbGroupLearningForm
			// 
			this.cbGroupLearningForm.FormattingEnabled = true;
			this.cbGroupLearningForm.Location = new System.Drawing.Point(13, 40);
			this.cbGroupLearningForm.Name = "cbGroupLearningForm";
			this.cbGroupLearningForm.Size = new System.Drawing.Size(389, 21);
			this.cbGroupLearningForm.TabIndex = 0;
			this.cbGroupLearningForm.Text = "Learning form";
			// 
			// cbGroupLearningTime
			// 
			this.cbGroupLearningTime.FormattingEnabled = true;
			this.cbGroupLearningTime.Location = new System.Drawing.Point(12, 67);
			this.cbGroupLearningTime.Name = "cbGroupLearningTime";
			this.cbGroupLearningTime.Size = new System.Drawing.Size(389, 21);
			this.cbGroupLearningTime.TabIndex = 0;
			this.cbGroupLearningTime.Text = "Learning time";
			// 
			// rtbNewGroupName
			// 
			this.rtbNewGroupName.Location = new System.Drawing.Point(12, 94);
			this.rtbNewGroupName.Name = "rtbNewGroupName";
			this.rtbNewGroupName.Size = new System.Drawing.Size(388, 26);
			this.rtbNewGroupName.TabIndex = 1;
			this.rtbNewGroupName.Text = "";
			// 
			// chlbDaysOfWeek
			// 
			this.chlbDaysOfWeek.CheckOnClick = true;
			this.chlbDaysOfWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.chlbDaysOfWeek.FormattingEnabled = true;
			this.chlbDaysOfWeek.Location = new System.Drawing.Point(408, 12);
			this.chlbDaysOfWeek.Name = "chlbDaysOfWeek";
			this.chlbDaysOfWeek.Size = new System.Drawing.Size(144, 106);
			this.chlbDaysOfWeek.TabIndex = 3;
			this.chlbDaysOfWeek.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chlbDaysOfWeek_ItemCheck);
			// 
			// btnNewGroupClose
			// 
			this.btnNewGroupClose.Location = new System.Drawing.Point(483, 144);
			this.btnNewGroupClose.Name = "btnNewGroupClose";
			this.btnNewGroupClose.Size = new System.Drawing.Size(75, 23);
			this.btnNewGroupClose.TabIndex = 4;
			this.btnNewGroupClose.Text = "Cancel";
			this.btnNewGroupClose.UseVisualStyleBackColor = true;
			this.btnNewGroupClose.Click += new System.EventHandler(this.btnNewGroupClose_Click);
			// 
			// btnNewGroupOk
			// 
			this.btnNewGroupOk.Location = new System.Drawing.Point(402, 144);
			this.btnNewGroupOk.Name = "btnNewGroupOk";
			this.btnNewGroupOk.Size = new System.Drawing.Size(75, 23);
			this.btnNewGroupOk.TabIndex = 4;
			this.btnNewGroupOk.Text = "Ok";
			this.btnNewGroupOk.UseVisualStyleBackColor = true;
			this.btnNewGroupOk.Click += new System.EventHandler(this.btnNewGroupOk_Click);
			// 
			// NewGroup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(570, 179);
			this.Controls.Add(this.btnNewGroupOk);
			this.Controls.Add(this.btnNewGroupClose);
			this.Controls.Add(this.chlbDaysOfWeek);
			this.Controls.Add(this.rtbNewGroupName);
			this.Controls.Add(this.cbGroupLearningTime);
			this.Controls.Add(this.cbGroupLearningForm);
			this.Controls.Add(this.cbGroupDirection);
			this.Name = "NewGroup";
			this.Text = "New group";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox cbGroupDirection;
		private System.Windows.Forms.ComboBox cbGroupLearningForm;
		private System.Windows.Forms.ComboBox cbGroupLearningTime;
		private System.Windows.Forms.RichTextBox rtbNewGroupName;
		private System.Windows.Forms.CheckedListBox chlbDaysOfWeek;
		private System.Windows.Forms.Button btnNewGroupClose;
		private System.Windows.Forms.Button btnNewGroupOk;
	}
}
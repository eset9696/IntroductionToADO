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
			this.dgwTables = new System.Windows.Forms.DataGridView();
			this.cbGroups = new System.Windows.Forms.ComboBox();
			this.btnAddStudent = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgwTables)).BeginInit();
			this.SuspendLayout();
			// 
			// dgwTables
			// 
			this.dgwTables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgwTables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgwTables.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgwTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwTables.Location = new System.Drawing.Point(12, 68);
			this.dgwTables.Name = "dgwTables";
			this.dgwTables.Size = new System.Drawing.Size(776, 370);
			this.dgwTables.TabIndex = 1;
			// 
			// cbGroups
			// 
			this.cbGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbGroups.FormattingEnabled = true;
			this.cbGroups.Location = new System.Drawing.Point(12, 41);
			this.cbGroups.Name = "cbGroups";
			this.cbGroups.Size = new System.Drawing.Size(127, 21);
			this.cbGroups.TabIndex = 2;
			this.cbGroups.SelectedIndexChanged += new System.EventHandler(this.cbGroups_SelectedIndexChanged);
			// 
			// btnAddStudent
			// 
			this.btnAddStudent.Location = new System.Drawing.Point(160, 41);
			this.btnAddStudent.Name = "btnAddStudent";
			this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
			this.btnAddStudent.TabIndex = 3;
			this.btnAddStudent.Text = "Add Student";
			this.btnAddStudent.UseVisualStyleBackColor = true;
			this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnAddStudent);
			this.Controls.Add(this.cbGroups);
			this.Controls.Add(this.dgwTables);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dgwTables)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView dgwTables;
		private System.Windows.Forms.ComboBox cbGroups;
		private System.Windows.Forms.Button btnAddStudent;
	}
}


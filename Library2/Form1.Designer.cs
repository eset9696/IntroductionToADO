namespace Library2
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
			this.btnExecute = new System.Windows.Forms.Button();
			this.dgvResults = new System.Windows.Forms.DataGridView();
			this.rtbQuery = new System.Windows.Forms.RichTextBox();
			this.cbTables = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
			this.SuspendLayout();
			// 
			// btnExecute
			// 
			this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExecute.Location = new System.Drawing.Point(713, 12);
			this.btnExecute.Name = "btnExecute";
			this.btnExecute.Size = new System.Drawing.Size(75, 23);
			this.btnExecute.TabIndex = 1;
			this.btnExecute.Text = "Execute";
			this.btnExecute.UseVisualStyleBackColor = true;
			this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
			// 
			// dgvResults
			// 
			this.dgvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvResults.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgvResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvResults.Location = new System.Drawing.Point(12, 68);
			this.dgvResults.Name = "dgvResults";
			this.dgvResults.Size = new System.Drawing.Size(776, 370);
			this.dgvResults.TabIndex = 2;
			// 
			// rtbQuery
			// 
			this.rtbQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbQuery.Location = new System.Drawing.Point(12, 12);
			this.rtbQuery.Multiline = false;
			this.rtbQuery.Name = "rtbQuery";
			this.rtbQuery.Size = new System.Drawing.Size(695, 22);
			this.rtbQuery.TabIndex = 3;
			this.rtbQuery.Text = "";
			// 
			// cbTables
			// 
			this.cbTables.FormattingEnabled = true;
			this.cbTables.Location = new System.Drawing.Point(13, 41);
			this.cbTables.Name = "cbTables";
			this.cbTables.Size = new System.Drawing.Size(775, 21);
			this.cbTables.TabIndex = 4;
			this.cbTables.SelectedIndexChanged += new System.EventHandler(this.cbTables_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cbTables);
			this.Controls.Add(this.rtbQuery);
			this.Controls.Add(this.dgvResults);
			this.Controls.Add(this.btnExecute);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnExecute;
		private System.Windows.Forms.DataGridView dgvResults;
		private System.Windows.Forms.RichTextBox rtbQuery;
		private System.Windows.Forms.ComboBox cbTables;
	}
}


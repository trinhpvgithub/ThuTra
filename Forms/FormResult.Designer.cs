namespace DATN.Forms
{
	partial class FormResult
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
			this.dgv_result = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_ExportExcel = new System.Windows.Forms.Button();
			this.btn_end = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv_result
			// 
			this.dgv_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
			this.dgv_result.Dock = System.Windows.Forms.DockStyle.Top;
			this.dgv_result.Location = new System.Drawing.Point(0, 0);
			this.dgv_result.Name = "dgv_result";
			this.dgv_result.Size = new System.Drawing.Size(584, 288);
			this.dgv_result.TabIndex = 0;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "ID";
			this.Column1.Name = "Column1";
			this.Column1.Width = 20;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Name";
			this.Column2.Name = "Column2";
			this.Column2.Width = 50;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "As";
			this.Column3.Name = "Column3";
			// 
			// btn_ExportExcel
			// 
			this.btn_ExportExcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_ExportExcel.Location = new System.Drawing.Point(354, 294);
			this.btn_ExportExcel.Name = "btn_ExportExcel";
			this.btn_ExportExcel.Size = new System.Drawing.Size(106, 32);
			this.btn_ExportExcel.TabIndex = 1;
			this.btn_ExportExcel.Text = "Excel";
			this.btn_ExportExcel.UseVisualStyleBackColor = true;
			// 
			// btn_end
			// 
			this.btn_end.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_end.Location = new System.Drawing.Point(466, 294);
			this.btn_end.Name = "btn_end";
			this.btn_end.Size = new System.Drawing.Size(106, 32);
			this.btn_end.TabIndex = 1;
			this.btn_end.Text = "End";
			this.btn_end.UseVisualStyleBackColor = true;
			// 
			// FormResult
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 338);
			this.Controls.Add(this.btn_end);
			this.Controls.Add(this.btn_ExportExcel);
			this.Controls.Add(this.dgv_result);
			this.Name = "FormResult";
			this.Text = "FormResult";
			((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgv_result;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.Button btn_ExportExcel;
		private System.Windows.Forms.Button btn_end;
	}
}
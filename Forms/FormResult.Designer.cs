﻿namespace DATN.Forms
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
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_ExportExcel = new System.Windows.Forms.Button();
			this.btn_end = new System.Windows.Forms.Button();
			this.btn_Tinh = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_a = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_hf = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv_result
			// 
			this.dgv_result.AllowUserToAddRows = false;
			this.dgv_result.AllowUserToDeleteRows = false;
			this.dgv_result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.dgv_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
			this.dgv_result.Location = new System.Drawing.Point(0, 46);
			this.dgv_result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dgv_result.Name = "dgv_result";
			this.dgv_result.ReadOnly = true;
			this.dgv_result.RowHeadersWidth = 51;
			this.dgv_result.Size = new System.Drawing.Size(779, 309);
			this.dgv_result.TabIndex = 0;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "ID";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 20;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Name";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 50;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "AsA";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 125;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "AsB";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 125;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "AsC";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 125;
			// 
			// btn_ExportExcel
			// 
			this.btn_ExportExcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_ExportExcel.Location = new System.Drawing.Point(472, 362);
			this.btn_ExportExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btn_ExportExcel.Name = "btn_ExportExcel";
			this.btn_ExportExcel.Size = new System.Drawing.Size(141, 39);
			this.btn_ExportExcel.TabIndex = 1;
			this.btn_ExportExcel.Text = "Excel";
			this.btn_ExportExcel.UseVisualStyleBackColor = true;
			// 
			// btn_end
			// 
			this.btn_end.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_end.Location = new System.Drawing.Point(621, 362);
			this.btn_end.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btn_end.Name = "btn_end";
			this.btn_end.Size = new System.Drawing.Size(141, 39);
			this.btn_end.TabIndex = 1;
			this.btn_end.Text = "End";
			this.btn_end.UseVisualStyleBackColor = true;
			// 
			// btn_Tinh
			// 
			this.btn_Tinh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_Tinh.Location = new System.Drawing.Point(323, 362);
			this.btn_Tinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btn_Tinh.Name = "btn_Tinh";
			this.btn_Tinh.Size = new System.Drawing.Size(141, 39);
			this.btn_Tinh.TabIndex = 1;
			this.btn_Tinh.Text = "Tính";
			this.btn_Tinh.UseVisualStyleBackColor = true;
			this.btn_Tinh.Click += new System.EventHandler(this.btn_Tinh_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 16);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Lớp bảo vệ";
			// 
			// txt_a
			// 
			this.txt_a.Location = new System.Drawing.Point(107, 12);
			this.txt_a.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txt_a.Name = "txt_a";
			this.txt_a.Size = new System.Drawing.Size(172, 22);
			this.txt_a.TabIndex = 3;
			this.txt_a.Text = "30";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(288, 16);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "mm";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(440, 16);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Chiều dày sàn";
			// 
			// txt_hf
			// 
			this.txt_hf.Location = new System.Drawing.Point(547, 12);
			this.txt_hf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txt_hf.Name = "txt_hf";
			this.txt_hf.Size = new System.Drawing.Size(172, 22);
			this.txt_hf.TabIndex = 3;
			this.txt_hf.Text = "200";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(728, 16);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(30, 17);
			this.label4.TabIndex = 4;
			this.label4.Text = "mm";
			// 
			// FormResult
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(779, 416);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_hf);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_a);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_end);
			this.Controls.Add(this.btn_Tinh);
			this.Controls.Add(this.btn_ExportExcel);
			this.Controls.Add(this.dgv_result);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FormResult";
			this.Text = "FormResult";
			((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgv_result;
		private System.Windows.Forms.Button btn_ExportExcel;
		private System.Windows.Forms.Button btn_end;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.Button btn_Tinh;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_a;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_hf;
		private System.Windows.Forms.Label label4;
	}
}
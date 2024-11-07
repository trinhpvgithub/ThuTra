namespace DATN.Forms
{
	partial class FormFrame
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
			this.dgv_frames = new System.Windows.Forms.DataGridView();
			this.dgv_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_Mmax = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_Qmax = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_path = new System.Windows.Forms.TextBox();
			this.btn_openpath = new System.Windows.Forms.Button();
			this.btn_loaddata = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_path1 = new System.Windows.Forms.TextBox();
			this.btn_path = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgv_frames)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv_frames
			// 
			this.dgv_frames.AllowUserToAddRows = false;
			this.dgv_frames.AllowUserToDeleteRows = false;
			this.dgv_frames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgv_frames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_frames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_id,
            this.dgv_name,
            this.dgv_Mmax,
            this.dgv_Qmax,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
			this.dgv_frames.Location = new System.Drawing.Point(15, 78);
			this.dgv_frames.Name = "dgv_frames";
			this.dgv_frames.ReadOnly = true;
			this.dgv_frames.RowHeadersWidth = 51;
			this.dgv_frames.Size = new System.Drawing.Size(557, 248);
			this.dgv_frames.TabIndex = 3;
			// 
			// dgv_id
			// 
			this.dgv_id.HeaderText = "ID";
			this.dgv_id.MinimumWidth = 6;
			this.dgv_id.Name = "dgv_id";
			this.dgv_id.ReadOnly = true;
			this.dgv_id.Width = 30;
			// 
			// dgv_name
			// 
			this.dgv_name.HeaderText = "Name";
			this.dgv_name.MinimumWidth = 6;
			this.dgv_name.Name = "dgv_name";
			this.dgv_name.ReadOnly = true;
			this.dgv_name.Width = 50;
			// 
			// dgv_Mmax
			// 
			this.dgv_Mmax.HeaderText = "Mmax(A)";
			this.dgv_Mmax.MinimumWidth = 6;
			this.dgv_Mmax.Name = "dgv_Mmax";
			this.dgv_Mmax.ReadOnly = true;
			this.dgv_Mmax.Width = 60;
			// 
			// dgv_Qmax
			// 
			this.dgv_Qmax.HeaderText = "Qmax(A)";
			this.dgv_Qmax.MinimumWidth = 6;
			this.dgv_Qmax.Name = "dgv_Qmax";
			this.dgv_Qmax.ReadOnly = true;
			this.dgv_Qmax.Width = 60;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Mmax(B)";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 60;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Qmax(B)";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 60;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Mmax(C)";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 60;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Qmax(C)";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 60;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "File Path";
			// 
			// txt_path
			// 
			this.txt_path.Enabled = false;
			this.txt_path.Location = new System.Drawing.Point(66, 6);
			this.txt_path.Name = "txt_path";
			this.txt_path.Size = new System.Drawing.Size(309, 20);
			this.txt_path.TabIndex = 1;
			// 
			// btn_openpath
			// 
			this.btn_openpath.Location = new System.Drawing.Point(381, 6);
			this.btn_openpath.Name = "btn_openpath";
			this.btn_openpath.Size = new System.Drawing.Size(31, 20);
			this.btn_openpath.TabIndex = 2;
			this.btn_openpath.Text = "...";
			this.btn_openpath.UseVisualStyleBackColor = true;
			this.btn_openpath.Click += new System.EventHandler(this.btn_openpath_Click);
			// 
			// btn_loaddata
			// 
			this.btn_loaddata.Location = new System.Drawing.Point(418, 6);
			this.btn_loaddata.Name = "btn_loaddata";
			this.btn_loaddata.Size = new System.Drawing.Size(154, 54);
			this.btn_loaddata.TabIndex = 2;
			this.btn_loaddata.Text = "OK";
			this.btn_loaddata.UseVisualStyleBackColor = true;
			this.btn_loaddata.Click += new System.EventHandler(this.btn_loaddata_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "File Path";
			// 
			// txt_path1
			// 
			this.txt_path1.Enabled = false;
			this.txt_path1.Location = new System.Drawing.Point(66, 40);
			this.txt_path1.Name = "txt_path1";
			this.txt_path1.Size = new System.Drawing.Size(309, 20);
			this.txt_path1.TabIndex = 1;
			// 
			// btn_path
			// 
			this.btn_path.Location = new System.Drawing.Point(381, 40);
			this.btn_path.Name = "btn_path";
			this.btn_path.Size = new System.Drawing.Size(31, 20);
			this.btn_path.TabIndex = 2;
			this.btn_path.Text = "...";
			this.btn_path.UseVisualStyleBackColor = true;
			this.btn_path.Click += new System.EventHandler(this.btn_path_Click);
			// 
			// FormFrame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 338);
			this.Controls.Add(this.dgv_frames);
			this.Controls.Add(this.btn_loaddata);
			this.Controls.Add(this.btn_path);
			this.Controls.Add(this.btn_openpath);
			this.Controls.Add(this.txt_path1);
			this.Controls.Add(this.txt_path);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormFrame";
			this.Text = "FormFrame";
			((System.ComponentModel.ISupportInitialize)(this.dgv_frames)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DataGridView dgv_frames;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_path;
		private System.Windows.Forms.Button btn_openpath;
		private System.Windows.Forms.Button btn_loaddata;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_id;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_name;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Mmax;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Qmax;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_path1;
		private System.Windows.Forms.Button btn_path;
	}
}
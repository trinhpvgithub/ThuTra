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
			this.dgv_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_Mmax = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_Nmax = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_Qmax = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_framenext = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_path = new System.Windows.Forms.TextBox();
			this.btn_openpath = new System.Windows.Forms.Button();
			this.btn_loaddata = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgv_frames)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv_frames
			// 
			this.dgv_frames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.dgv_frames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_frames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_id,
            this.dgv_name,
            this.dgv_size,
            this.dgv_Mmax,
            this.dgv_Nmax,
            this.dgv_Qmax});
			this.dgv_frames.Location = new System.Drawing.Point(15, 32);
			this.dgv_frames.Name = "dgv_frames";
			this.dgv_frames.Size = new System.Drawing.Size(557, 248);
			this.dgv_frames.TabIndex = 3;
			// 
			// dgv_id
			// 
			this.dgv_id.HeaderText = "ID";
			this.dgv_id.Name = "dgv_id";
			this.dgv_id.Width = 20;
			// 
			// dgv_name
			// 
			this.dgv_name.HeaderText = "Name";
			this.dgv_name.Name = "dgv_name";
			this.dgv_name.Width = 50;
			// 
			// dgv_size
			// 
			this.dgv_size.HeaderText = "Size";
			this.dgv_size.Name = "dgv_size";
			this.dgv_size.Width = 60;
			// 
			// dgv_Mmax
			// 
			this.dgv_Mmax.HeaderText = "Mmax";
			this.dgv_Mmax.Name = "dgv_Mmax";
			this.dgv_Mmax.Width = 40;
			// 
			// dgv_Nmax
			// 
			this.dgv_Nmax.HeaderText = "Nmax";
			this.dgv_Nmax.Name = "dgv_Nmax";
			this.dgv_Nmax.Width = 40;
			// 
			// dgv_Qmax
			// 
			this.dgv_Qmax.HeaderText = "Qmax";
			this.dgv_Qmax.Name = "dgv_Qmax";
			this.dgv_Qmax.Width = 40;
			// 
			// btn_framenext
			// 
			this.btn_framenext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_framenext.Location = new System.Drawing.Point(457, 286);
			this.btn_framenext.Name = "btn_framenext";
			this.btn_framenext.Size = new System.Drawing.Size(115, 40);
			this.btn_framenext.TabIndex = 4;
			this.btn_framenext.Text = "Next";
			this.btn_framenext.UseVisualStyleBackColor = true;
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
			// 
			// btn_loaddata
			// 
			this.btn_loaddata.Location = new System.Drawing.Point(418, 6);
			this.btn_loaddata.Name = "btn_loaddata";
			this.btn_loaddata.Size = new System.Drawing.Size(31, 20);
			this.btn_loaddata.TabIndex = 2;
			this.btn_loaddata.Text = "OK";
			this.btn_loaddata.UseVisualStyleBackColor = true;
			// 
			// FormFrame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 338);
			this.Controls.Add(this.btn_framenext);
			this.Controls.Add(this.dgv_frames);
			this.Controls.Add(this.btn_loaddata);
			this.Controls.Add(this.btn_openpath);
			this.Controls.Add(this.txt_path);
			this.Controls.Add(this.label1);
			this.Name = "FormFrame";
			this.Text = "FormFrame";
			((System.ComponentModel.ISupportInitialize)(this.dgv_frames)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DataGridView dgv_frames;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_id;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_name;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_size;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Mmax;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Nmax;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Qmax;
		private System.Windows.Forms.Button btn_framenext;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_path;
		private System.Windows.Forms.Button btn_openpath;
		private System.Windows.Forms.Button btn_loaddata;
	}
}
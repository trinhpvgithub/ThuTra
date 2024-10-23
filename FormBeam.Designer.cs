namespace DATN
{
	partial class frm_Beam
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
			this.metroListView1 = new MetroFramework.Controls.MetroListView();
			this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Mmax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Nmax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Qmax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// metroListView1
			// 
			this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Name,
            this.Size,
            this.Mmax,
            this.Nmax,
            this.Qmax});
			this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.metroListView1.FullRowSelect = true;
			this.metroListView1.Location = new System.Drawing.Point(179, 57);
			this.metroListView1.Name = "metroListView1";
			this.metroListView1.OwnerDraw = true;
			this.metroListView1.Size = new System.Drawing.Size(540, 209);
			this.metroListView1.TabIndex = 0;
			this.metroListView1.UseCompatibleStateImageBehavior = false;
			this.metroListView1.UseSelectable = true;
			// 
			// frm_Beam
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.metroListView1);
			this.Text = "FormBeam";
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroListView metroListView1;
		private System.Windows.Forms.ColumnHeader ID;
		private System.Windows.Forms.ColumnHeader Name;
		private System.Windows.Forms.ColumnHeader Size;
		private System.Windows.Forms.ColumnHeader Mmax;
		private System.Windows.Forms.ColumnHeader Nmax;
		private System.Windows.Forms.ColumnHeader Qmax;
	}
}
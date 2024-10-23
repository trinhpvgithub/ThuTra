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
			this.pn_Menu = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// pn_Menu
			// 
			this.pn_Menu.Dock = System.Windows.Forms.DockStyle.Left;
			this.pn_Menu.Location = new System.Drawing.Point(0, 0);
			this.pn_Menu.Name = "pn_Menu";
			this.pn_Menu.Size = new System.Drawing.Size(200, 450);
			this.pn_Menu.TabIndex = 0;
			// 
			// frm_Beam
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pn_Menu);
			this.Name = "frm_Beam";
			this.Text = "FormBeam";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pn_Menu;
	}
}
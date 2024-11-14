
namespace DATN.Forms
{
	partial class FormBanVe
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBanVe));
			this.axVDPro1 = new AxVDProLib5.AxVDPro();
			this.label33 = new System.Windows.Forms.Label();
			this.cbb_dam = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.axVDPro1)).BeginInit();
			this.SuspendLayout();
			// 
			// axVDPro1
			// 
			this.axVDPro1.Dock = System.Windows.Forms.DockStyle.Left;
			this.axVDPro1.Enabled = true;
			this.axVDPro1.Location = new System.Drawing.Point(0, 0);
			this.axVDPro1.Name = "axVDPro1";
			this.axVDPro1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVDPro1.OcxState")));
			this.axVDPro1.Size = new System.Drawing.Size(452, 416);
			this.axVDPro1.TabIndex = 0;
			// 
			// label33
			// 
			this.label33.AutoSize = true;
			this.label33.Location = new System.Drawing.Point(608, 18);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(41, 17);
			this.label33.TabIndex = 4;
			this.label33.Text = "Dầm:";
			// 
			// cbb_dam
			// 
			this.cbb_dam.FormattingEnabled = true;
			this.cbb_dam.Location = new System.Drawing.Point(611, 47);
			this.cbb_dam.Name = "cbb_dam";
			this.cbb_dam.Size = new System.Drawing.Size(144, 24);
			this.cbb_dam.TabIndex = 3;
			this.cbb_dam.SelectedIndexChanged += new System.EventHandler(this.cbb_dam_SelectedIndexChanged);
			// 
			// FormBanVe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(779, 416);
			this.Controls.Add(this.label33);
			this.Controls.Add(this.cbb_dam);
			this.Controls.Add(this.axVDPro1);
			this.Name = "FormBanVe";
			this.Text = "FormBanVe";
			this.Load += new System.EventHandler(this.FormBanVe_Load);
			((System.ComponentModel.ISupportInitialize)(this.axVDPro1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private AxVDProLib5.AxVDPro axVDPro1;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.ComboBox cbb_dam;
	}
}
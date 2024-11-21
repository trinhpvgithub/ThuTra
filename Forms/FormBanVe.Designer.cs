
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
			this.btn_xuat = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btn_All = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.axVDPro1)).BeginInit();
			this.SuspendLayout();
			// 
			// axVDPro1
			// 
			this.axVDPro1.Dock = System.Windows.Forms.DockStyle.Left;
			this.axVDPro1.Enabled = true;
			this.axVDPro1.Location = new System.Drawing.Point(0, 0);
			this.axVDPro1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.axVDPro1.Name = "axVDPro1";
			this.axVDPro1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVDPro1.OcxState")));
			this.axVDPro1.Size = new System.Drawing.Size(452, 338);
			this.axVDPro1.TabIndex = 0;
			// 
			// label33
			// 
			this.label33.AutoSize = true;
			this.label33.Location = new System.Drawing.Point(456, 15);
			this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(32, 13);
			this.label33.TabIndex = 4;
			this.label33.Text = "Dầm:";
			// 
			// cbb_dam
			// 
			this.cbb_dam.FormattingEnabled = true;
			this.cbb_dam.Location = new System.Drawing.Point(458, 38);
			this.cbb_dam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cbb_dam.Name = "cbb_dam";
			this.cbb_dam.Size = new System.Drawing.Size(109, 21);
			this.cbb_dam.TabIndex = 3;
			this.cbb_dam.SelectedIndexChanged += new System.EventHandler(this.cbb_dam_SelectedIndexChanged);
			// 
			// btn_xuat
			// 
			this.btn_xuat.Location = new System.Drawing.Point(459, 170);
			this.btn_xuat.Name = "btn_xuat";
			this.btn_xuat.Size = new System.Drawing.Size(108, 33);
			this.btn_xuat.TabIndex = 5;
			this.btn_xuat.Text = "Xuất Cad";
			this.btn_xuat.UseVisualStyleBackColor = true;
			this.btn_xuat.Click += new System.EventHandler(this.btn_xuat_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(459, 237);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(108, 33);
			this.button1.TabIndex = 5;
			this.button1.Text = "Đóng chương trình";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btn_All
			// 
			this.btn_All.Location = new System.Drawing.Point(459, 106);
			this.btn_All.Name = "btn_All";
			this.btn_All.Size = new System.Drawing.Size(108, 33);
			this.btn_All.TabIndex = 5;
			this.btn_All.Text = "Vẽ Tất Cả";
			this.btn_All.UseVisualStyleBackColor = true;
			this.btn_All.Click += new System.EventHandler(this.btn_All_Click);
			// 
			// FormBanVe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 338);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btn_All);
			this.Controls.Add(this.btn_xuat);
			this.Controls.Add(this.label33);
			this.Controls.Add(this.cbb_dam);
			this.Controls.Add(this.axVDPro1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
		private System.Windows.Forms.Button btn_xuat;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btn_All;
	}
}
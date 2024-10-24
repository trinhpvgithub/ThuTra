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
			this.panelMenu = new System.Windows.Forms.Panel();
			this.panelLogo = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panelTitleBar = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panelDesktopPane = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.btn_material = new System.Windows.Forms.Button();
			this.btn_importbeam = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panelMenu.SuspendLayout();
			this.panelLogo.SuspendLayout();
			this.panelTitleBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMenu
			// 
			this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.panelMenu.Controls.Add(this.pictureBox2);
			this.panelMenu.Controls.Add(this.button4);
			this.panelMenu.Controls.Add(this.button3);
			this.panelMenu.Controls.Add(this.btn_material);
			this.panelMenu.Controls.Add(this.btn_importbeam);
			this.panelMenu.Controls.Add(this.panelLogo);
			this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMenu.Location = new System.Drawing.Point(0, 0);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(200, 450);
			this.panelMenu.TabIndex = 0;
			// 
			// panelLogo
			// 
			this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
			this.panelLogo.Controls.Add(this.pictureBox1);
			this.panelLogo.Controls.Add(this.label1);
			this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelLogo.Location = new System.Drawing.Point(0, 0);
			this.panelLogo.Name = "panelLogo";
			this.panelLogo.Size = new System.Drawing.Size(200, 73);
			this.panelLogo.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.OliveDrab;
			this.label1.Location = new System.Drawing.Point(76, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 29);
			this.label1.TabIndex = 1;
			this.label1.Text = "Thu Trà";
			// 
			// panelTitleBar
			// 
			this.panelTitleBar.Controls.Add(this.label3);
			this.panelTitleBar.Controls.Add(this.label2);
			this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitleBar.Location = new System.Drawing.Point(200, 0);
			this.panelTitleBar.Name = "panelTitleBar";
			this.panelTitleBar.Size = new System.Drawing.Size(600, 73);
			this.panelTitleBar.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(17, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(580, 24);
			this.label3.TabIndex = 1;
			this.label3.Text = "TÍNH TOÁN DẦM THEO TIÊU CHUẨN VIỆT NAM(1995-2023)";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(140, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(341, 37);
			this.label2.TabIndex = 0;
			this.label2.Text = "ĐỒ ÁN TỐT NGHIỆP";
			// 
			// panelDesktopPane
			// 
			this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelDesktopPane.Location = new System.Drawing.Point(200, 73);
			this.panelDesktopPane.Name = "panelDesktopPane";
			this.panelDesktopPane.Size = new System.Drawing.Size(600, 377);
			this.panelDesktopPane.TabIndex = 2;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pictureBox2.Image = global::DATN.Properties.Resources.ThuTra;
			this.pictureBox2.Location = new System.Drawing.Point(0, 332);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(200, 118);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			// 
			// button4
			// 
			this.button4.Dock = System.Windows.Forms.DockStyle.Top;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.ForeColor = System.Drawing.Color.White;
			this.button4.Image = global::DATN.Properties.Resources.info;
			this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.Location = new System.Drawing.Point(0, 253);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(200, 60);
			this.button4.TabIndex = 4;
			this.button4.Text = "Infomation";
			this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.Dock = System.Windows.Forms.DockStyle.Top;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Image = global::DATN.Properties.Resources.Result;
			this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.Location = new System.Drawing.Point(0, 193);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(200, 60);
			this.button3.TabIndex = 3;
			this.button3.Text = "Result";
			this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// btn_material
			// 
			this.btn_material.Dock = System.Windows.Forms.DockStyle.Top;
			this.btn_material.FlatAppearance.BorderSize = 0;
			this.btn_material.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_material.ForeColor = System.Drawing.Color.White;
			this.btn_material.Image = global::DATN.Properties.Resources.Material;
			this.btn_material.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_material.Location = new System.Drawing.Point(0, 133);
			this.btn_material.Name = "btn_material";
			this.btn_material.Size = new System.Drawing.Size(200, 60);
			this.btn_material.TabIndex = 2;
			this.btn_material.Text = "Setting Material";
			this.btn_material.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_material.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_material.UseVisualStyleBackColor = true;
			this.btn_material.Click += new System.EventHandler(this.btn_material_Click);
			// 
			// btn_importbeam
			// 
			this.btn_importbeam.Dock = System.Windows.Forms.DockStyle.Top;
			this.btn_importbeam.FlatAppearance.BorderSize = 0;
			this.btn_importbeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_importbeam.ForeColor = System.Drawing.Color.White;
			this.btn_importbeam.Image = global::DATN.Properties.Resources.steel_beam;
			this.btn_importbeam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_importbeam.Location = new System.Drawing.Point(0, 73);
			this.btn_importbeam.Name = "btn_importbeam";
			this.btn_importbeam.Size = new System.Drawing.Size(200, 60);
			this.btn_importbeam.TabIndex = 1;
			this.btn_importbeam.Text = "Import Beams";
			this.btn_importbeam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_importbeam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_importbeam.UseVisualStyleBackColor = true;
			this.btn_importbeam.Click += new System.EventHandler(this.btn_importbeam_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox1.Image = global::DATN.Properties.Resources._1200px_LOGO_DHXD;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(70, 73);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// frm_Beam
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(92)))), ((int)(((byte)(168)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panelDesktopPane);
			this.Controls.Add(this.panelTitleBar);
			this.Controls.Add(this.panelMenu);
			this.Name = "frm_Beam";
			this.Text = "FormBeam";
			this.panelMenu.ResumeLayout(false);
			this.panelLogo.ResumeLayout(false);
			this.panelLogo.PerformLayout();
			this.panelTitleBar.ResumeLayout(false);
			this.panelTitleBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMenu;
		private System.Windows.Forms.Panel panelLogo;
		private System.Windows.Forms.Panel panelTitleBar;
		private System.Windows.Forms.Button btn_importbeam;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button btn_material;
		private System.Windows.Forms.Panel panelDesktopPane;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
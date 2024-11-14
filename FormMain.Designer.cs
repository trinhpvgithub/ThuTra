namespace DATN
{
	partial class FormMain
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_Cancel = new MetroFramework.Controls.MetroButton();
			this.btn_start = new MetroFramework.Controls.MetroButton();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(139, 39);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(537, 42);
			this.label1.TabIndex = 0;
			this.label1.Text = "ĐẠI HỌC XÂY DỰNG HÀ NỘI";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(189, 80);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(448, 31);
			this.label2.TabIndex = 0;
			this.label2.Text = "KHOA CÔNG NGHỆ THÔNG TIN";
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.BackColor = System.Drawing.Color.Transparent;
			this.btn_Cancel.Location = new System.Drawing.Point(704, 470);
			this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(119, 34);
			this.btn_Cancel.TabIndex = 1;
			this.btn_Cancel.Text = "Exit";
			this.btn_Cancel.UseSelectable = true;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// btn_start
			// 
			this.btn_start.BackColor = System.Drawing.Color.Transparent;
			this.btn_start.Location = new System.Drawing.Point(559, 470);
			this.btn_start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btn_start.Name = "btn_start";
			this.btn_start.Size = new System.Drawing.Size(119, 34);
			this.btn_start.TabIndex = 1;
			this.btn_start.Text = "Start";
			this.btn_start.UseSelectable = true;
			this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::DATN.Properties.Resources.background1;
			this.ClientSize = new System.Drawing.Size(839, 519);
			this.Controls.Add(this.btn_start);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormMain";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private MetroFramework.Controls.MetroButton btn_Cancel;
		private MetroFramework.Controls.MetroButton btn_start;
	}
}
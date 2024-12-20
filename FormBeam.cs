﻿using DATN.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATN
{
	public partial class frm_Beam : Form
	{
		//Fields
		private Button currentButton;
		private Random random;
		private int tempIndex;
		private Form activeForm;
		public static FormFrame formFrame {  get; set; }
		public static FormMaterial formMaterial { get; set; }
		public static FormResult formResult { get; set; }
		public static FormInformation formInformation { get; set; }
		public static FormBoTri formBoTri { get; set; }
		public static FormBanVe formBanVe { get; set; }

		//Constructor
		public frm_Beam()
		{
			InitializeComponent();
			random = new Random();
			//btnCloseChildForm.Visible = false;
			this.Text = string.Empty;
			this.ControlBox = false;
			this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
		}
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
		//Methods
		private Color SelectThemeColor()
		{
			int index = random.Next(ThemeColor.ColorList.Count);
			while (tempIndex == index)
			{
				index = random.Next(ThemeColor.ColorList.Count);
			}
			tempIndex = index;
			string color = ThemeColor.ColorList[index];
			return ColorTranslator.FromHtml(color);
		}
		private void ActivateButton(object btnSender)
		{
			if (btnSender != null)
			{
				if (currentButton != (Button)btnSender)
				{
					DisableButton();
					Color color = SelectThemeColor();
					currentButton = (Button)btnSender;
					currentButton.BackColor = color;
					currentButton.ForeColor = Color.White;
					currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
					panelTitleBar.BackColor = color;
					panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
					ThemeColor.PrimaryColor = color;
					ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
					//btnCloseChildForm.Visible = true;
				}
			}
		}
		private void DisableButton()
		{
			foreach (Control previousBtn in panelMenu.Controls)
			{
				if (previousBtn.GetType() == typeof(Button))
				{
					previousBtn.BackColor = Color.FromArgb(51, 51, 76);
					previousBtn.ForeColor = Color.Gainsboro;
					previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				}
			}
		}
		private void OpenChildForm(Form childForm, object btnSender)
		{
			if (activeForm != null)
				activeForm.Hide();
			ActivateButton(btnSender);
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			this.panelDesktopPane.Controls.Add(childForm);
			this.panelDesktopPane.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
			//lblTitle.Text = childForm.Text;
		}

		//private void btnCloseChildForm_Click(object sender, EventArgs e)
		//{
		//	if (activeForm != null)
		//		activeForm.Close();
		//	Reset();
		//}
		private void Reset()
		{
			DisableButton();
			//lblTitle.Text = "HOME";
			panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
			panelLogo.BackColor = Color.FromArgb(39, 39, 58);
			currentButton = null;
			//btnCloseChildForm.Visible = false;
		}
		private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		private void btnClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private void btnMaximize_Click(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Normal)
				this.WindowState = FormWindowState.Maximized;
			else
				this.WindowState = FormWindowState.Normal;
		}
		private void bntMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		
		private void btn_importbeam_Click(object sender, EventArgs e)
		{
			if(formFrame==null)
			{
				formFrame = new FormFrame();
			}	
			OpenChildForm(formFrame, sender);
		}

		private void btn_material_Click(object sender, EventArgs e)
		{
			if(formMaterial ==null)
			{
				formMaterial= new FormMaterial();
			}
			OpenChildForm(formMaterial, sender);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if(formResult==null)
			{
				formResult = new FormResult();
			}
			OpenChildForm(formResult, sender);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (formBoTri == null)
			{
				formBoTri = new FormBoTri();
			}
			OpenChildForm(formBoTri, sender);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (formInformation == null)
			{
				formInformation = new FormInformation();
			}
			OpenChildForm(formInformation, sender);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (formBanVe == null)
			{
				formBanVe = new FormBanVe();
			}
			OpenChildForm(formBanVe, sender);
		}
	}
}

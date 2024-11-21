using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATN
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		public static frm_Beam view;
		private void btn_start_Click(object sender, EventArgs e)
		{
			view = new frm_Beam();
			view.ShowDialog();
			this.Close();
		}
	}
}

using DATN.ClassUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATN.Forms
{
	public partial class FormMaterial : Form
	{
		public FormMaterial()
		{
			InitializeComponent();
		}

		private void cbb_macbtong_SelectedIndexChanged(object sender, EventArgs e)
		{
			var mac=cbb_macbtong.Text;
			var b=new MACBT(mac);
			txt_Rb.Text = b.Rb.ToString();
			txt_Rbt.Text = b.Rbt.ToString();
			txt_Rn.Text = b.E.ToString();
		}
	}
}

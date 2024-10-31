using DATN.ClassUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
			LoadData();
		}

		private void cbb_macbtong_SelectedIndexChanged(object sender, EventArgs e)
		{
			var mac=cbb_macbtong.Text;
			var b=new MACBT(mac);
			txt_Rb.Text = b.Rb.ToString();
			txt_Rbt.Text = b.Rbt.ToString();
			txt_Rn.Text = b.E.ToString();
		}

		private void cbb_chu_SelectedIndexChanged(object sender, EventArgs e)
		{
			var mac=cbb_chu.Text;
			var b=new MACTHEP(mac);
			txt_Rschu.Text=b.Rs.ToString();
			txt_Rscchu.Text = b.Rsc.ToString();
			txt_Rswchu.Text=b.Rsw.ToString();
		}

		private void cbb_dai_SelectedIndexChanged(object sender, EventArgs e)
		{
			var mac = cbb_dai.Text;
			var b = new MACTHEP(mac);
			txt_Rsdai.Text = b.Rs.ToString();
			txt_Rscdai.Text = b.Rsc.ToString();
			txt_Rswdai.Text = b.Rsw.ToString();
		}
		private void LoadData()
		{
			var b = new MACBT("B25");
			txt_Rb.Text = b.Rb.ToString();
			txt_Rbt.Text = b.Rbt.ToString();
			txt_Rn.Text = b.E.ToString();
			var c = new MACTHEP("CB300-V");
			txt_Rschu.Text = c.Rs.ToString();
			txt_Rscchu.Text = c.Rsc.ToString();
			txt_Rswchu.Text = c.Rsw.ToString();

			var d = new MACTHEP("CB240-T");
			txt_Rsdai.Text = d.Rs.ToString();
			txt_Rscdai.Text = d.Rsc.ToString();
			txt_Rswdai.Text = d.Rsw.ToString();
		}
	}
}

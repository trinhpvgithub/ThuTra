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
	public partial class FormBoTri : Form
	{
		public FormBoTri()
		{
			InitializeComponent();
		}

		private void FormBoTri_Load(object sender, EventArgs e)
		{
			var beam=FormResult.Beam;
			foreach (var item in beam)
			{
				dgv_thep.Rows.Add(item);
			}
		}
		public int index_tinh = -1;
		public static List<BeamInfo> beams = FormFrame.BeamList;
		private void btn_kt_Click(object sender, EventArgs e)
		{
			if (index_tinh == -1) return;
			double goiA = Convert.ToDouble(txt_goiA.Text);
			double goiC = Convert.ToDouble(txt_goiC.Text);
			double nhipB = Convert.ToDouble(txt_nhipB.Text);
			double KtA = 0;
			double KtB = 0;
			double KtC = 0;

			KtA += Thep(Chuoi(cbb_t1.Text), Convert.ToDouble(cbb_1.Text));
			if (cb2.Checked == true)
			{
				KtA += Thep(Chuoi(cbb_t2.Text), Convert.ToDouble(cbb_2.Text));
			}
			if (cb3.Checked == true)
			{
				KtA += Thep(Chuoi(cbb_t3.Text), Convert.ToDouble(cbb_3.Text));
			}
			if (cb4.Checked == true)
			{
				KtA += Thep(Chuoi(cbb_t4.Text), Convert.ToDouble(cbb_4.Text));
			}
			if (KtA >= goiA)
			{
				lb_A.Text = "V";
				lb_A.ForeColor = Color.Green;
				lb_C.Text = "V";
				lb_C.ForeColor = Color.Green;
			}
			else
			{
				lb_A.Text = "X";
				lb_A.ForeColor = Color.Red;
				lb_C.Text = "X";
				lb_C.ForeColor = Color.Red;
			}

			KtB += Thep(Chuoi(cbb_t5.Text), Convert.ToDouble(cbb_5.Text));
			if (cb6.Checked == true)
			{
				KtB += Thep(Chuoi(cbb_t6.Text), Convert.ToDouble(cbb_6.Text));
			}
			if (cb7.Checked == true)
			{
				KtB += Thep(Chuoi(cbb_t7.Text), Convert.ToDouble(cbb_7.Text));
			}
			if (cb8.Checked == true)
			{
				KtB += Thep(Chuoi(cbb_t8.Text), Convert.ToDouble(cbb_8.Text));
			}
			if (KtB >= nhipB)
			{
				lb_B.Text = "V";
				lb_B.ForeColor = Color.Green;
			}
			else
			{
				lb_B.Text = "V";
				lb_B.ForeColor = Color.Red;
			}

			txt_KTA.Text = KtA.ToString();
			txt_KTB.Text = KtB.ToString();
			txt_KTC.Text = KtA.ToString();

		}
		private double Chuoi(string a)
		{
			string[] chuoi = a.Split('Ø');
			return Convert.ToDouble(chuoi[1]);
		}
		private double Thep(double thep, double soluong)
		{
			int thep1 = Convert.ToInt32(thep);
			double result = 0;
			switch (thep1)
			{
				case 6:
					result = 28.3 * soluong;
					break;
				case 8:
					result = 50.3 * soluong;
					break;
				case 10:
					result = 78.5 * soluong;
					break;
				case 12:
					result = 113.1 * soluong;
					break;
				case 14:
					result = 153.9 * soluong;
					break;
				case 16:
					result = 201.1 * soluong;
					break;
				case 18:
					result = 254.5 * soluong;
					break;
				case 20:
					result = 314.2 * soluong;
					break;
				case 22:
					result = 380.1 * soluong;
					break;
				case 25:
					result = 490.9 * soluong;
					break;
				case 28:
					result = 615.8 * soluong;
					break;
				case 30:
					result = 707 * soluong;
					break;
				case 32:
					result = 840.3 * soluong;
					break;
				case 36:
					result = 1017.9 * soluong;
					break;
				case 40:
					result = 1256.6 * soluong;
					break;
			}
			return result/100;
		}


		private void dgv_thep_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			index_tinh = e.RowIndex;
			if (index_tinh == -1) return;
			txt_goiA.Text = dgv_thep.Rows[index_tinh].Cells[2].Value.ToString();
			txt_nhipB.Text = dgv_thep.Rows[index_tinh].Cells[3].Value.ToString();
			txt_goiC.Text = dgv_thep.Rows[index_tinh].Cells[4].Value.ToString();
		}

		private void btn_luu_Click(object sender, EventArgs e)
		{
			if (index_tinh != -1)
			{
				beams[index_tinh].thep = true;
				if (cb_1.Checked)
				{
					beams[index_tinh].t1 = cbb_1.Text + cbb_t1.Text;
				}
				else
					beams[index_tinh].t1 = "";
				if (cb2.Checked)
				{
					beams[index_tinh].t2 = cbb_2.Text + cbb_t2.Text;
				}
				else
					beams[index_tinh].t2 = "";
				if (cb3.Checked)
				{
					beams[index_tinh].t3 = cbb_3.Text + cbb_t3.Text;
				}
				else
					beams[index_tinh].t3 = "";
				if (cb4.Checked)
				{
					beams[index_tinh].t4 = cbb_4.Text + cbb_t4.Text;
				}
				else
					beams[index_tinh].t4 = "";
				if (cb5.Checked)
				{
					beams[index_tinh].t5 = cbb_5.Text + cbb_t5.Text;
				}
				else
					beams[index_tinh].t5 = "";
				if (cb6.Checked)
				{
					beams[index_tinh].t6 = cbb_6.Text + cbb_t6.Text;
				}
				else
					beams[index_tinh].t6 = "";
				if (cb7.Checked)
				{
					beams[index_tinh].t7 = cbb_7.Text + cbb_t7.Text;
				}
				else
					beams[index_tinh].t7 = "";
				if (cb8.Checked)
				{
					beams[index_tinh].t8 = cbb_8.Text + cbb_t8.Text;
				}
				else
					beams[index_tinh].t8 = "";
				if (cb9.Checked)
				{
					beams[index_tinh].t9 = cbb_9.Text + cbb_t9.Text;
				}
				else
					beams[index_tinh].t9 = "";
				MessageBox.Show("Dữ liệu thép đã được lưu");
			}
		}
	}
}


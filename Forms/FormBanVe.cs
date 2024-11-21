using AxVDProLib5;
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
	public partial class FormBanVe : Form
	{
		public FormBanVe()
		{
			InitializeComponent();
		}
		public List<BeamInfo> beams = FormBoTri.beams;
		private void Draw(AxVDPro axVDPro1, double x, double y, string text, int j = 0, bool c = false)
		{
			var b = beams.FirstOrDefault(z => z.Name.Equals(cbb_dam.Text));
			if (b == null)
			{
				b = beams.FirstOrDefault(z => z.Name.Equals(cbb_dam.Items[j]));
			}
			var B = b.Width;
			var H = b.Height;
			//mcAA
			axVDPro1.ActiveDocument.Entities.AddPolyLine(new double[,] { { x - 80, y + H - 100, 0 }, { x + 0, y + H - 100, 0 }, { x + 0, y + 0, 0 }, { x + B, y + 0, 0 }, { x + B, y + H - 100, 0 }, { x + B + 80, y + H - 100, 0 } });
			axVDPro1.ActiveDocument.Entities.AddPolyLine(new double[,] { { x - 80, y + H + 20, 0 }, { x - 80, y + H - 40, 0 }, { x - 65, y + H - 50, 0 }, { x - 95, y + H - 50, 0 }, { x - 80, y + H - 60, 0 }, { x - 80, y + H - 120, 0 } });
			axVDPro1.ActiveDocument.Entities.AddPolyLine(new double[,] { { x + B + 80, y + H + 20, 0 }, { x + B + 80, y + H - 40, 0 }, { x + B + 95, y + H - 50, 0 }, { x + B + 65, y + H - 50, 0 }, { x + B + 80, y + H - 60, 0 }, { x + B + 80, y + H - 120, 0 } });
			axVDPro1.ActiveDocument.Entities.AddLine(new double[3] { x - 80, y + H, 0 }, new double[3] { x + B + 80, y + H, 0 });
			axVDPro1.ActiveDocument.Entities.AddRect(new double[3] { x + 30, y + 30, 0 }, B - 60, H - 60);
			axVDPro1.ActiveDocument.Entities.Last.PenColor.ColorIndex = 2;
			//5
			axVDPro1.ActiveDocument.Entities.AddCircle(new double[3] { x + 40, y + 40, 0 }, 10.0);
			axVDPro1.ActiveDocument.Entities.AddCircle(new double[3] { x + B - 40, y + 40, 0 }, 10.0);
			axVDPro1.ActiveDocument.Entities.AddPolyLine(new double[,] { { x + 40, y + 40, 0 }, { x + 40, y - 100, 0 }, { x + 100 + B, y - 100, 0 } });
			axVDPro1.ActiveDocument.Entities.AddLine(new double[3] { x + B - 40, y + 40, 0 }, new double[3] { x + B - 40, y - 100, 0 });
			axVDPro1.ActiveDocument.Entities.AddText(b.t5, new double[3] { x + 40 + B, y - 100, 0 }, 20);
			((VDProLib5.vdText)axVDPro1.ActiveDocument.Entities.Last).PenColor.ColorIndex = 61;
			//2
			if (c == true)
			{
				//6
				if (b.t6 != "")
				{
					var n = Convert.ToDouble(b.t6.Substring(0, 1));
					var distance = (B - 10) / (n + 1);
					for (int i = 1; i <= n; i++)
					{
						axVDPro1.ActiveDocument.Entities.AddCircle(new double[3] { x + distance * i, y + 40, 0 }, 10.0);
						axVDPro1.ActiveDocument.Entities.AddPolyLine(new double[,] { { x + distance * i, y + 40, 0 }, { x + distance * i, y - 40, 0 }, { x + B + 100, y - 40, 0 } });
					}
					axVDPro1.ActiveDocument.Entities.AddText(b.t6, new double[3] { x + B, y - 40, 0 }, 20);
					((VDProLib5.vdText)axVDPro1.ActiveDocument.Entities.Last).PenColor.ColorIndex = 61;

				}
				//7
				if (b.t7 != "")
				{
					axVDPro1.ActiveDocument.Entities.AddCircle(new double[3] { x + 40, y + 70, 0 }, 10.0);
					axVDPro1.ActiveDocument.Entities.AddCircle(new double[3] { x + B - 40, y + 70, 0 }, 10.0);
					axVDPro1.ActiveDocument.Entities.AddPolyLine(new double[,] { { x + 40, y + 70, 0 }, { x + 40, y + 100, 0 }, { x + 100 + B, y + 100, 0 } });
					axVDPro1.ActiveDocument.Entities.AddLine(new double[3] { x + B - 40, y + 70, 0 }, new double[3] { x + B - 40, y + 100, 0 });
					axVDPro1.ActiveDocument.Entities.AddText(b.t7, new double[3] { x + 40 + B, y + 100, 0 }, 20);
					((VDProLib5.vdText)axVDPro1.ActiveDocument.Entities.Last).PenColor.ColorIndex = 61;
				}
				if (b.t8 != "")
				{
					var n = Convert.ToDouble(b.t8.Substring(0, 1));
					var distance = (B - 10) / (n + 1);
					for (int i = 1; i <= n; i++)
					{
						axVDPro1.ActiveDocument.Entities.AddCircle(new double[3] { x + distance * i, y + 70, 0 }, 10.0);
						axVDPro1.ActiveDocument.Entities.AddPolyLine(new double[,] { { x + distance * i, y + 70, 0 }, { x + distance * i, y + 150, 0 }, { x + 100 + B, y + 150, 0 } });
					}
					axVDPro1.ActiveDocument.Entities.AddText(b.t8, new double[3] { x + 40 + B, y + 150, 0 }, 20);
					((VDProLib5.vdText)axVDPro1.ActiveDocument.Entities.Last).PenColor.ColorIndex = 61;
				}
			}
			else
			{
				if (b.t2 != "")
				{
					var n = Convert.ToDouble(b.t2.Substring(0, 1));
					var distance = (B - 10) / (n + 1);
					for (int i = 1; i <= n; i++)
					{
						axVDPro1.ActiveDocument.Entities.AddCircle(new double[3] { x + distance * i, y + H - 40, 0 }, 10.0);
						axVDPro1.ActiveDocument.Entities.AddPolyLine(new double[,] { { x + distance * i, y + H - 40, 0 }, { x + distance * i, y + H + 40, 0 }, { x + B + 100, y + H + 40, 0 } });
					}
					axVDPro1.ActiveDocument.Entities.AddText(b.t2, new double[3] { x + B, y + H + 40, 0 }, 20);
					((VDProLib5.vdText)axVDPro1.ActiveDocument.Entities.Last).PenColor.ColorIndex = 61;
				}
				//3
				if (b.t3 != "")
				{
					axVDPro1.ActiveDocument.Entities.AddCircle(new double[3] { x + 40, y + H - 40 - 30, 0 }, 10.0);
					axVDPro1.ActiveDocument.Entities.AddCircle(new double[3] { x + B - 40, y + H - 40 - 30, 0 }, 10.0);
					axVDPro1.ActiveDocument.Entities.AddPolyLine(new double[,] { { x + 40, y + H - 40 - 30, 0 }, { x + 40, y + H - 200, 0 }, { x + 100 + B, y + H - 200, 0 } });
					axVDPro1.ActiveDocument.Entities.AddLine(new double[3] { x + B - 40, y + H - 40 - 30, 0 }, new double[3] { x + B - 40, y + H - 200, 0 });
					axVDPro1.ActiveDocument.Entities.AddText(b.t3, new double[3] { x + 40 + B, y + H - 200, 0 }, 20);
					((VDProLib5.vdText)axVDPro1.ActiveDocument.Entities.Last).PenColor.ColorIndex = 61;
				}
				//4
				if (b.t4 != "")
				{
					var n = Convert.ToDouble(b.t4.Substring(0, 1));
					var distance = (B - 10) / (n + 1);
					for (int i = 1; i <= n; i++)
					{
						axVDPro1.ActiveDocument.Entities.AddCircle(new double[3] { x + distance * i, y + H - 40 - 30, 0 }, 10.0);
						axVDPro1.ActiveDocument.Entities.AddPolyLine(new double[,] { { x + distance * i, y + H - 40 - 30, 0 }, { x + distance * i, y + H - 150, 0 }, { x + 100 + B, y + H - 150, 0 } });
					}
					axVDPro1.ActiveDocument.Entities.AddText(b.t4, new double[3] { x + 40 + B, y + H - 150, 0 }, 20);
					((VDProLib5.vdText)axVDPro1.ActiveDocument.Entities.Last).PenColor.ColorIndex = 61;
				}
			}
			axVDPro1.ActiveDocument.Entities.AddCircle(new double[3] { x + 40, y + H - 40, 0 }, 10.0);
			axVDPro1.ActiveDocument.Entities.AddCircle(new double[3] { x + B - 40, y + H - 40, 0 }, 10.0);
			axVDPro1.ActiveDocument.Entities.AddPolyLine(new double[,] { { x + 40, y + H - 40, 0 }, { x + 40, y + H + 100, 0 }, { x + 100 + B, y + H + 100, 0 } });
			axVDPro1.ActiveDocument.Entities.AddLine(new double[3] { x + B - 40, y + H - 40, 0 }, new double[3] { x + B - 40, y + H + 100, 0 });
			axVDPro1.ActiveDocument.Entities.AddText(b.t1, new double[3] { x + 40 + B, y + H + 100, 0 }, 20);
			((VDProLib5.vdText)axVDPro1.ActiveDocument.Entities.Last).PenColor.ColorIndex = 61;
			axVDPro1.ActiveDocument.Entities.AddText(text, new double[3] { x + B / 4, y - 200, 0 }, 35);
			((VDProLib5.vdText)axVDPro1.ActiveDocument.Entities.Last).PenColor.ColorIndex = 61;
			axVDPro1.ActiveDocument.Entities.AddLine(new double[3] { x + B - 30, y + H / 2, 0 }, new double[3] { x + B + 100, y + H / 2, 0 });
			axVDPro1.ActiveDocument.Entities.AddText(b.t9, new double[3] { x + 40 + B, y + H / 2, 0 }, 20);
			((VDProLib5.vdText)axVDPro1.ActiveDocument.Entities.Last).PenColor.ColorIndex = 61;

		}

		private void cbb_dam_SelectedIndexChanged(object sender, EventArgs e)
		{
			axVDPro1.CommandAction.Undo("BEGIN");
			axVDPro1.ActiveDocument.Entities.EraseAll();
			var b = beams.FirstOrDefault(x => x.Name.Equals(cbb_dam.Text));
			var B = b.Width;
			var H = b.Height;
			Draw(axVDPro1, 0, 0, "MC A-A");
			Draw(axVDPro1, B * 3, 0, "MC B-B",0, true);
			Draw(axVDPro1, B * 6, 0, "MC C-C");
			axVDPro1.CommandAction.Undo("END");
			axVDPro1.CommandAction.Zoom("W", new double[3] { -300, -300, 0 }, new double[3] { b.Width * 10, b.Height * 2, 0 });
		}

		private void FormBanVe_Load(object sender, EventArgs e)
		{
			foreach (var b in beams)
			{
				if (b.thep)
					cbb_dam.Items.Add(b.Name);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FormMain.view.Close();
		}

		private void btn_xuat_Click(object sender, EventArgs e)
		{
			var save = new SaveFileDialog();
			save.Filter = "dxf|*.dxf";
			if (save.ShowDialog() == DialogResult.OK)
			{
				axVDPro1.ActiveDocument.Save();
				axVDPro1.ActiveDocument.SaveAs(save.FileName, VDProLib5.VdConstFileVer.VdCadVer2004);
			}
		}

		private void btn_All_Click(object sender, EventArgs e)
		{
			axVDPro1.CommandAction.Undo("BEGIN");
			axVDPro1.ActiveDocument.Entities.EraseAll();
			for (int i = 0; i < cbb_dam.Items.Count; i++)
			{
				var b = beams.FirstOrDefault(x => x.Name.Equals(cbb_dam.Items[i]));
				var B = b.Width;
				var H = b.Height;
				if(i==0)
				{
					Draw(axVDPro1, 0, H * i , "MC A-A", i);
					Draw(axVDPro1, B * 3, H * i , "MC B-B", i, true);
					Draw(axVDPro1, B * 6, H * i , "MC C-C", i);
				}	
				else
				{
					Draw(axVDPro1, 0, 1000*i, "MC A-A", i);
					Draw(axVDPro1, B * 3, 1000*i, "MC B-B", i, true);
					Draw(axVDPro1, B * 6, 1000*i, "MC C-C", i);
				}	
			}
			axVDPro1.CommandAction.Undo("END");
			axVDPro1.CommandAction.Zoom("W", new double[3] { -300, -300, 0 }, new double[3] { 500 * 10, 800 * (cbb_dam.Items.Count + 1), 0 });
		}
	}
}

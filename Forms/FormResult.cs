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
	public partial class FormResult : Form
	{
		public FormResult()
		{
			InitializeComponent();
		}
		public static List<string[]>Beam {  get; set; } = new List<string[]>();
		private void btn_Tinh_Click(object sender, EventArgs e)
		{
			var a=Convert.ToDouble(txt_a.Text);
			var hf=Convert.ToDouble(txt_hf.Text);
			var beams = FormFrame.BeamList;
			var BT=FormMaterial.MACBT;
			var THEP=FormMaterial.MACTHEPCHINH;
            foreach (var beam in beams)
            {
				var Result = new FunctionTinh(beam.Height, a, hf, beam.Width, 8, BT.Rb, THEP.Rs, beam.SectionA.M, beam.SectionB.M, beam.SectionC.M);
				string[] beamresult = new string[]
				{
					beam.Story,
					beam.Name,
					Math.Round( Result.AsA,4).ToString(),
					Math.Round( Result.AsB,4).ToString(),
					Math.Round( Result.AsC,4).ToString(),
				};
				dgv_result.Rows.Add(beamresult);
				Beam.Add(beamresult);
			}
        }
	}
}

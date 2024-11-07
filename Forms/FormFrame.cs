using DATN.ClassUtils;
using MiniExcelLibs;
using MiniExcelLibs.OpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATN.Forms
{
	public partial class FormFrame : Form
	{
		public FormFrame()
		{
			InitializeComponent();
		}
		public string Path;
		public string PathTT;
		public static List<BeamInfo> BeamList {  get; set; }= new List<BeamInfo>();
		private void btn_loaddata_Click(object sender, EventArgs e)
		{
			var tt=MiniExcel.Query<Tietdien>(PathTT);
			var data = tt.Where(x => x.LineType.Equals("Beam")).GroupBy(x=>x.Line).ToList();
			var path = Path;
			var config = new OpenXmlConfiguration()
			{
				FillMergedCells = true
			};
			var a = MiniExcel.Query(path, sheetName: "Dam", configuration: config);
			var b = new DataAnalysis(a.ToList());
			var c = b.beamInfos;
			foreach (var item in c)
			{
				string[] row = new string[]
				{   item.Story,
					item.Name,
					item.SectionA.M.ToString(),
					item.SectionA.Q.ToString(),
					item.SectionB.M.ToString(),
					item.SectionB.Q.ToString(),
					item.SectionC.M.ToString(),
					item.SectionC.Q.ToString()
				};
				dgv_frames.Rows.Add(row);
			}
            foreach (var beam in c)
            {
				var TTT = data.FirstOrDefault(x => x.Key.Equals(beam.Name));
				beam.Width = Split(TTT.FirstOrDefault().AnalysisSect, false);
				beam.Height = Split(TTT.FirstOrDefault().AnalysisSect);
				BeamList.Add(beam);
			}
        }

		private void btn_openpath_Click(object sender, EventArgs e)//chọn file để mở
		{
			var openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Excel Files|*.xlsx|All Files|*.*";
			openFileDialog.Multiselect = false; // Đặt thành true để cho phép chọn nhiều tệp
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				// Lấy đường dẫn của tệp được chọn
				Path = openFileDialog.FileName;
			}
			txt_path.Text = Path;
		}
		private double Split(string data,bool c=true)
		{
			double result = 0;
			string[] kq= data.Split('X');
			if(c)
			{
				result = Convert.ToDouble(kq.LastOrDefault()) * 10;
			}
			else
			{
				result = Convert.ToDouble(kq.FirstOrDefault().Substring(1)) * 10;
			}
			return result;
		}

		private void btn_path_Click(object sender, EventArgs e)
		{
			var openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Excel Files|*.xlsx|All Files|*.*";
			openFileDialog.Multiselect = false; // Đặt thành true để cho phép chọn nhiều tệp
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				// Lấy đường dẫn của tệp được chọn
				PathTT = openFileDialog.FileName;
			}
			txt_path1.Text = PathTT;
		}
	}
}

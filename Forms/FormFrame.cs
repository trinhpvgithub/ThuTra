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

		private void btn_loaddata_Click(object sender, EventArgs e)
		{
			var path = @"C:\Users\trinh\OneDrive\Desktop\NoiLuc_Lam_etabs.xlsx";
			var config = new OpenXmlConfiguration()
			{
				FillMergedCells = true
			};
			var a=MiniExcel.Query(path, sheetName: "Dam", configuration: config);
		}
	}
}

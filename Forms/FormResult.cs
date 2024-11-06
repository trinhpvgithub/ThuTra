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

		private void btn_Tinh_Click(object sender, EventArgs e)
		{
			var beams = FormFrame.BeamList;
            foreach (var beam in beams)
            {
                //var Result= new Function()
            }
        }

	}
}

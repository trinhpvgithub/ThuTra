using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN.ClassUtils
{
	public class MACBT
	{
		public double Rb {  get; set; }
		public double Rbt {  get; set; }
		public double E {  get; set; }
		public MACBT(string mac) { Set(mac); }
		private void Set(string mac)
		{
			switch (mac)
			{
				case "B15":
					Rb = 8.5;
					Rbt = 0.75;
					E = 24000;
					break;
				case "B20":
					Rb = 11.5;
					Rbt = 0.9;
					E = 27500;
					break;
				case "B25":
					Rb = 14.5;
					Rbt = 1.05;
					E = 32500;
					break;
				case "B30":
					Rb = 17;
					Rbt = 1.15;
					E = 34500;
					break;
				default:
					break;
			}
		}
	}
	
}

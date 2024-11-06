using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN.ClassUtils
{
	public class Function
	{
		public double L {  get; set; }//chiều dài dầm
		public double h {  get; set; }//chiều cao dầm
		public double a { get; set; }//lớp bảo vệ
		public double b { get; set; }//bề rộng dầm
		public double Rb { get; set; }//cường độ bê tông
		public double Rs { get; set; }//cường độ thep
		public double MA {  get; set; }//momen
		public double MB {  get; set; }//momen
		public double MC {  get; set; }//momen
		public double hf {  get; set; }
		public double bf {  get; set; }
		public double AsA {  get; set; }
		public double AsB {  get; set; }
		public double AsC {  get; set; }
		public Function(double hh, double aa, double bb, double Rbb, double Rss, double MMA,double MMB,double MMC, double hff) 
		{
			h = hh;
			a = aa;
			b = bb;
			Rb=Rbb;
			Rs = Rss;
			MA = MMA;
			MB = MMB;
			MC = MMC;
			hf = hff;
			bf = bf = b + 2 * DoVuonCanh(); ;
			Run();
		}
		private  double DienTichThepTietDienChuNhat(double M)
		{
			double h0 = h - a;

			var am = Math.Abs(M) / (Rb * b * h0 * h0);

			double zeta = (1 + Math.Sqrt(1 - 2 * am)) / 2;

			return Math.Abs(M) / (Rs * zeta * h0);
		}
		private  double DienTichThepTietDienChuT(double M)
		{
			double h0 = h - a;

			var am = (Math.Abs(M) - Rb * (bf - b) * hf * (h0 - 0.5 * hf)) / (Rb * b * h0 * h0);

			double E = TinhHeSo.Esp(am);

			return Rb / Rs * (E * b * h0 + (bf - b) * hf);
		}
		private double DoVuonCanh()
		{
			if (hf >= 0.1 * h)
			{
				double res = L / 6;   //Math.Min(L / 6, Bd / 2);

				return Math.Floor(res / 10) * 10;
			}
			else
			{
				double res = Math.Min(L / 6, 6 * hf);

				return Math.Floor(res / 10) * 10;
			}
		}
		private void Run()
		{
			var M=new List<double>() { MA, MB, MC };
			var As=new List<double>() ;
            foreach (var momen in M)
            {
				if (momen < 0)
				{
					As.Add(DienTichThepTietDienChuNhat(momen));
				}
				else
				{

					if (momen < TinhHeSo.Mf(Rb, bf, hf, h-a))
					{

						As.Add(DienTichThepTietDienChuNhat(momen));
					}
					else
					{
						As.Add(DienTichThepTietDienChuT(momen));
					}
				}
            }
			AsA = As[0];
			AsB = As[1];
			AsC = As[2];
		}
	}
	public class TinhHeSo
	{
		public static double Esp(double am)
		{
			return (1 - Math.Sqrt(1 - 2 * am));
		}

		public static double Mf(double Rb, double bf, double hf, double h0)
		{
			return Rb * bf * hf * (h0 - 0.5 * hf);
		}
	}
}

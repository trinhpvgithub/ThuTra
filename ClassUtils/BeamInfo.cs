using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN.ClassUtils
{
	public class BeamInfo
	{
		public double Width {  get; set; }
		public double Height {  get; set; }
		public string Story { get; set; }
		public string Name { get; set; }

		public Section SectionA { get; set; }
		public Section SectionB { get; set; }
		public Section SectionC { get; set; }
		public BeamInfo(IGrouping<dynamic, dynamic> b)
		{
			Story = Convert.ToString(b.Select(x => x?.E).First());
			Name = Convert.ToString(b.Select(x => x?.F).First());
			var sectionA = b.Where(x =>
			{
				string s = Convert.ToString(x.G);
				return s.Equals("0");
			});
			var sectionB = b.Where(x =>
			{
				string s = Convert.ToString(x.G);
				return s.Equals("0.5L");
			});
			var sectionC = b.Where(x =>
			{
				string s = Convert.ToString(x.G);
				return s.Equals("1L");
			});
			SectionA = new Section(sectionA.ToList());
			SectionB = new Section(sectionB.ToList());
			SectionC = new Section(sectionC.ToList());


		}
	}
}

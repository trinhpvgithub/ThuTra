using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN.ClassUtils
{
	public class DataAnalysis
	{
		public List<BeamInfo> beamInfos { get; set; } = new List<BeamInfo>();
		public DataAnalysis(List<dynamic> data)
		{
			var groupname = data.GroupBy(x => x.E);// group theo giá trị của cột E
			foreach (var group in groupname)
			{
				var name = group.Where(x =>
				{
					var d = $"{x.F}";
					return d.StartsWith("B") && !d.Equals("Bảng 5 - Bảng tổ hợp nội lực dầm");
				})
				.GroupBy(x => x.F).ToList();
				if (name.Count>0)
				{
                    foreach (var item in name)
                    {
						var beam = new BeamInfo(item);
						beamInfos.Add(beam);
                    }
				}
			}
		}
	}
}

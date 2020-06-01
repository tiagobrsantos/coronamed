using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaMed.Model
{
	public class Worker
	{
		public string Name { get; set; }
		public Address Address { get; set; }
		public List<WorkerJobSkill> WorkerJobSkills { get; set; }
	}
}

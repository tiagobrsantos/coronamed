using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaMed.Model
{
	public class JobSkill : Entity
	{
		public string Name { get; set; }
		public List<WorkerJobSkill> WorkerJobSkills { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaMed.Model
{
	public class WorkerJobSkill
	{
		public Worker Worker { get; set; }
		[ForeignKey("Worker")]
		public int WorkerId { get; set; }

		public JobSkill JobSkill { get; set; }
		[ForeignKey("JobSkill")]
		public int JobSkillId { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaMed.Model
{
	public class Worker: Entity
	{
		public Partner Partner { get; set; }
		[ForeignKey("Partner")]
		public int PartnerId { get; set; }
		public Address Address { get; set; }
		public List<WorkerJobSkill> WorkerJobSkills { get; set; }
		public DocumentFile Image { get; set; }
	}
}

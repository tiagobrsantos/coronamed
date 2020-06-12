using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaMed.Model
{
	public class Procedure: Entity
	{
		public string Name { get; set; }
		public string Description { get; set; }
		
		public int Quantity { get; set; }

		public Project Project { get; set; }
		[ForeignKey("Project")]
		public int ProjectId { get; set; }		

		public bool IsComplete { get; set; }		
		public List<ProcedurePartner> ProcedurePartners { get; set; }
	}
}

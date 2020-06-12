using CoronaMed.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaMed.Model
{
	public class ProcedurePartner: Entity
	{
		public Procedure Procedure { get; set; }
		[ForeignKey("Procedure")]
		public int ProcedureId { get; set; }

		public Partner Partner { get; set; }
		[ForeignKey("Partner")]
		public int PartnerId { get; set; }

		public int Quantity { get; set; }

		public EProcedurePartnerStatus ProcedurePartnerStatus { get; set; }

	}
}

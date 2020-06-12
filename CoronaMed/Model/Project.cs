using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaMed.Model
{
	public class Project : Entity
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public Customer Customer { get; set; }
		[ForeignKey("Customer")]
		public int CustomerId { get; set; }
		public DateTime DueDate { get; set; }
		
		public List<DocumentFile> DocumentFiles { get; set; }

	}
}

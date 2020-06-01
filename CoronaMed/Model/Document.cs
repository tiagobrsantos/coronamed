using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaMed.Model
{
	public class Document: Entity
	{
		public string FileName { get; set; }
		[NotMapped]
		public string File { get; set; }

	}
}

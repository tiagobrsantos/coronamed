using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaMed.Model
{
	public class ProjectDocument
	{
		public Project Project { get; set; }
		[ForeignKey("Project")]
		public int ProjectId { get; set; }

		public DocumentFile DocumentFile { get; set; }
		[ForeignKey("DocumentFile")]
		public int DocumentFileId { get; set; }
	}
}

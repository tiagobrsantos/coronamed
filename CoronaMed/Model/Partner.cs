﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaMed.Model
{
	public class Partner : Entity
	{
		public string Name { get; set; }
		public string Description { get; set; }

		public DocumentFile DocumentFile { get; set; }
		[ForeignKey("DocumentFile")]
		public int DocumentFileId { get; set; }
	}
}

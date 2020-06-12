using CoronaMed.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaMed.Model
{
	public class DocumentFile: Entity
	{
		public string FileName { get; set; }
		[NotMapped]
		public string FileBase64 { get; set; }
		public EDocumentType DocumentType { get; set; }
	}
}

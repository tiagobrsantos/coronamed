using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaMed.Model
{
	public class ContactUs : Entity
	{
		public string Email { get; set; }
		public string Phone { get; set; }
		public string Message { get; set; }
		public DateTimeOffset? ReadingDate { get; set; }
		public int WasReplied { get; set; }
	}
}

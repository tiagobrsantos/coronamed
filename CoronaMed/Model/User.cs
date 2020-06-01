using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaMed.Model
{
	public class User: Entity
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string Hash { get; set; }
		public string Salt { get; set; }
		public bool IsAdmin { get; set; }
		public Profile Profile { get; set; }
		[ForeignKey("Profile")]
		public int ProfileId { get; set; }

	}
}

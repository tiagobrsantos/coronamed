﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaMed.Model
{
	public class Entity
	{
		public int Id { get; set; }
		public DateTimeOffset CreationDate { get; set; }
		public bool IsActive { get; set; }

		public Entity()
		{
			IsActive = true;
			CreationDate = DateTime.UtcNow;
		}
	}
}

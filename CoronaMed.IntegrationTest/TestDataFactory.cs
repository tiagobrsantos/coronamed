using CoronaMed.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoronaMed.IntegrationTest
{
	public class TestDataFactory
	{
		public static Partner GetPartner()
		{
			return new Partner { Name = "Partner" };
		}
	}
}

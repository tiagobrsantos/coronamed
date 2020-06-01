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

		public static ContactUs GetContactUs()
		{
			return new ContactUs
			{
				Email = "joao.silva@example.com",
				Message = "xxx"
			};
		}
	}
}

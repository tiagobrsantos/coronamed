using CoronaMed.DataAccess.Context;
using CoronaMed.Model;
using CoronaMed.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaMed.DataAccess
{
	public class ContactUsRepository : Repository<ContactUs>, IContactUsRepository
	{
		public ContactUsRepository(CoronaMedContext coronaMedContext) : base(coronaMedContext)
		{

		}
	}
}

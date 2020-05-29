using CoronaMed.DataAccess.Context;
using CoronaMed.Model;
using CoronaMed.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaMed.DataAccess
{
	public class PartnerRepository : Repository<Partner>, IPartnerRepository
	{
		public PartnerRepository(CoronaMedContext coronaMedContext) : base(coronaMedContext)
		{

		}
	}
}

using CoronaMed.Command;
using CoronaMed.Helper;
using CoronaMed.Model.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaMed.Commands.Handlers.Interface
{
	public interface IPartnerCommandHandler :INotifiable, ICommandHandler<CreatePartnerCommand>, 
		ICommandHandler<UpdatePartnerCommand>, ICommandHandler<DeleteEntityCommand>
	{
	}
}

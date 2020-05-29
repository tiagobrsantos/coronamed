using CoronaMed.Helper;
using CoronaMed.Model;
using CoronaMed.Model.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaMed.Commands
{
	public class UpdatePartnerCommand : Notifiable, ICommand
	{
		public Partner Partner { get; set; }
		public UpdatePartnerCommand(Partner partner)
		{
			Partner = partner;
		}

		public bool Validate()
		{
			AddNotification(Partner == null, "Partner is null");
			AddNotification(Partner.Id <= 0, "Partner Id is invalid");
			AddNotification(string.IsNullOrEmpty(Partner.Name), "Partner Name is required");

			return IsValid;
			
		}
	}
}

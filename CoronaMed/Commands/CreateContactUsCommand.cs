using CoronaMed.Helper;
using CoronaMed.Model;
using CoronaMed.Model.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace CoronaMed.Command
{
	public class CreateContactUsCommand : Notifiable, ICommand
	{

		public ContactUs ContactUs { get; set; }

		public CreateContactUsCommand(ContactUs contactUs)
		{
			ContactUs = contactUs;

		}


		public bool Validate()
		{
			AddNotification(ContactUs == null, "Contact Us is null");
			AddNotification(ContactUs.Id > 0, "Contact Us Id is invalid");
			AddNotification(string.IsNullOrEmpty(ContactUs.Email), "Contact Us email is required");
			AddNotification(string.IsNullOrEmpty(ContactUs.Message), "Contact Us Message is required");

			return IsValid;
		}
	}
}

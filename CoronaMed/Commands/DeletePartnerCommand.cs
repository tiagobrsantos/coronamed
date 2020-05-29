using CoronaMed.Helper;
using CoronaMed.Model.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaMed.Commands
{
	public class DeleteEntityCommand : Notifiable, ICommand
	{
		public int Id { get; set; }

		public DeleteEntityCommand(int id)
		{
			Id = id;
		}

		public bool Validate()
		{
			AddNotification(Id <= 0, "Partner Id is invalid");

			return IsValid;
		}
	}
}

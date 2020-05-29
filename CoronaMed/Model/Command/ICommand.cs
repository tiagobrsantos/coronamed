using CoronaMed.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaMed.Model.Command
{
	public interface ICommand : INotifiable
	{
		
		public bool Validate();
	}
}

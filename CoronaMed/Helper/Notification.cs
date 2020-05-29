using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CoronaMed.Helper
{
	public class Notification
	{
		public string Message { get; set; }
		public HttpStatusCode HttpStatusCode { get; set; }
		
		public Notification(string message)
		{
			Message = message;
			HttpStatusCode = HttpStatusCode.BadRequest; 
		}

		public Notification(string message, HttpStatusCode httpStatusCode)
		{
			Message = message;
			HttpStatusCode = httpStatusCode;
		}
	}
}

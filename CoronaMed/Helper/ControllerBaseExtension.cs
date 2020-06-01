using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CoronaMed.Helper
{
	public static class ControllerBaseExtension 
	{
		public static IActionResult HandleNotification(this ControllerBase controllerBase, INotifiable notifiable, object obj)
		{
			if (notifiable.IsValid)
			{
				return controllerBase.Ok(obj);
			}
			if (notifiable.HasInternalServerError)
			{
				return controllerBase.StatusCode(StatusCodes.Status500InternalServerError, notifiable.GetNotifications());
			}
			return controllerBase.BadRequest(notifiable.GetNotifications());
		}

		public static IActionResult HandleNotification(this ControllerBase controllerBase, INotifiable notifiable)
		{
			if (notifiable.IsValid)
			{
				return controllerBase.Ok();
			}
			if (notifiable.HasInternalServerError)
			{
				return controllerBase.StatusCode(StatusCodes.Status500InternalServerError, notifiable.GetNotifications());
			}
			return controllerBase.BadRequest(notifiable.GetNotifications());
		}
	}
}

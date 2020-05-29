using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CoronaMed.Helper
{
	public class Notifiable : INotifiable
	{
		private readonly List<Notification> notifications;

		public bool IsValid { get { return !notifications.Any(); } }

		public bool HasInternalServerError => notifications.Any(x => x.HttpStatusCode == HttpStatusCode.InternalServerError);

		public Notifiable()
		{
			notifications = new List<Notification>();
		}

		public void AddNotification(List<Notification> notifications)
		{
			this.notifications.AddRange(notifications);
		}

		public void AddNotification(Notification notification)
		{
			notifications.Add(notification);
		}

		public void AddNotification(string message)
		{
			notifications.Add(new Notification(message));
		}

		public void AddNotification(string message, HttpStatusCode httpStatusCode)
		{
			notifications.Add(new Notification(message, httpStatusCode));
		}

		public void AddNotification(bool compare, string message)
		{
			if (compare)
			{
				AddNotification(new Notification(message));
			}
		}

		public void Clear()
		{
			notifications.Clear();
		}

		public List<Notification> GetNotifications()
		{
			return notifications;
		}
	}
}

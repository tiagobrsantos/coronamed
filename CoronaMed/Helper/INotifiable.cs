using System.Collections.Generic;
using System.Net;

namespace CoronaMed.Helper
{
    public interface INotifiable
	{
        bool IsValid { get; }

        void AddNotification(List<Notification> notifications);
        void AddNotification(Notification notification);
        void AddNotification(string message);
        void AddNotification(string message, HttpStatusCode httpStatusCode);
        void Clear();
        bool HasInternalServerError { get; }
        List<Notification> GetNotifications();
    }
}

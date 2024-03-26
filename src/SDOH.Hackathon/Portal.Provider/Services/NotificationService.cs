using Data.Models;

namespace Portal.Provider.Services;


public class NotificationService : PatientRelatedService<Notification>
{
    public NotificationService(IHttpClientFactory clientFactory) : base(clientFactory, "notifications")
    {
    }
}

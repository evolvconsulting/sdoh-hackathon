using Data.Models;

namespace Portal.Provider.Services;


public class NotificationService : BaseService<Notification>
{
    public NotificationService(IHttpClientFactory clientFactory) : base(clientFactory, "notifications")
    {
    }
}

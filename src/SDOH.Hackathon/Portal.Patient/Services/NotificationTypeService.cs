namespace Portal.Patient.Services;

public class NotificationTypeService : BaseService<Data.Models.NotificationType>
{
    public NotificationTypeService(IHttpClientFactory clientFactory) : base(clientFactory, "notification-types") { }
}
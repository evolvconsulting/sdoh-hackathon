
namespace dotnet8.Services;

using Data;
using WebPush;

public sealed class NotificationService
{
    private readonly ScaffoldedContext _context;
    private readonly ILogger<NotificationService> _logger;

    public NotificationService(
        ScaffoldedContext context,
        ILogger<NotificationService> logger
    )
    {
        _context = context;
        _logger = logger;
    }

    public async Task Subscribe(NotificationSubscription subscription)
    {
        // TODO need models. 
    }

    public async Task NotifyUser(string userId, string message)
    {
        // TODO need models to push subscriptions. 
        var pushSubscription = new PushSubscription();
        var webPushClient = new WebPushClient();

        try {
            await webPushClient.SendNotificationAsync(pushSubscription, message);
        } catch(Exception ex) {
            _logger.LogError(ex, "Error occured while attempting to push notification");
        }

    }

}
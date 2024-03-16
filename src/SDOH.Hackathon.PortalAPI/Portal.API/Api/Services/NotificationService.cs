
namespace dotnet8.Services;

using Data;


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

    public Guid Subscribe(NotificationSubscription subscription)
    {
        return Guid.NewGuid();
    }

    public void Notify()
    {

    }

}
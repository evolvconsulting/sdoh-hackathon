using Microsoft.AspNetCore.Mvc;
using Data.Models;

namespace Portal.API.Controllers.NonGeneric
{
    [ApiController]
    [Route("notification-types")]
    public class NotificationTypeController : BaseController<NotificationType>
    {
        public NotificationTypeController(ScaffoldedContext context, IConfiguration configuration) : base(context, configuration) { }
    }
}

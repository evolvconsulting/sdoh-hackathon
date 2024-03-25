using Microsoft.AspNetCore.Mvc;
using Data.Models;

namespace Portal.API.Controllers.NonGeneric
{
    [ApiController]
    [Route("notifications")]
    public class NotificationController : BaseController<Notification>
    {
        public NotificationController(ScaffoldedContext context, IConfiguration configuration) : base(context, configuration) { }
    }
}

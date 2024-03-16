using Microsoft.AspNetCore.Mvc;

namespace SODH.Hackathon.NotificationAPI.Controllers;

[ApiController]
public class NotificationController : ControllerBase
{
    private readonly ILogger<NotificationController> _logger;

    public NotificationController(ILogger<NotificationController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("[controller]")]
    public IActionResult Notification()
    {
        return Ok(true);
    }

}
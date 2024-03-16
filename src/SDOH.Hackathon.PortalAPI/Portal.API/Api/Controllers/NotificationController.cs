using Microsoft.AspNetCore.Mvc;
using dotnet8.Services;

namespace SODH.Hackathon.NotificationAPI.Controllers;


[ApiController]
public class NotificationController : ControllerBase
{
    private readonly NotificationService _notificationService;

    public NotificationController(
        NotificationService notificationService
    )
    {
        _notificationService = notificationService;
    }

    [HttpGet]
    [Route("[controller]")]
    public IActionResult Notification()
    {
        return Ok(true);
    }

    [HttpPut]
    [Route("[controller]/Subscribe")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult Subscribe([FromBody] NotificationSubscription subscription)
    {
        // TODO
        return Ok();
    }

}
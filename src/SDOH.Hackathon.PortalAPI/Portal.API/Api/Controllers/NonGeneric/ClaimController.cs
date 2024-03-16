using Data;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using dotnet8.Interfaces;

namespace dotnet8.Controllers
{
    [ApiController]
    [Route("claims")]
    public class ClaimController : BaseController<Claim>
    {
        public ClaimController(ScaffoldedContext context, IConfiguration configuration) : base(context, configuration) { }
    }
}

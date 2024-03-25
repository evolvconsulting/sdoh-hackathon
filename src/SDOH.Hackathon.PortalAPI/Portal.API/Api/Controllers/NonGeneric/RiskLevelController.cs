using Microsoft.AspNetCore.Mvc;
using Data.Models;

namespace Portal.API.Controllers.NonGeneric
{
    [ApiController]
    [Route("risk-levels")]
    public class RiskLevelController : BaseController<RiskLevel>
    {
        public RiskLevelController(ScaffoldedContext context, IConfiguration configuration) : base(context, configuration) { }
    }
}

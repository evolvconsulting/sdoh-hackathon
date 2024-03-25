using Microsoft.AspNetCore.Mvc;
using Data.Models;

namespace Portal.API.Controllers.NonGeneric
{
    [ApiController]
    [Route("risk-level-interventions")]
    public class RiskLevelInterventionController : BaseController<RiskLevelIntervention>
    {
        public RiskLevelInterventionController(ScaffoldedContext context, IConfiguration configuration) : base(context, configuration) { }
    }
}

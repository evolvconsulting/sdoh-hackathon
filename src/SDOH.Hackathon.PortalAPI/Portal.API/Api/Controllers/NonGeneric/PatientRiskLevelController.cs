using Microsoft.AspNetCore.Mvc;
using Data.Models;

namespace Portal.API.Controllers.NonGeneric
{
    [ApiController]
    [Route("patient-risk-levels")]
    public class PatientRiskLevelController : BaseController<PatientRiskLevel>
    {
        public PatientRiskLevelController(ScaffoldedContext context, IConfiguration configuration) : base(context, configuration) { }
    }
}

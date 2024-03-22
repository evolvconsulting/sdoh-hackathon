using Microsoft.AspNetCore.Mvc;
using Data.Models;

namespace Portal.API.Controllers.NonGeneric
{
    [ApiController]
    [Route("patient-risk-factors")]
    public class PatientRiskFactorController : BaseController<PatientRiskFactor>
    {
        public PatientRiskFactorController(ScaffoldedContext context, IConfiguration configuration) : base(context, configuration) { }
    }
}

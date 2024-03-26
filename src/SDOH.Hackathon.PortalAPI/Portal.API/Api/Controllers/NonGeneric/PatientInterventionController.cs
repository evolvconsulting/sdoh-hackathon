using Microsoft.AspNetCore.Mvc;
using Data.Models;

namespace Portal.API.Controllers.NonGeneric
{
    [ApiController]
    [Route("patient-interventions")]
    public class PatientInterventionController : PatientRelatedController<PatientIntervention>
    {
        public PatientInterventionController(ScaffoldedContext context, IConfiguration configuration) : base(context, configuration) { }
    }
}

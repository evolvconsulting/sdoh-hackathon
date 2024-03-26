using Microsoft.AspNetCore.Mvc;
using Data.Models;

namespace Portal.API.Controllers.NonGeneric
{
    [ApiController]
    [Route("patient-interventions")]
    public class PatientInterventionController : BaseController<PatientIntervention>
    {
        public PatientInterventionController(ScaffoldedContext context, IConfiguration configuration) : base(context, configuration) { }

        [HttpGet]
        [Route("get-by-patient/{patientId}")]
        [ProducesResponseType<object>(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        //[Authorize(Policy="default-api-access")]
        public IActionResult GetByPatient(string patientId)
        {
            var result = _context.Set<PatientIntervention>().Where(x => x.PatientId == patientId).FirstOrDefault();
            return result == null ? NotFound() : Ok(result);
        }
    }
}

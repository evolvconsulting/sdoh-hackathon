using Microsoft.AspNetCore.Mvc;
using Data.Models;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Portal.API.Controllers;

public abstract class PatientRelatedController<T> : BaseController<T>
    where T : class, IIdentified, IPatientRelated
{
    public PatientRelatedController(ScaffoldedContext context, IConfiguration configuration) : base(context, configuration) { }

    [HttpGet]
    [Route("get-by-patient/{patientId}")]
    [ProducesResponseType<object>(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    //[Authorize(Policy="default-api-access")]
    public IActionResult GetByPatient(string patientId)
    {
        var result = _context.Set<T>().Where(x => x.PatientId == patientId);
        return result == null ? NotFound() : Ok(result);
    }
}

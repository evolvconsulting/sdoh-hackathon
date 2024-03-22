using Microsoft.AspNetCore.Mvc;
using Data.Models;

namespace Portal.API.Controllers.NonGeneric
{
    [ApiController]
    [Route("interventions")]
    public class InterventionController : BaseController<Intervention>
    {
        public InterventionController(ScaffoldedContext context, IConfiguration configuration) : base(context, configuration) { }
    }
}

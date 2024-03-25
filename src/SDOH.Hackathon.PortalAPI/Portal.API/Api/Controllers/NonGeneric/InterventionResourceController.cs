using Microsoft.AspNetCore.Mvc;
using Data.Models;

namespace Portal.API.Controllers.NonGeneric
{
    [ApiController]
    [Route("intervention-resources")]
    public class InterventionResourceController : BaseController<InterventionResource>
    {
        public InterventionResourceController(ScaffoldedContext context, IConfiguration configuration) : base(context, configuration) { }
    }
}

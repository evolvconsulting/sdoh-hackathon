using Data;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace dotnet8.Controllers
{
    [ApiController]
    [Route("employees")]
    public class EmployeeController : BaseController<Employee>
    {
        public EmployeeController(Context context, IConfiguration configuration) : base(context, configuration) { }
    }
}

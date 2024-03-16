using Data;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using dotnet8.Interfaces;

namespace dotnet8.Controllers
{
    [ApiController]
    [Route("claimtransactions")]
    public class ClaimTransactionController : BaseController<ClaimTra>
    {
        public ClaimTransactionController(ScaffoldedContext context, IConfiguration configuration) : base(context, configuration) { }
    }
}

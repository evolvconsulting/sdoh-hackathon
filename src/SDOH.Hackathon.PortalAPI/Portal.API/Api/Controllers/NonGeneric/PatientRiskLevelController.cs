﻿using Data;
using dotnet8.Models;
using dotnet8.Interfaces;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;
using Newtonsoft.Json;
using Data.Models;
using Data.Interfaces;
using System.Text;

namespace dotnet8.Controllers
{
    [ApiController]
    [Route("patient-risk-levels")]
    public class PatientRiskLevelController : BaseController<PatientRiskLevel>
    {
        public PatientRiskLevelController(ScaffoldedContext context, IConfiguration configuration) : base(context, configuration) { }
    }
}

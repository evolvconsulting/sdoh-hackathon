using Data.Interfaces;
using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class PatientRiskFactor : IIdentified
{
    public string Id { get; set; } = null!;

    public string PatientId { get; set; } = null!;

    public string RiskFactorId { get; set; } = null!;

    public string Value { get; set; } = null!;
}

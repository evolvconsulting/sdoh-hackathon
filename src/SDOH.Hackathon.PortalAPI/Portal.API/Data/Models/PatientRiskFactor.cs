using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class PatientRiskFactor
{
    public string Id { get; set; } = null!;

    public string PatientRiskFactorId { get; set; } = null!;

    public string PatientId { get; set; } = null!;

    public string Value { get; set; } = null!;
}

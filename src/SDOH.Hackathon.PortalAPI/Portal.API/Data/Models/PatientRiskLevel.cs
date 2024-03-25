using Data.Interfaces;
using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class PatientRiskLevel : IIdentified
{
    public string Id { get; set; } = null!;

    public string PatientId { get; set; } = null!;

    public string RiskLevelId { get; set; } = null!;

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }
}

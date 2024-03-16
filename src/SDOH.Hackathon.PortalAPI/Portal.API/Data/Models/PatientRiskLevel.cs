using System;
using System.Collections.Generic;
using Data.Interfaces;

namespace Data.Models;

public partial class PatientRiskLevel
{
    public string Id { get; set; } = null!;

    public string PatientId { get; set; } = null!;

    public DateOnly FromDate { get; set; }

    public DateOnly ToDate { get; set; }
}

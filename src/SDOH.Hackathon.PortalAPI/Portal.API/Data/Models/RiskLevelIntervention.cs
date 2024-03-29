﻿using Data.Interfaces;

namespace Data.Models;

public partial class RiskLevelIntervention : IIdentified
{
    public string Id { get; set; } = null!;

    public string RiskLevelId { get; set; } = null!;

    public string InterventionId { get; set; } = null!;
}

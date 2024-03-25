using Data.Interfaces;
using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class RiskFactor : IIdentified
{
    public string Id { get; set; } = null!;

    public string RiskFactorGroupId { get; set; } = null!;

    public string? Name { get; set; }
}

using Data.Interfaces;
using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class RiskFactorGroup : IIdentified
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }
}

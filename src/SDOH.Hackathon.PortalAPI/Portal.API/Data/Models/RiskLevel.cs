using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class RiskLevel
{
    public string Id { get; set; } = null!;

    public string RiskLevelId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Severity { get; set; } = null!;
}

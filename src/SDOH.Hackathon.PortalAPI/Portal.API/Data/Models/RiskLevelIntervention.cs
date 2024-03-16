using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class RiskLevelIntervention
{
    public string Id { get; set; } = null!;

    public string RiskLevelInterventionId { get; set; } = null!;

    public string InterventionId { get; set; } = null!;
}

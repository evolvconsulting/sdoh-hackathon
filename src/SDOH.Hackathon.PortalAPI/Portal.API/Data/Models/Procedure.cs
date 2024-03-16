using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class Procedure
{
    public string? StartTime { get; set; }

    public string? StopTime { get; set; }

    public string? Patient { get; set; }

    public string? Encounter { get; set; }

    public long? Code { get; set; }

    public string? Description { get; set; }

    public decimal? BaseCost { get; set; }

    public long? Reasoncode { get; set; }

    public string? Reasondescription { get; set; }
}

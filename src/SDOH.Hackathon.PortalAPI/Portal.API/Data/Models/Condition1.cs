using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class Condition1
{
    public DateOnly? StartTime { get; set; }

    public DateOnly? Stop { get; set; }

    public string? Patient { get; set; }

    public string? Encounter { get; set; }

    public long? Code { get; set; }

    public string? Description { get; set; }
}

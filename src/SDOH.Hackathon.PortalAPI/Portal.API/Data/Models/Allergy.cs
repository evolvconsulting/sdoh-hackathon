using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class Allergy
{
    public DateOnly? StartTime { get; set; }

    public string? Stop { get; set; }

    public string? Patient { get; set; }

    public string? Encounter { get; set; }

    public long? Code { get; set; }

    public string? System { get; set; }

    public string? Description { get; set; }

    public string? Type { get; set; }

    public string? Category { get; set; }

    public long? Reaction1 { get; set; }

    public string? Description1 { get; set; }

    public string? Severity1 { get; set; }

    public long? Reaction2 { get; set; }

    public string? Description2 { get; set; }

    public string? Severity2 { get; set; }
}

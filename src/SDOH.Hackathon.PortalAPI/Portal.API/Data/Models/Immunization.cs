using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class Immunization
{
    public string? Date { get; set; }

    public string? Patient { get; set; }

    public string? Encounter { get; set; }

    public long? Code { get; set; }

    public string? Description { get; set; }

    public decimal? BaseCost { get; set; }
}

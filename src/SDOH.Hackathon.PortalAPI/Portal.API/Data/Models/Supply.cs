using System;
using System.Collections.Generic;
using Data.Interfaces;

namespace Data.Models;

public partial class Supply
{
    public DateOnly? Date { get; set; }

    public string? Patient { get; set; }

    public string? Encounter { get; set; }

    public long? Code { get; set; }

    public string? Description { get; set; }

    public long? Quantity { get; set; }
}

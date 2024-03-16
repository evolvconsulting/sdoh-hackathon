using System;
using System.Collections.Generic;
using Data.Interfaces;

namespace Data.Models;

public partial class Encounter : IIdentified
{
    public string? Id { get; set; }

    public string? StartTime { get; set; }

    public string? StopTime { get; set; }

    public string? Patient { get; set; }

    public string? Organization { get; set; }

    public string? Provider { get; set; }

    public string? Payer { get; set; }

    public string? Encounterclass { get; set; }

    public long? Code { get; set; }

    public string? Description { get; set; }

    public decimal? BaseEncounterCost { get; set; }

    public decimal? TotalClaimCost { get; set; }

    public decimal? PayerCoverage { get; set; }

    public long? Reasoncode { get; set; }

    public string? Reasondescription { get; set; }
}

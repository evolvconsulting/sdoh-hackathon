using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class Payer
{
    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Ownership { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? StateHeadquartered { get; set; }

    public string? Zip { get; set; }

    public string? Phone { get; set; }

    public decimal? AmountCovered { get; set; }

    public decimal? AmountUncovered { get; set; }

    public decimal? Revenue { get; set; }

    public long? CoveredEncounters { get; set; }

    public long? UncoveredEncounters { get; set; }

    public long? CoveredMedications { get; set; }

    public long? UncoveredMedications { get; set; }

    public long? CoveredProcedures { get; set; }

    public long? UncoveredProcedures { get; set; }

    public long? CoveredImmunizations { get; set; }

    public long? UncoveredImmunizations { get; set; }

    public long? UniqueCustomers { get; set; }

    public decimal? QolsAvg { get; set; }

    public long? MemberMonths { get; set; }
}

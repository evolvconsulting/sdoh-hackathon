using System;
using System.Collections.Generic;
using Data.Interfaces;

namespace Data.Models;

public partial class PayerTransaction
{
    public string? Patient { get; set; }

    public string? Memberid { get; set; }

    public string? StartDate { get; set; }

    public string? EndDate { get; set; }

    public string? Payer { get; set; }

    public string? SecondaryPayer { get; set; }

    public string? PlanOwnership { get; set; }

    public string? OwnerName { get; set; }
}

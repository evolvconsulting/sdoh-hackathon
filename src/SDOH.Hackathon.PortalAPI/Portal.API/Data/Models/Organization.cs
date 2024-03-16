using System;
using System.Collections.Generic;
using Data.Interfaces;

namespace Data.Models;

public partial class Organization : IIdentified
{
    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public long? Zip { get; set; }

    public decimal? Lat { get; set; }

    public decimal? Lon { get; set; }

    public string? Phone { get; set; }

    public long? Revenue { get; set; }

    public long? Utilization { get; set; }
}

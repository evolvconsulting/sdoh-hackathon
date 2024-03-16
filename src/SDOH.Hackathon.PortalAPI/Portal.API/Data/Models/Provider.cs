using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class Provider
{
    public string? Id { get; set; }

    public string? Organization { get; set; }

    public string? Name { get; set; }

    public string? Gender { get; set; }

    public string? Speciality { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public long? Zip { get; set; }

    public decimal? Lat { get; set; }

    public decimal? Lon { get; set; }

    public long? Encounters { get; set; }

    public long? Procedures { get; set; }
}

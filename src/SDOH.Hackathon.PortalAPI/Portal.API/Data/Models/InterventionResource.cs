using Data.Interfaces;
using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class InterventionResource : IIdentified
{
    public string Id { get; set; } = null!;

    public string TypeId { get; set; } = null!;

    public string? Url { get; set; }

    public string? Document { get; set; }
}

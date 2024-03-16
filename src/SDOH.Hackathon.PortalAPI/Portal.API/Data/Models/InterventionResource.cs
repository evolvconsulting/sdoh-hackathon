using System;
using System.Collections.Generic;
using Data.Interfaces;

namespace Data.Models;

public partial class InterventionResource : IIdentified
{
    public string Id { get; set; } = null!;

    public string InterventionResourceId { get; set; } = null!;

    public string TypeId { get; set; } = null!;
}

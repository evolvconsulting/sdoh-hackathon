using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class InterventionResource
{
    public string Id { get; set; } = null!;

    public string InterventionResourceId { get; set; } = null!;

    public string TypeId { get; set; } = null!;
}

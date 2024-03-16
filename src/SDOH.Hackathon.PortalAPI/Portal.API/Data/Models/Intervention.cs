using System;
using System.Collections.Generic;
using Data.Interfaces;

namespace Data.Models;

public partial class Intervention : IIdentified
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }
}

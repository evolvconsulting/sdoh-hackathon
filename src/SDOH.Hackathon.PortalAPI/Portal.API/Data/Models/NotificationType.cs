using System;
using System.Collections.Generic;
using Data.Interfaces;

namespace Data.Models;

public partial class NotificationType : IIdentified
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? Template { get; set; }
}

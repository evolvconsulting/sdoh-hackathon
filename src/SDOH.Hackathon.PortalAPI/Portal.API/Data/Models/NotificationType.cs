using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class NotificationType
{
    public string Id { get; set; } = null!;

    public string NotificationTypeId { get; set; } = null!;

    public string? Name { get; set; }

    public string? Template { get; set; }
}

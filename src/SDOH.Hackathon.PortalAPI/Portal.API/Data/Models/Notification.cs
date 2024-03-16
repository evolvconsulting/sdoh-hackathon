using System;
using System.Collections.Generic;
using Data.Interfaces;

namespace Data.Models;

public partial class Notification
{
    public string Id { get; set; } = null!;

    public string PatientId { get; set; } = null!;

    public string? Message { get; set; }

    public string? NotificationTypeId { get; set; }

    public DateTime? InsertDate { get; set; }

    public DateTime? DeliveredDate { get; set; }

    public DateTime? ReadDate { get; set; }

    public long? IsDeleted { get; set; }

    public string? InterventionId { get; set; }
}

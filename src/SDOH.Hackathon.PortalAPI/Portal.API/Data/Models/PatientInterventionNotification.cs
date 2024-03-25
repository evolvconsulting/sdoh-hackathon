using Data.Interfaces;
using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class PatientInterventionNotification : IIdentified
{
    public string Id { get; set; } = null!;

    public string PatientInterventionId { get; set; } = null!;

    public string? NotificationId { get; set; }
}

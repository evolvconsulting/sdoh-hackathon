using System;
using System.Collections.Generic;
using Data.Interfaces;

namespace Data.Models;

public partial class MappingTable : IIdentified
{
    public string Id { get; set; } = null!;

    public string MappingId { get; set; } = null!;

    public string PatientInterventionNotification { get; set; } = null!;

    public string PatientId { get; set; } = null!;

    public long InterventionId { get; set; }

    public long NotificationId { get; set; }
}

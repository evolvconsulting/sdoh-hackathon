using System;
using System.Collections.Generic;
using Data.Interfaces;

namespace Data.Models;

public partial class PatientIntervention
{
    public string Id { get; set; } = null!;

    public string? PatientId { get; set; }

    public string? StatusId { get; set; }

    public long? IsManual { get; set; }

    public DateTime? EnrolledDate { get; set; }

    public DateTime? OptOutDate { get; set; }

    public DateTime? SentToUserDate { get; set; }
}

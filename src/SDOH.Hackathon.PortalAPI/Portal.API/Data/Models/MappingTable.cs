namespace Data.Models;

public partial class MappingTable
{
    public string Id { get; set; } = null!;

    public string PatientInterventionNotification { get; set; } = null!;

    public string PatientId { get; set; } = null!;

    public long InterventionId { get; set; }

    public long NotificationId { get; set; }
}

using Data.Interfaces;

namespace Data.Models;

public partial class InterventionResource : IIdentified
{
    public string Id { get; set; } = null!;

    public string TypeId { get; set; } = null!;

    public string? Document { get; set; }

    public string? Url { get; set; }
}

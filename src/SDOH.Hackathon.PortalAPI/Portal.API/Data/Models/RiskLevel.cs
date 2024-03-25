using Data.Interfaces;

namespace Data.Models;

public partial class RiskLevel : IIdentified
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Severity { get; set; } = null!;
}

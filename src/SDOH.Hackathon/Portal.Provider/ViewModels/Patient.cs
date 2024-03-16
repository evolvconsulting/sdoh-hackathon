namespace Portal.Provider.ViewModels;

public class Patient
{
    public string Id { get; set; }
    public string FirstName { get; set; }
    public required string LastName { get; set; }
    public char MiddleInitial { get; set; }
    public DateTime DateOfBirth { get; set; }
    public required List<Intervention> Interventions { get; set; }
    public required string RiskLevel { get; set; }
}

namespace Data.Models;

public partial class HighRiskQc
{
    public string? Id { get; set; }

    public DateOnly? Birthdate { get; set; }

    public DateOnly? Deathdate { get; set; }

    public string? Ssn { get; set; }

    public string? Drivers { get; set; }

    public string? Passport { get; set; }

    public string? Prefix { get; set; }

    public string? First { get; set; }

    public string? Last { get; set; }

    public string? Suffix { get; set; }

    public string? Maiden { get; set; }

    public string? Marital { get; set; }

    public string? Race { get; set; }

    public string? Ethnicity { get; set; }

    public string? Gender { get; set; }

    public string? Birthplace { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? County { get; set; }

    public long? Fips { get; set; }

    public long? Zip { get; set; }

    public decimal? Lat { get; set; }

    public decimal? Lon { get; set; }

    public decimal? HealthcareExpenses { get; set; }

    public decimal? HealthcareCoverage { get; set; }

    public long? Income { get; set; }

    public long? Smoker { get; set; }

    public DateOnly? StartTime { get; set; }

    public DateOnly? Stop { get; set; }

    public string? Patient { get; set; }

    public string? Encounter { get; set; }

    public long? Code { get; set; }

    public string? Description { get; set; }
}

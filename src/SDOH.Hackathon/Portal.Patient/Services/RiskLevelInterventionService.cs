namespace Portal.Patient.Services;

public class RiskLevelInterventionService : BaseService<Data.Models.RiskLevelIntervention>
{
    public RiskLevelInterventionService(IHttpClientFactory clientFactory) : base(clientFactory, "risk-level-interventions") { }
}
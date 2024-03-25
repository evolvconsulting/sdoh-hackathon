namespace Portal.Patient.Services;

public class RiskLevelService : BaseService<Data.Models.RiskLevel>
{
    public RiskLevelService(IHttpClientFactory clientFactory) : base(clientFactory, "risk-levels") { }
}
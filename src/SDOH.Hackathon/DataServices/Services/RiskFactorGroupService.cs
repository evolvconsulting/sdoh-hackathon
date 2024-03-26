namespace DataServices.Services;

public class RiskFactorGroupService : BaseService<Data.Models.RiskFactorGroup>
{
    public RiskFactorGroupService(IHttpClientFactory clientFactory) : base(clientFactory, "risk-factor-groups") { }
}
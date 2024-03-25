namespace Portal.Provider.Services;

public class RiskFactorService : BaseService<Data.Models.RiskFactor>
{
    public RiskFactorService(IHttpClientFactory clientFactory) : base(clientFactory, "risk-factors") { }
}
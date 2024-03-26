namespace Portal.Provider.Services;

public class PatientRiskFactorService : PatientRelatedService<Data.Models.PatientRiskFactor>
{
    public PatientRiskFactorService(IHttpClientFactory clientFactory) : base(clientFactory, "patient-risk-factors") { }
}
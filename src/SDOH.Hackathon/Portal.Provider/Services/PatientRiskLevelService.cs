namespace Portal.Provider.Services;

public class PatientRiskLevelService : PatientRelatedService<Data.Models.PatientRiskLevel>
{
    public PatientRiskLevelService(IHttpClientFactory clientFactory) : base(clientFactory, "patient-risk-levels") { }
}
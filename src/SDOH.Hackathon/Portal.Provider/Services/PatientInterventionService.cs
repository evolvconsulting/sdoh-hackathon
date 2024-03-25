namespace Portal.Provider.Services;

public class PatientInterventionService : BaseService<Data.Models.PatientIntervention>
{
    public PatientInterventionService(IHttpClientFactory clientFactory) : base(clientFactory, "patient-interventions") { }
}
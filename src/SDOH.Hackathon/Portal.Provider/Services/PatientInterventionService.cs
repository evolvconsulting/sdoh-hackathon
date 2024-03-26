namespace Portal.Provider.Services;

public class PatientInterventionService : PatientRelatedService<Data.Models.PatientIntervention>
{
    public PatientInterventionService(IHttpClientFactory clientFactory) : base(clientFactory, "patient-interventions") { }
}
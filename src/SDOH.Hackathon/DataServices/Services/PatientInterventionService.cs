using Data.Models;
using DataServices.Interfaces;

namespace DataServices.Services;

public class PatientInterventionService : PatientRelatedService<PatientIntervention>, IPatientRelatedService<PatientIntervention>
{
    public PatientInterventionService(IHttpClientFactory clientFactory) : base(clientFactory, "patient-interventions")
    {
    }
}
using Microsoft.JSInterop;
using MudBlazor;
using Portal.Patient.Interfaces;
using Data.Models;
using Newtonsoft.Json;

namespace Portal.Patient.Services;

public class PatientInterventionService : PatientRelatedService<PatientIntervention>, IPatientRelatedService<PatientIntervention>
{
    public PatientInterventionService(IHttpClientFactory clientFactory) : base(clientFactory, "patient-interventions")
    {
    }
}
using Microsoft.JSInterop;
using MudBlazor;
using Portal.Patient.Interfaces;
using Data.Models;
using Newtonsoft.Json;

namespace Portal.Patient.Services;

public class PatientInterventionService : BaseService<PatientIntervention>, IPatientRelatedService<PatientIntervention>
{
    public PatientInterventionService(IHttpClientFactory clientFactory) : base(clientFactory, "patient-interventions")
    {
    }

    public async Task<IEnumerable<PatientIntervention>> GetByPatient(string patientId)
    { 
        using (var client = _clientFactory.CreateClient("genericClientFactory"))
        {
            var getResult = await client.GetAsync($"{_controllerRoute}/get/{patientId}");
            if (!getResult.IsSuccessStatusCode)
            {
                throw new HttpRequestException(await getResult.Content.ReadAsStringAsync(), new Exception(getResult.ReasonPhrase), getResult.StatusCode);
                //return StatusCode((int)tokenResponse.StatusCode, await tokenResponse.Content.ReadAsStringAsync());
            }
            var body = await getResult.Content.ReadAsStringAsync();
            var entity = (JsonConvert.DeserializeObject<IEnumerable<PatientIntervention>>(body));
            return entity;
        }
    }
}
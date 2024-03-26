using Microsoft.JSInterop;
using MudBlazor;
using Portal.Provider.Interfaces;
using Data.Models;
using Newtonsoft.Json;
using Data.Interfaces;

namespace Portal.Provider.Services;

public abstract class PatientRelatedService<T> : BaseService<T>, IPatientRelatedService<T>
    where T : class, IIdentified
{
    public PatientRelatedService(IHttpClientFactory clientFactory, string controllerRoute) : base(clientFactory, controllerRoute)
    {
    }

    public async Task<IEnumerable<T>> GetByPatient(string patientId)
    {
        using (var client = _clientFactory.CreateClient("genericClientFactory"))
        {
            var getResult = await client.GetAsync($"{_controllerRoute}/get-by-patient/{patientId}");
            if (!getResult.IsSuccessStatusCode)
            {
                throw new HttpRequestException(await getResult.Content.ReadAsStringAsync(), new Exception(getResult.ReasonPhrase), getResult.StatusCode);
                //return StatusCode((int)tokenResponse.StatusCode, await tokenResponse.Content.ReadAsStringAsync());
            }
            var body = await getResult.Content.ReadAsStringAsync();
            var entity = (JsonConvert.DeserializeObject<IEnumerable<T>>(body));
            return entity;
        }
    }
}
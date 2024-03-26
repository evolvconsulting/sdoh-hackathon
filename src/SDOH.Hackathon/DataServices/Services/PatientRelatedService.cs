using Data.Models;
using Data.Interfaces;
using DataServices.Interfaces;
using Newtonsoft.Json;
using System.Text;
using System.Net.Http;

namespace DataServices.Services;

public abstract class PatientRelatedService<T> : BaseService<T>, IPatientRelatedService<T>
    where T : class, IIdentified, IPatientRelated
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
            var entity = JsonConvert.DeserializeObject<IEnumerable<T>>(body);
            return entity;
        }
    }
}
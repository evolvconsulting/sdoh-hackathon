using Portal.Provider.Interfaces;
using Data.Interfaces;
using Newtonsoft.Json;
using System.Text;

namespace Portal.Provider.Services;

public abstract class BaseService<T> : IIdentifiedService<T>
    where T : class, IIdentified
{
    protected IHttpClientFactory _clientFactory;
    protected readonly string _controllerRoute;

    public BaseService(IHttpClientFactory clientFactory, string controllerRoute)
    {
        _clientFactory = clientFactory;
        _controllerRoute = controllerRoute;
    }

    public virtual async Task<T> Get(string id)
    {
        using (var client = _clientFactory.CreateClient("genericClientFactory"))
        {
            Console.WriteLine($"Route: {_controllerRoute} ID: {id}");
            var getResult = await client.GetAsync($"{_controllerRoute}/get/{id}");
            if (!getResult.IsSuccessStatusCode)
            {
                throw new HttpRequestException(await getResult.Content.ReadAsStringAsync(), new Exception(getResult.ReasonPhrase), getResult.StatusCode);
                //return StatusCode((int)tokenResponse.StatusCode, await tokenResponse.Content.ReadAsStringAsync());
            }
            var body = await getResult.Content.ReadAsStringAsync();
            var entity = (JsonConvert.DeserializeObject<T>(body));

            return entity;
        }
    }

    public virtual async Task<IEnumerable<T>> GetAll()
    {
        using (var client = _clientFactory.CreateClient("genericClientFactory"))
        {
            var getResult = await client.GetAsync($"{_controllerRoute}/get");
            if (!getResult.IsSuccessStatusCode)
            {
                throw new HttpRequestException(await getResult.Content.ReadAsStringAsync(), new Exception(getResult.ReasonPhrase), getResult.StatusCode);
            }
            var body = await getResult.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<T>>(body);
        }
    }

    public virtual async Task<bool> Put(T entity)
    {
        var wasSuccessful = false;
        var putContent = new StringContent(JsonConvert.SerializeObject(entity), Encoding.UTF8, "application/json");

        using (var client = _clientFactory.CreateClient())
        {
            var response = await client.PutAsync($"{_controllerRoute}/put", putContent);
            wasSuccessful = response.IsSuccessStatusCode;
        }

        return wasSuccessful;
    }

    public virtual async Task<bool> Delete(string id)
    {
        var wasSuccessful = false;

        using (var client = _clientFactory.CreateClient())
        {
            var response = await client.DeleteAsync($"{_controllerRoute}/delete/{id}");
            wasSuccessful = response.IsSuccessStatusCode;
        }
        return wasSuccessful;
    }
}

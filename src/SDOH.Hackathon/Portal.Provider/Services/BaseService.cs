using Portal.Provider.Interfaces;
using Data.Interfaces;
using Newtonsoft.Json;

namespace Portal.Provider.Services;

public abstract class BaseService<T> : IIdentifiedService<T>
    where T : class, IIdentified
{
    private IHttpClientFactory _clientFactory;
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

    public async virtual Task<bool> Put(T entity)
    {
        var wasSuccessful = false;
        using (var client = _clientFactory.CreateClient())
        {
            //var tokenResponse = await client.PostAsync($"{_baseUri}", ));
        }
        return wasSuccessful;
    }

    public async Task<List<T>> Get()
    {
        using (var client = _clientFactory.CreateClient("genericClientFactory"))
        {
            Console.WriteLine($"Route: {_controllerRoute}");

            var getResult = await client.GetAsync($"{_controllerRoute}/get");
            if (!getResult.IsSuccessStatusCode)
            {
                throw new HttpRequestException(await getResult.Content.ReadAsStringAsync(), new Exception(getResult.ReasonPhrase), getResult.StatusCode);
                //return StatusCode((int)tokenResponse.StatusCode, await tokenResponse.Content.ReadAsStringAsync());
            }
            var body = await getResult.Content.ReadAsStringAsync();
            var entity = (JsonConvert.DeserializeObject<List<T>>(body));

            if (entity == null) return new List<T>();

            return entity;
        }
    }
}

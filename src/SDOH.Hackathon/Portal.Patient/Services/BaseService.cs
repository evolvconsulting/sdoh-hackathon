using Microsoft.JSInterop;
using Portal.Patient.Constants;
using Portal.Patient.Interfaces;
//using Portal.Patient.Models;
using Data.Interfaces;
using Microsoft.Extensions.Http;
using Google.Apis.Auth.OAuth2.Responses;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Portal.Patient.Services;


public abstract class BaseService<T> : IIdentifiedService<T>
    where T : class, IIdentified
{
    private readonly IJSRuntime _JSRuntime;
    private IHttpClientFactory _clientFactory;
    protected readonly string _controllerRoute;

    public BaseService(IJSRuntime JSRuntime, IHttpClientFactory clientFactory, string controllerRoute)
    {
        _JSRuntime = JSRuntime;
        _clientFactory = clientFactory;
        _controllerRoute = controllerRoute;
    }

    public virtual async Task<T> Get(string id)
    {
        using (var client = _clientFactory.CreateClient("genericClientFactory"))
        {
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

    //public IEnumerable<T> GetForCurrentUser()
    //{
    //    //TODO: pull from API

    //    using (var client = _clientFactory.CreateClient())
    //    {
    //    }
    //    return new List<T>() {
    //         new Notification {
    //             NotificationTypeID = (int)NotificationTypeID.RecommendedIntervention,
    //             Message = "You have new recommended interventions. Click here to view more information."
    //         }
    //     };
    //}

    public async virtual Task<bool> Put(T entity)
    {
        var wasSuccessful = false;
        using (var client = _clientFactory.CreateClient())
        {
            //var tokenResponse = await client.PostAsync($"{_baseUri}", ));
        }
        return wasSuccessful;
    }

    //public async Task Subscribe()
    //{
    //    var subscription = await _JSRuntime.InvokeAsync<NotificationSubscription>("blazorPushNotifications.requestSubscription");


    //    if (subscription is not null)
    //    {
    //        // TODO store this user id.
    //        subscription.UserId = Guid.NewGuid().ToString();

    //        // TODO send subscription to server. 
    //    }
    //}
}

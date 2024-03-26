using Data.Models;
using System.Net.Http;

namespace DataServices.Services;

public class InterventionService : BaseService<Intervention>
{
    public InterventionService(IHttpClientFactory clientFactory) : base(clientFactory, "interventions")
    {
    }
}
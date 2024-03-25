using Data.Models;

namespace Portal.Provider.Services;

public class InterventionService : BaseService<Intervention>
{
    public InterventionService(IHttpClientFactory clientFactory) : base(clientFactory, "interventions")
    {
    }
}
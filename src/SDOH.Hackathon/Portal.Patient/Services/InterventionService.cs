using Microsoft.JSInterop;
using Data.Models;

namespace Portal.Patient.Services;

public class InterventionService : BaseService<Intervention>
{
    public InterventionService(IHttpClientFactory clientFactory) : base(clientFactory, "interventions")
    {
    }
}
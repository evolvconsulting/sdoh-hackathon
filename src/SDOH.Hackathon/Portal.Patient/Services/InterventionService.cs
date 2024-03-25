using Microsoft.JSInterop;
using Data.Models;

namespace Portal.Patient.Services;

public class InterventionService : BaseService<Intervention>
{
    public InterventionService(IJSRuntime JSRuntime, IHttpClientFactory clientFactory) : base(JSRuntime, clientFactory, "interventions")
    {
    }
}
using Microsoft.JSInterop;
using MudBlazor;
using Portal.Patient.Interfaces;
using Data.Models;

namespace Portal.Patient.Services;

public class InterventionService : BaseService<Intervention>
{
    public InterventionService(IJSRuntime JSRuntime, IHttpClientFactory clientFactory) : base(JSRuntime, clientFactory, "https://localhost:7011/interventions")
    {
    }
}
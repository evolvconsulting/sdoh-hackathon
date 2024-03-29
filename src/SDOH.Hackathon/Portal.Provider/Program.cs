using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Portal.Provider.Services;
using DataServices.Interfaces;
using DataServices.Services;
using Data.Models;
using Microsoft.Extensions.Http;

namespace Portal.Provider;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");

        builder.Services.AddMudServices();

        builder.Services.AddSingleton<AppBarService>();
        builder.Services.AddSingleton<IIdentifiedService<Patient>, PatientService>();
        builder.Services.AddSingleton<IIdentifiedService<NotificationType>, NotificationTypeService>();
        builder.Services.AddSingleton<IIdentifiedService<PatientInterventionNotification>, PatientInterventionNotificationService>();
        builder.Services.AddSingleton<IPatientRelatedService<PatientIntervention>, PatientInterventionService>();
        builder.Services.AddSingleton<IPatientRelatedService<PatientRiskFactor>, PatientRiskFactorService>();
        builder.Services.AddSingleton<IPatientRelatedService<PatientRiskLevel>, PatientRiskLevelService>();
        builder.Services.AddSingleton<IIdentifiedService<RiskFactorGroup>, RiskFactorGroupService>();
        builder.Services.AddSingleton<IIdentifiedService<RiskFactor>, RiskFactorService>();
        builder.Services.AddSingleton<IIdentifiedService<RiskLevelIntervention>, RiskLevelInterventionService>();
        builder.Services.AddSingleton<IIdentifiedService<RiskLevel>, RiskLevelService>();
        builder.Services.AddSingleton<IPatientRelatedService<Notification>, NotificationService>();
        builder.Services.AddSingleton<IIdentifiedService<Intervention>, InterventionService>();
        builder.Services.AddSingleton<IIdentifiedService<InterventionResource>, InterventionResourceService>();

        builder.Services.AddHttpClient(
            "genericClientFactory",
            client =>
            {
                // Set the base address of the named client.
                client.BaseAddress = new Uri("https://localhost:56786");
            });

        await builder.Build().RunAsync();
    }
}

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Portal.Patient.Interfaces;
using Portal.Patient.Services;
using Data.Models;

namespace Portal.Patient
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddMudServices();
            builder.Services.AddSingleton<IIdentifiedService<Notification>, NotificationService>();
            builder.Services.AddSingleton<IIdentifiedService<Intervention>, InterventionService>();


            builder.Services.AddHttpClient(
                "genericClientFactory",
                client =>
                {
                    // Set the base address of the named client.
                    client.BaseAddress = new Uri("https://localhost:7011/");

                });

            await builder.Build().RunAsync();
        }
    }
}

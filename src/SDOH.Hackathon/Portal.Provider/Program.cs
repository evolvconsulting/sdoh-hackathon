using Data.Models;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Portal.Provider.Interfaces;
using Portal.Provider.Services;

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
        builder.Services.AddSingleton<IIdentifiedService<Patient>, PatientDataService>();

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

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Portal.Provider.Interfaces;
using Portal.Provider.Repositories;
using Portal.Provider.Services;
using Portal.Provider.ViewModels;

namespace Portal.Provider
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddMudServices();


            builder.Services.AddSingleton<IRepository<Patient>, PatientRepository>();
            builder.Services.AddSingleton<IDataService<Patient>, PatientDataService>();
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }
    }
}

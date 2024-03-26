namespace Portal.Provider.Pages;

using Microsoft.AspNetCore.Components;
using DataServices.Interfaces;
using DataServices.Services;
using Portal.Provider.Services;

public partial class Patients
{
    [Inject]
    public required IIdentifiedService<Data.Models.Patient> PatientService { get; set; }

    [Inject]
    public required AppBarService AppBarService { get; set; }

    public string? FilteredPatientName { get; set; }

    public List<Data.Models.Patient>? PatientList { get; set; }

    private const string PageName = "Patients";

    private bool resetValueOnEmptyText;
    private bool coerceText;
    private bool coerceValue;
    protected override async Task OnInitializedAsync()
    {
        PatientList = (await PatientService.GetAll()).ToList();
        AppBarService.SetSettings(PageName);
    }

    private async Task<IEnumerable<string>> PatientNameSearch(string value)
    {
        // In real life use an asynchronous function for fetching data from an api.
        await Task.Delay(5);

        // if text is null or empty, don't return values (drop-down will not open)
        if (string.IsNullOrEmpty(value))
        {
            FilteredPatientName = null;
            StateHasChanged();
            return new List<string>();
        }
        return PatientList.Where(x => $"{x.Last}, {x.First}"
            .Contains(value, StringComparison.InvariantCultureIgnoreCase))
            .Select(x => $"{x.Last}, {x.First}")
            .ToList();
    }
}

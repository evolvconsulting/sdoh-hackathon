namespace Portal.Provider.Pages;

using Microsoft.AspNetCore.Components;
using Portal.Provider.Interfaces;
using Portal.Provider.Services;

public partial class Patients
{
    [Inject]
    public required IDataService<ViewModels.Patient> PatientService { get; set; }

    [Inject]
    public required AppBarService AppBarService { get; set; }

    public string? FilteredPatientName { get; set; }

    public List<ViewModels.Patient>? PatientList { get; set; }

    private const string PageName = "Patients";

    private bool resetValueOnEmptyText;
    private bool coerceText;
    private bool coerceValue;
    protected override void OnInitialized()
    {
        PatientList = PatientService.GetAll();
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
        return PatientList.Where(x => $"{x.LastName}, {x.FirstName} {x.MiddleInitial}."
            .Contains(value, StringComparison.InvariantCultureIgnoreCase))
            .Select(x => $"{x.LastName}, {x.FirstName} {x.MiddleInitial}.")
            .ToList();
    }
}

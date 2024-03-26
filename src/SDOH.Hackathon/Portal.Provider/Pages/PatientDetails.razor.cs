using Microsoft.AspNetCore.Components;
using Portal.Provider.Interfaces;
using Portal.Provider.Services;
using Data.Models;

namespace Portal.Provider.Pages;

public partial class PatientDetails : ComponentBase
{
    [Parameter]
    public string Id { get; set; }

    private const string PageName = "Patient Details";
    private Patient currentPatient { get; set; }

    [Inject]
    private IIdentifiedService<Patient> _patientService { get; set; }

    [Inject]
    public AppBarService AppBarService { get; set; }

    protected override async Task OnInitializedAsync()
    {
        currentPatient = await _patientService.Get(Id);
        AppBarService.SetSettings(PageName, true, "/patients");
    }
}

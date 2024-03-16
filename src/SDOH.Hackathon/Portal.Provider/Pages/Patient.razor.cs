namespace Portal.Provider.Pages;

using Microsoft.AspNetCore.Components;
using Portal.Provider.Interfaces;
using Portal.Provider.Services;

public partial class Patient
{
    [Parameter]
    public string Id { get; set; }

    private const string PageName = "Patient Details";
    private ViewModels.Patient currentPatient { get; set; }

    [Inject]
    public IDataService<ViewModels.Patient> PatientService { get; set; }

    [Inject]
    public AppBarService AppBarService { get; set; }

    protected override void OnInitialized()
    {
        currentPatient = PatientService.GetById(Id);
        AppBarService.SetSettings(PageName, true, "/patients");
    }
}

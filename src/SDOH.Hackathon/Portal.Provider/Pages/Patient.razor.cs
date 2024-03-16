namespace Portal.Provider.Pages;

using Microsoft.AspNetCore.Components;
using Portal.Provider.Interfaces;

public partial class Patient
{
    [Parameter]
    public string Id { get; set; }

    private ViewModels.Patient currentPatient { get; set; }

    [Inject]
    public IDataService<ViewModels.Patient> PatientService { get; set; }

    protected override void OnInitialized()
    {
        currentPatient = PatientService.GetById(Id);
    }


}

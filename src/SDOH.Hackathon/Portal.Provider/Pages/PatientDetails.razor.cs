using Microsoft.AspNetCore.Components;
using Portal.Provider.Services;
using Data.Models;
using DataServices.Services;
using DataServices.Interfaces;

namespace Portal.Provider.Pages;

public partial class PatientDetails : ComponentBase
{
    [Parameter]
    public string Id { get; set; }

    private const string PageName = "Patient Details";
    private Patient currentPatient { get; set; }
    private IEnumerable<PatientIntervention> patientInterventions { get; set; }

    [Inject]
    private IIdentifiedService<Patient> _patientService { get; set; }

    [Inject]
    private IPatientRelatedService<PatientIntervention> _patientInterventionService { get; set; }

    [Inject]
    public AppBarService AppBarService { get; set; }

    protected override async Task OnInitializedAsync()
    {
        currentPatient = await _patientService.Get(Id);
        patientInterventions = await _patientInterventionService.GetByPatient(Id);
        AppBarService.SetSettings(PageName, true, "/patients");
    }
}

using Portal.Patient.Constants;
using System.Collections.ObjectModel;
using Data.Models;

namespace Portal.Patient.Pages;


public partial class SuggestedInterventions
{
    private const string PageName = "SuggestedInterventions";

    private IEnumerable<SuggestedInterventions> _newSuggestedInterventions { get; set; }

    private IReadOnlyDictionary<int, string> _notificationLinkByTypeID = new ReadOnlyDictionary<int, string>(new Dictionary<int, string>() {
        { (int)NotificationTypeID.RecommendedIntervention, "SuggestedInterventions" }
    });

    protected override async Task OnInitializedAsync()
    {
        string patientId = "f80611ed-5998-e2d3-060f-159138f8815e";
        var result = await _SuggestedInterventionService.GetByPatient(patientId);
        Console.WriteLine(result);
        Enroll(result.FirstOrDefault());
        OptOut(result.FirstOrDefault());
        base.OnInitialized();
    }

    protected async Task Enroll(PatientIntervention patientIntervention)
    {
        patientIntervention.EnrolledDate = DateTime.Now;
        var wasSuccesful = await _SuggestedInterventionService.Put(patientIntervention);
        Console.WriteLine(wasSuccesful);
        Console.WriteLine("Enrolled successfully!");
    }

    protected async Task OptOut(PatientIntervention patientIntervention)
    {
        patientIntervention.OptOutDate = DateTime.Now;
        var wasSuccesful = await _SuggestedInterventionService.Put(patientIntervention);
        Console.WriteLine(wasSuccesful);
        Console.WriteLine("Opted-Out Successfully!");
    }

}
//using MudBlazor;
//using Portal.Patient.Interfaces;
//using Portal.Patient.Services;

//namespace Portal.Patient.Pages
//{
//    public partial class SuggestedInterventions
//    {
//        //private readonly IInterventionService _interventionService;
//        private IEnumerable<IIntervention> _interventions { get; set; }
//        private const Transition DefaultTransition = Transition.Slide;
//        public SuggestedInterventions()
//        {
//            //TODO: dependency injection rather than creating
//            //_interventionService = new InterventionService();
//        }

//        protected override void OnInitialized()
//        {
//            Console.Write("initialized view test");
//            //_interventions = _interventionService.GetSuggestedInterventiondForCurrentUser();
//            base.OnInitialized();
//        }

//        private bool Enroll(int interventionID)
//        {
//            Console.Write($"enrolling in {interventionID}");
//            var success = _interventionService.EnrollCurrentUser(interventionID);

//            if (success)
//            {
//                Snackbar.Add("Successfully enrolled in the intervention!", Severity.Success);
//            }
//            else
//            {
//                Snackbar.Add("Failed to enroll in the intervention.", Severity.Error);
//            }

//            return success;
//        }
//    }
//}

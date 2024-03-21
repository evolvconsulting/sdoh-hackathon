using MudBlazor;
using Portal.Patient.Interfaces;
using Portal.Patient.Services;

namespace Portal.Patient.Pages
{
    public partial class SuggestedInterventions
    {
        private readonly IInterventionService _interventionService;
        private IEnumerable<IIntervention> _interventions { get; set; }
        private const Transition DefaultTransition = Transition.Slide;
        public SuggestedInterventions()
        {
            //TODO: dependency injection rather than creating
            _interventionService = new InterventionService();
        }

        protected override void OnInitialized()
        {
            Console.Write("initialized view test");
            _interventions = _interventionService.GetSuggestedInterventiondForCurrentUser();
            base.OnInitialized();
        }

        private bool Enroll(int interventionID)
        {
            Console.Write($"enrolling in {interventionID}");
            var success = _interventionService.EnrollCurrentUser(interventionID);

            if (success)
            {
                Snackbar.Add("Successfully enrolled in the intervention!", Severity.Success);
            }
            else
            {
                Snackbar.Add("Failed to enroll in the intervention.", Severity.Error);
            }

            return success;
        }
    }
}

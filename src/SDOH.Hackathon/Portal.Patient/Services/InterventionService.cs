using Portal.Patient.Interfaces;
using Portal.Patient.Models;
using static Portal.Patient.Pages.SuggestedInterventions;

namespace Portal.Patient.Services
{
    public class InterventionService : IInterventionService
    {
        public IEnumerable<IIntervention> GetSuggestedInterventiondForCurrentUser()
        {
            //TODO: pull from API
            return new List<IIntervention>
            {
                new Intervention {
                    Name = "Home Oxygen Therapy",
                    Description = "Your body can’t live without the oxygen you breathe in from the air. But if you have lung disease or other medical conditions, you may not get enough of it. That can leave you short of breath and cause problems with your heart, brain, and other parts of your body."
                },
                new Intervention
                {
                    Name = "Smoking Cessation Program",
                    Description = "Smoking is the leading cause of COPD, and quitting smoking is essential in managing the disease and preventing further deterioration of lung function. Smoking cessation programs provide support, counseling, and resources to help individuals quit smoking successfully. These programs may offer behavioral interventions, pharmacotherapy (such as nicotine replacement therapy or prescription medications), and ongoing support to address nicotine addiction and related challenges."
                },
                new Intervention
                {
                    Name = "Disease Management Program",
                    Description = "Disease management programs provide ongoing support and coordination of care for individuals with chronic conditions like COPD."
                }
            };
        }

        public bool EnrollCurrentUser(int interventionID)
        {
            //TODO: wire up to API
            return true;
        }

        private async Task EnrollUser(int interventionID)
        {
            bool success = await InterventionService.EnrollCurrentUser(interventionID);
            if (success)
            {
                Snackbar.Add("Successfully enrolled in the intervention!", Severity.Success);
            }
            else
            {
                Snackbar.Add("Failed to enroll in the intervention.", Severity.Error);
            }
        }
    }
}

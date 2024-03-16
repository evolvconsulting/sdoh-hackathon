using Portal.Patient.Interfaces;

namespace Portal.Patient.Services
{
    public interface IInterventionService
    {
        public IEnumerable<IIntervention> GetSuggestedInterventiondForCurrentUser();
        public bool EnrollCurrentUser(int interventionID);
    }
}

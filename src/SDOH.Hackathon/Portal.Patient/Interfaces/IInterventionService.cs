namespace Portal.Patient.Interfaces
{
    public interface IInterventionService
    {
        public IEnumerable<IIntervention> GetSuggestedInterventiondForCurrentUser();
        public bool EnrollCurrentUser(int interventionID);
    }
}

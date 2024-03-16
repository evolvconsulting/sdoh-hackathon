using Portal.Patient.Interfaces;

namespace Portal.Patient.Services
{
    public interface INotificationService
    {
        public IEnumerable<INotification> GetForCurrentUser();
    }

}

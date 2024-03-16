using Portal.Patient.Constants;
using Portal.Patient.Interfaces;
using Portal.Patient.Models;
using Portal.Patient.Services;

namespace Portal.Patient.Repositories
{
    public class NotificationService : INotificationService
    {
        public NotificationService()
        {
        }

        public IEnumerable<INotification> GetForCurrentUser()
        {
            //TODO: pull from API

            return new List<Notification>() {
                new Notification { 
                    NotificationTypeID = (int)NotificationTypeID.RecommendedIntervention, 
                    Message = "You have new recommended interventions. Click here to view more information." 
                }
            };
        }
    }
}

using Portal.Patient.Interfaces;

namespace Portal.Patient.Models
{
    public class Notification : INotification
    {
        public int NotificationTypeID { get; set; }
        public string Message { get; set; }
    }
}

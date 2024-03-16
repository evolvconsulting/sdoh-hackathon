using Portal.Patient.Constants;
using Portal.Patient.Interfaces;
using Portal.Patient.Repositories;
using Portal.Patient.Services;
using System.Collections.ObjectModel;

namespace Portal.Patient.Pages
{
    public partial class Notifications
    {
        private const string PageName = "Notifications";

        private IEnumerable<INotification> _newNotifications { get; set; }
        private readonly INotificationService _notificationService;
        private IReadOnlyDictionary<int, string> _notificationLinkByTypeID = new ReadOnlyDictionary<int, string>(new Dictionary<int, string>() {
            { (int)NotificationTypeID.RecommendedIntervention, "SuggestedInterventions" }
        });

        public Notifications()
        {
            //TODO: change to dependency injection
            _notificationService = new NotificationService();
        }

        protected override void OnInitialized()
        {
            _newNotifications = _notificationService.GetForCurrentUser();
            //AppBarService.SetSettings(PageName, true, "/patients");
            base.OnInitialized();
        }
    }
}

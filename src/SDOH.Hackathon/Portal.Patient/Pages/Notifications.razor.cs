using Microsoft.AspNetCore.Components;
using Portal.Patient.Constants;
using Portal.Patient.Interfaces;
using Portal.Patient.Services;
using System.Collections.ObjectModel;
namespace Portal.Patient.Pages;


public partial class Notifications : ComponentBase
{
    private const string PageName = "Notifications";

    private IEnumerable<INotification> _newNotifications { get; set; }
        
    private IReadOnlyDictionary<int, string> _notificationLinkByTypeID = new ReadOnlyDictionary<int, string>(new Dictionary<int, string>() {
        { (int)NotificationTypeID.RecommendedIntervention, "SuggestedInterventions" }
    });


    protected override void OnInitialized()
    {
        _newNotifications = _notificationService.GetForCurrentUser();
        base.OnInitialized();
    }
}

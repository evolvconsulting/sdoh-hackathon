using Microsoft.AspNetCore.Components;
using Portal.Patient.Constants;
using Portal.Patient.Interfaces;
using Portal.Patient.Services;
using System.Collections.ObjectModel;
using Data.Models;
namespace Portal.Patient.Pages;


public partial class Notifications : ComponentBase
{
    private const string PageName = "Notifications";

    private IEnumerable<Notification> _newNotifications { get; set; }
        
    private IReadOnlyDictionary<int, string> _notificationLinkByTypeID = new ReadOnlyDictionary<int, string>(new Dictionary<int, string>() {
        { (int)NotificationTypeID.RecommendedIntervention, "SuggestedInterventions" }
    });


    protected override async Task OnInitializedAsync()
    {
        var result = await _notificationService.Get("1");
        Console.WriteLine(result.Id);
        base.OnInitialized();
    }
}

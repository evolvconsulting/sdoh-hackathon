namespace Portal.Provider.Services;

public class PatientInterventionNotificationService : BaseService<Data.Models.PatientInterventionNotification>
{
    public PatientInterventionNotificationService(IHttpClientFactory clientFactory) : base(clientFactory, "patient-intervention-notifications") { }
}
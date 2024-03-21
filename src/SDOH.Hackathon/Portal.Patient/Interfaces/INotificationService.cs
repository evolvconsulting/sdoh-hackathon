namespace Portal.Patient.Interfaces;

public interface INotificationService
{
    public IEnumerable<INotification> GetForCurrentUser();

    public Task Subscribe();
}

using Data.Interfaces;
namespace Portal.Patient.Interfaces;

public interface IIdentifiedService<T>
        where T : class, IIdentified
{
    //public IEnumerable<INotification> GetForCurrentUser();
    public Task<T> Get(string id);
}

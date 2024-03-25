using Data.Interfaces;
using Data.Models;

namespace Portal.Patient.Interfaces;

public interface IIdentifiedService<T>
        where T : class, IIdentified
{
    //public IEnumerable<INotification> GetForCurrentUser();
    public Task<T> Get(string id);
    public Task<bool> Put(T obj);

}

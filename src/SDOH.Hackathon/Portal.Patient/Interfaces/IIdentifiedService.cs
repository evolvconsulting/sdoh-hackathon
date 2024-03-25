using Data.Interfaces;
namespace Portal.Patient.Interfaces;

public interface IIdentifiedService<T>
        where T : class, IIdentified
{
    public Task<T> Get(string id);
    public Task<IEnumerable<T>> GetAll();
    public Task<bool> Put(T entity);
    public Task<bool> Delete(string id);
}

using Data.Interfaces;

namespace Portal.Provider.Interfaces;

public interface IIdentifiedService<T>
        where T : class, IIdentified
{
    public Task<T> Get(string id);
    public Task<List<T>> Get();
}

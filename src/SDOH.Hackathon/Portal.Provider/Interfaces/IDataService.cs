namespace Portal.Provider.Interfaces;

public interface IDataService<T>
{
    public List<T> GetAll();
    public T GetById(string id);
}

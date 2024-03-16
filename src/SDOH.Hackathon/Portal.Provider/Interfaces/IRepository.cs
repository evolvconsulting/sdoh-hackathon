namespace Portal.Provider.Interfaces
{
    public interface IRepository<T>
    {
        public List<T> GetAll();
        public T Get(string id);
    }
}

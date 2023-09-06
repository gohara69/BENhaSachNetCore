namespace NhaSachDotNet.Repository
{
    public interface IRepository<T>
    {
        List<T> getAll();
        T getById(long id);
        bool update(long id, T entity);
        T create(T entity);
        bool delete(long id);
    }
}

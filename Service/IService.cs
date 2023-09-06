namespace NhaSachDotNet.Service
{
    public interface IService<T>
    {
        List<T> getAll();
        T getById(long id);
        bool update(long id, T entity);
        T create(T objectDTO);
        bool delete(long id);
    }
}

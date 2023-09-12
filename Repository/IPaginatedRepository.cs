using NhaSachDotNet.DTO;

namespace NhaSachDotNet.Repository
{
    public interface IPaginatedRepository<T>
    {
        List<T> getAll();
        PaginationObject<T> getAllPagination(string search, int page);
        T getById(long id);
        bool update(long id, T entity);
        T create(T entity);
        bool delete(long id);
    }
}

using NhaSachDotNet.DTO;

namespace NhaSachDotNet.Service
{
    public interface IPaginatedService<T>
    {
        List<T> getAll();
        PaginationObject<T> getAll(string? search, int? page);

        T getById(long id);
        bool update(long id, T entity);
        T create(T objectDTO);
        bool delete(long id);
    }
}

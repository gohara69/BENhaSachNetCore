using NhaSachDotNet.DTO;
using NhaSachDotNet.Entity;

namespace NhaSachDotNet.Repository
{
    public class SachRepository : IPaginatedRepository<Sachs>
    {
        private readonly MyDbContext _context;
        public int PAGE_SIZE { get; set; } = 4 ;
        public SachRepository(MyDbContext context)
        {
            _context = context;
        }

        public Sachs create(Sachs entity)
        {
            throw new NotImplementedException();
        }

        public bool delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<Sachs> getAll()
        {
            var listSach = _context.sach.ToList();
            return listSach;
        }

        public Sachs getById(long id)
        {
            throw new NotImplementedException();
        }

        public bool update(long id, Sachs entity)
        {
            throw new NotImplementedException();
        }

        public PaginationObject<Sachs> getAllPagination(string search, int page)
        {
            var listBook = _context.sach.AsQueryable();
            int total = listBook.Count();
            PaginationObject<Sachs> paginatedSachs = new PaginationObject<Sachs>();
            paginatedSachs.total = (int)Math.Ceiling(total / (double)PAGE_SIZE);
            paginatedSachs.page = page;
            paginatedSachs.pageSize = PAGE_SIZE;
            #region Search
            if (!string.IsNullOrEmpty(search))
            {
                listBook = listBook.Where(book => book.tenSach.Contains(search));
            }
            #endregion
            paginatedSachs.content = listBook.Skip((page - 1) * PAGE_SIZE).Take(PAGE_SIZE).ToList();
            return paginatedSachs;
        }
    }
}

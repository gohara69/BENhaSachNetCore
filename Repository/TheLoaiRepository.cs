using NhaSachDotNet.Entity;

namespace NhaSachDotNet.Repository
{
    public class TheLoaiRepository : IRepository<TheLoai>
    {
        private readonly MyDbContext _context;
        public TheLoaiRepository(MyDbContext context)
        {
            _context = context;
        }

        public bool delete(long id)
        {
            try
            {
                var theLoai = _context.theLoai.SingleOrDefault(t => t.Id == id);
                if(theLoai != null)
                {
                    _context.theLoai.Remove(theLoai);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            } catch
            {
                return false;
            }
        }

        public List<TheLoai> getAll()
        {
            var listTheLoai = _context.theLoai.ToList();
            return listTheLoai;
        }

        public TheLoai getById(long id)
        {
            var theLoai = _context.theLoai.SingleOrDefault(tl => tl.Id == id);
            return theLoai;
        }

        public TheLoai create(TheLoai entity)
        {
            try
            {
                _context.theLoai.Add(entity);
                _context.SaveChanges();
                return entity;
            }
            catch
            {
                return null;
            }
        }

        public bool update(long id, TheLoai entity)
        {
            try
            {
                if(entity.Id != id)
                {
                    return false;
                }
                var theLoai = _context.theLoai.SingleOrDefault(tl => tl.Id == id);
                if(theLoai != null)
                {
                    theLoai.tenTheLoai = entity.tenTheLoai;
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}

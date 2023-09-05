using Microsoft.EntityFrameworkCore;

namespace NhaSachDotNet.Entity
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) { }   

        public DbSet<Sachs> sach { get; set; }
        public DbSet<TheLoai> theLoai { get; set; }
    }
}

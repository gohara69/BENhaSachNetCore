using Microsoft.EntityFrameworkCore;

namespace NhaSachDotNet.Entity
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) { }   

        public DbSet<Sachs> sach { get; set; }
        public DbSet<TheLoai> theLoai { get; set; }
        public DbSet<User> users { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");
                entity.HasKey(u => u.Id);
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.ToTable("HoaDon");
                entity.HasKey(hd => hd.Id);
            });

            modelBuilder.Entity<ChiTietHoaDon>(entity =>
            {
                entity.ToTable("CTHD");
                entity.HasKey(cthd => cthd.id);

                entity.HasOne(e => e.hoaDon)
                    .WithMany(e => e.listCTHD)
                    .HasForeignKey(e => e.hoaDonId)
                    .HasConstraintName("FK_CTHD_HoaDon");

                entity.HasOne(e => e.sach)
                    .WithMany(e => e.listCTHD)
                    .HasForeignKey(e => e.sachId)
                    .HasConstraintName("FK_CTHD_Sach");
            });
        }
    }
}

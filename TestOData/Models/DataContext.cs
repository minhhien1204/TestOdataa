namespace TestOData.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<ChiTietDonDatHang> ChiTietDonDatHangs { get; set; }
        public virtual DbSet<ChiTietThucAn> ChiTietThucAns { get; set; }
        public virtual DbSet<DonDatHang> DonDatHangs { get; set; }
        public virtual DbSet<LoaiThucAn> LoaiThucAns { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietDonDatHang>()
                .Property(e => e.IDThucAn)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietThucAn>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietThucAn>()
                .Property(e => e.AnhChinh)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietThucAn>()
                .Property(e => e.Anh2)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietThucAn>()
                .Property(e => e.Anh3)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietThucAn>()
                .Property(e => e.Anh4)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietThucAn>()
                .Property(e => e.IDLoai)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietThucAn>()
                .Property(e => e.MetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietThucAn>()
                .HasMany(e => e.ChiTietDonDatHangs)
                .WithOptional(e => e.ChiTietThucAn)
                .HasForeignKey(e => e.IDThucAn);

            modelBuilder.Entity<DonDatHang>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<DonDatHang>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<DonDatHang>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<DonDatHang>()
                .HasMany(e => e.ChiTietDonDatHangs)
                .WithRequired(e => e.DonDatHang)
                .HasForeignKey(e => e.IDDonDatHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiThucAn>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiThucAn>()
                .Property(e => e.Link)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiThucAn>()
                .HasMany(e => e.ChiTietThucAns)
                .WithRequired(e => e.LoaiThucAn)
                .HasForeignKey(e => e.IDLoai)
                .WillCascadeOnDelete(false);
        }
    }
}

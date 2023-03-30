using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace rv.Models;

public partial class QlrvContext : DbContext
{
    public QlrvContext()
    {
    }

    public QlrvContext(DbContextOptions<QlrvContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TinRaoVat> TinRaoVats { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=localhost,1433;Database=qlrv;User=sa;Password=123456aA@;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TinRaoVat>(entity =>
        {
            entity.HasKey(e => e.MaTin);

            entity.ToTable("TinRaoVat");

            entity.Property(e => e.MaTin)
                .ValueGeneratedNever()
                .HasColumnName("maTin");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(50)
                .HasColumnName("diaChi");
            entity.Property(e => e.GiaTien).HasColumnName("giaTien");
            entity.Property(e => e.HinhAnh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("hinhAnh");
            entity.Property(e => e.MaHinhThuc).HasColumnName("maHinhThuc");
            entity.Property(e => e.MaLoaiTin).HasColumnName("maLoaiTin");
            entity.Property(e => e.MaNguoiDung).HasColumnName("maNguoiDung");
            entity.Property(e => e.MaThanhPho)
                .HasMaxLength(50)
                .HasColumnName("maThanhPho");
            entity.Property(e => e.MaTinhTrang).HasColumnName("maTinhTrang");
            entity.Property(e => e.MaTrangThai).HasColumnName("maTrangThai");
            entity.Property(e => e.NgayGioDang)
                .HasColumnType("datetime")
                .HasColumnName("ngayGioDang");
            entity.Property(e => e.NgayHetHan)
                .HasColumnType("datetime")
                .HasColumnName("ngayHetHan");
            entity.Property(e => e.NoiDung)
                .HasMaxLength(255)
                .HasColumnName("noiDung");
            entity.Property(e => e.TieuDe)
                .HasMaxLength(50)
                .HasColumnName("tieuDe");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

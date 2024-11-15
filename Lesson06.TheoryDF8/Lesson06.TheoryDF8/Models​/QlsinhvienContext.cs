using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Lesson06.TheoryDF8.Models​;

public partial class QlsinhvienContext : DbContext
{
    public QlsinhvienContext()
    {
    }

    public QlsinhvienContext(DbContextOptions<QlsinhvienContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DanhSachSinhVien> DanhSachSinhViens { get; set; }

    public virtual DbSet<DanhSachSinhVienAnhVanTrieu> DanhSachSinhVienAnhVanTrieus { get; set; }

    public virtual DbSet<DeleteTable> DeleteTables { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Ketqua> Ketquas { get; set; }

    public virtual DbSet<Khoa> Khoas { get; set; }

    public virtual DbSet<MonHoc> MonHocs { get; set; }

    public virtual DbSet<SinhVien> SinhViens { get; set; }

    public virtual DbSet<SinhVienHocBongTphcm> SinhVienHocBongTphcms { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DAMQUOCDAN;Database=QLSINHVIEN;uid=sa;pwd=1234;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DanhSachSinhVien>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DanhSachSinhVien");

            entity.Property(e => e.GiớiTính).HasColumnName("Giới Tính");
            entity.Property(e => e.HọSinhViên)
                .HasMaxLength(15)
                .HasColumnName("Họ Sinh Viên");
            entity.Property(e => e.HọcBổng).HasColumnName("Học Bổng");
            entity.Property(e => e.MãKhoa)
                .HasMaxLength(2)
                .HasColumnName("Mã Khoa");
            entity.Property(e => e.MãSinhViên)
                .HasMaxLength(3)
                .HasColumnName("Mã Sinh Viên");
            entity.Property(e => e.NgàySinh)
                .HasColumnType("smalldatetime")
                .HasColumnName("Ngày Sinh");
            entity.Property(e => e.NơiSinh)
                .HasMaxLength(100)
                .HasColumnName("Nơi Sinh");
            entity.Property(e => e.TênSinhViên)
                .HasMaxLength(7)
                .HasColumnName("Tên Sinh Viên");
            entity.Property(e => e.ĐiểmTrungBình).HasColumnName("Điểm Trung Bình");
        });

        modelBuilder.Entity<DanhSachSinhVienAnhVanTrieu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DanhSachSinhVienAnhVanTrieu");

            entity.Property(e => e.MãKhoa)
                .HasMaxLength(2)
                .HasColumnName("Mã khoa");
            entity.Property(e => e.MãSinhViên)
                .HasMaxLength(3)
                .HasColumnName("Mã sinh viên");
        });

        modelBuilder.Entity<DeleteTable>(entity =>
        {
            entity.HasKey(e => e.MaSv).HasName("Prk_DeleteTable_MaSV");

            entity.ToTable("DeleteTable");

            entity.Property(e => e.MaSv)
                .HasMaxLength(3)
                .HasColumnName("MaSV");
            entity.Property(e => e.HoSv)
                .HasMaxLength(15)
                .HasColumnName("HoSV");
            entity.Property(e => e.MaKh)
                .HasMaxLength(2)
                .HasColumnName("MaKH");
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.NoiSinh).HasMaxLength(100);
            entity.Property(e => e.TenSv)
                .HasMaxLength(7)
                .HasColumnName("TenSV");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC276090274E");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FullName).HasMaxLength(100);
            entity.Property(e => e.Gender).HasMaxLength(10);
            entity.Property(e => e.PhoneNumber).HasMaxLength(20);
        });

        modelBuilder.Entity<Ketqua>(entity =>
        {
            entity.HasKey(e => new { e.MaSv, e.MaMh }).HasName("Prk_MaSV_MAMH");

            entity.ToTable("Ketqua");

            entity.Property(e => e.MaSv)
                .HasMaxLength(3)
                .HasColumnName("MaSV");
            entity.Property(e => e.MaMh)
                .HasMaxLength(2)
                .HasColumnName("MaMH");

            entity.HasOne(d => d.MaMhNavigation).WithMany(p => p.Ketquas)
                .HasForeignKey(d => d.MaMh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Frk_KetQua_Mamh");

            entity.HasOne(d => d.MaSvNavigation).WithMany(p => p.Ketquas)
                .HasForeignKey(d => d.MaSv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Frk_KetQua_Makh");
        });

        modelBuilder.Entity<Khoa>(entity =>
        {
            entity.HasKey(e => e.MaKh).HasName("Prk_KHOA_khoa");

            entity.ToTable("Khoa");

            entity.Property(e => e.MaKh)
                .HasMaxLength(2)
                .HasColumnName("MaKH");
            entity.Property(e => e.TenKh)
                .HasMaxLength(50)
                .HasColumnName("TenKH");
        });

        modelBuilder.Entity<MonHoc>(entity =>
        {
            entity.HasKey(e => e.MaMh).HasName("Prk_MONHOC_MaMH");

            entity.ToTable("MonHoc");

            entity.Property(e => e.MaMh)
                .HasMaxLength(2)
                .HasColumnName("MaMH");
            entity.Property(e => e.TenMh)
                .HasMaxLength(50)
                .HasColumnName("TenMH");
        });

        modelBuilder.Entity<SinhVien>(entity =>
        {
            entity.HasKey(e => e.MaSv).HasName("Prk_SINHVIEN_MaSV");

            entity.ToTable("SinhVien");

            entity.Property(e => e.MaSv)
                .HasMaxLength(3)
                .HasColumnName("MaSV");
            entity.Property(e => e.HoSv)
                .HasMaxLength(15)
                .HasColumnName("HoSV");
            entity.Property(e => e.HocBong).HasDefaultValue(0.0);
            entity.Property(e => e.MaKh)
                .HasMaxLength(2)
                .HasColumnName("MaKH");
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.NoiSinh).HasMaxLength(100);
            entity.Property(e => e.TenSv)
                .HasMaxLength(7)
                .HasColumnName("TenSV");

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.SinhViens)
                .HasForeignKey(d => d.MaKh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Frk_SINHVIEN_Makh");
        });

        modelBuilder.Entity<SinhVienHocBongTphcm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SinhVien_HocBong_TPHCM");

            entity.Property(e => e.Họ).HasMaxLength(15);
            entity.Property(e => e.HọcBổng).HasColumnName("Học bổng");
            entity.Property(e => e.MãKhoa)
                .HasMaxLength(2)
                .HasColumnName("Mã khoa");
            entity.Property(e => e.NơiSinh)
                .HasMaxLength(100)
                .HasColumnName("Nơi sinh");
            entity.Property(e => e.Tên).HasMaxLength(7);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

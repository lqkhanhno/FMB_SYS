using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class HVN_SYSContext : DbContext
    {
        public HVN_SYSContext()
        {
        }

        public HVN_SYSContext(DbContextOptions<HVN_SYSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<PFmbLabResult> PFmbLabResults { get; set; }
        public virtual DbSet<PFmbLabel> PFmbLabels { get; set; }
        public virtual DbSet<PFmbMasterListRubber> PFmbMasterListRubbers { get; set; }
        public virtual DbSet<PFmbMasterLocationRubber> PFmbMasterLocationRubbers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server =172.16.180.24; database = HVN_SYS;uid=hvn;pwd=Vietnam2023;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Korean_Wansung_CI_AS");

            modelBuilder.Entity<PFmbLabResult>(entity =>
            {
                entity.ToTable("P_FMB_Lab_Result");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CardId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("card_id");

                entity.Property(e => e.Cmb).HasColumnName("CMB");

                entity.Property(e => e.Fmb).HasColumnName("FMB");

                entity.Property(e => e.GravityCmb).HasColumnName("Gravity_CMB");

                entity.Property(e => e.IdNl).HasColumnName("ID_NL");

                entity.Property(e => e.Idca)
                    .HasMaxLength(20)
                    .HasColumnName("IDCa");

                entity.Property(e => e.IdloaiSp).HasColumnName("IDLoaiSP");

                entity.Property(e => e.IdspthongSo).HasColumnName("IDSPThongSo");

                entity.Property(e => e.KhoiLuong).HasColumnName("Khoi_luong");

                entity.Property(e => e.Kq)
                    .HasMaxLength(20)
                    .HasColumnName("KQ");

                entity.Property(e => e.Lotruber)
                    .HasColumnType("datetime")
                    .HasColumnName("LOTRuber");

                entity.Property(e => e.MaCode).HasMaxLength(100);

                entity.Property(e => e.MaNguyenLieu).HasMaxLength(100);

                entity.Property(e => e.NgayCan).HasColumnType("datetime");

                entity.Property(e => e.TenlsiBelong).HasColumnName("Tenlsi_Belong");

                entity.Property(e => e.TenlsiUts).HasColumnName("Tenlsi_UTS");

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");
            });

            modelBuilder.Entity<PFmbLabel>(entity =>
            {
                entity.HasKey(e => e.CartId);

                entity.ToTable("P_FMB_Label");

                entity.Property(e => e.CartId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("cart_id");

                entity.Property(e => e.FmbLine).HasColumnName("fmb_line");

                entity.Property(e => e.FmbNo).HasColumnName("fmb_no");

                entity.Property(e => e.InputTime)
                    .HasColumnType("datetime")
                    .HasColumnName("input_time");

                entity.Property(e => e.LabKind)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("lab_kind");

                entity.Property(e => e.LabQrCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lab_qr_code");

                entity.Property(e => e.MaxDuedate)
                    .HasColumnType("date")
                    .HasColumnName("max_duedate");

                entity.Property(e => e.MinDuedate)
                    .HasColumnType("date")
                    .HasColumnName("min_duedate");

                entity.Property(e => e.MixingDate)
                    .HasColumnType("date")
                    .HasColumnName("mixing_date");

                entity.Property(e => e.Pic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PIC");

                entity.Property(e => e.Place)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("place");

                entity.Property(e => e.RubberName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rubber_name");

                entity.Property(e => e.RubberWeight).HasColumnName("rubber_weight");
            });

            modelBuilder.Entity<PFmbMasterListRubber>(entity =>
            {
                entity.HasKey(e => e.RubberName)
                    .HasName("PK_P_FMB_MasterListDueDate");

                entity.ToTable("P_FMB_MasterListRubber");

                entity.Property(e => e.RubberName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rubber_name");

                entity.Property(e => e.RubberType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rubber_type");

                entity.Property(e => e.VadilityMax).HasColumnName("vadility_max");

                entity.Property(e => e.VadilityMin).HasColumnName("vadility_min");
            });

            modelBuilder.Entity<PFmbMasterLocationRubber>(entity =>
            {
                entity.HasKey(e => e.FmbLine)
                    .HasName("PK_P_FMB_MasterLocationRubber1");

                entity.ToTable("P_FMB_MasterLocationRubber");

                entity.Property(e => e.FmbLine)
                    .ValueGeneratedNever()
                    .HasColumnName("fmb_line");

                entity.Property(e => e.RubberName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rubber_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class COEX_MESContext : DbContext
    {
        public COEX_MESContext()
        {
        }

        public COEX_MESContext(DbContextOptions<COEX_MESContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Barcode> Barcodes { get; set; }
        public virtual DbSet<Ca> Cas { get; set; }
        public virtual DbSet<DataPclDlchung> DataPclDlchungs { get; set; }
        public virtual DbSet<DataPlcMaychat> DataPlcMaychats { get; set; }
        public virtual DbSet<DataPlcMaydun> DataPlcMayduns { get; set; }
        public virtual DbSet<DataPlcMaydunWrite> DataPlcMaydunWrites { get; set; }
        public virtual DbSet<DlThucte> DlThuctes { get; set; }
        public virtual DbSet<Kehoachsanxuat> Kehoachsanxuats { get; set; }
        public virtual DbSet<LichsuDangnhap> LichsuDangnhaps { get; set; }
        public virtual DbSet<LichsuLoi> LichsuLois { get; set; }
        public virtual DbSet<LoaiSanpham> LoaiSanphams { get; set; }
        public virtual DbSet<Nhansu> Nhansus { get; set; }
        public virtual DbSet<NhietdosoidotFix> NhietdosoidotFixes { get; set; }
        public virtual DbSet<Phanquyen> Phanquyens { get; set; }
        public virtual DbSet<SanphamLoaiong> SanphamLoaiongs { get; set; }
        public virtual DbSet<SanphamThongso> SanphamThongsos { get; set; }
        public virtual DbSet<SanphamThongsoKtchat> SanphamThongsoKtchats { get; set; }
        public virtual DbSet<SanphamThongsoMicrocop> SanphamThongsoMicrocops { get; set; }
        public virtual DbSet<SanphamThongsoNhietdosoidot> SanphamThongsoNhietdosoidots { get; set; }
        public virtual DbSet<SanphamThongsoTooling> SanphamThongsoToolings { get; set; }
        public virtual DbSet<SanphamTieuchuanlab> SanphamTieuchuanlabs { get; set; }
        public virtual DbSet<Thongbao> Thongbaos { get; set; }
        public virtual DbSet<Trangthai> Trangthais { get; set; }
        public virtual DbSet<TrichmauMicrocop> TrichmauMicrocops { get; set; }
        public virtual DbSet<VBaoCao> VBaoCaos { get; set; }
        public virtual DbSet<VBaoCaoChanged> VBaoCaoChangeds { get; set; }
        public virtual DbSet<VChonSp> VChonSps { get; set; }
        public virtual DbSet<VDlthucTe> VDlthucTes { get; set; }
        public virtual DbSet<VKeHoachSanXuat> VKeHoachSanXuats { get; set; }
        public virtual DbSet<VRun> VRuns { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder()
                                                .SetBasePath(Directory.GetCurrentDirectory())
                                                .AddJsonFile("appsettings1.json", optional: true, reloadOnChange: true);
                optionsBuilder.UseSqlServer("server =192.168.0.199; database = COEX_MES;uid=hutvn;pwd=Hvn123456;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Barcode>(entity =>
            {
                entity.ToTable("BARCODE");

                entity.Property(e => e.Id).HasColumnName("ID");

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

            modelBuilder.Entity<Ca>(entity =>
            {
                entity.ToTable("CA");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ca1)
                    .HasMaxLength(15)
                    .HasColumnName("Ca");

                entity.Property(e => e.ThoiGianBd).HasColumnName("ThoiGianBD");

                entity.Property(e => e.ThoiGianKt).HasColumnName("ThoiGianKT");
            });

            modelBuilder.Entity<DataPclDlchung>(entity =>
            {
                entity.ToTable("DATA_PCL_DLCHUNG");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<DataPlcMaychat>(entity =>
            {
                entity.ToTable("DATA_PLC_MAYCHAT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChangedMaSp).HasColumnName("Changed_MaSP");

                entity.Property(e => e.ChatMauSl).HasColumnName("ChatMau_SL");

                entity.Property(e => e.ChieuDaiBuSv).HasColumnName("Chieu_dai_bu_SV");

                entity.Property(e => e.ChieuDaiDatSv).HasColumnName("Chieu_dai_dat_SV");

                entity.Property(e => e.DuongkinhZumbachThucte).HasColumnName("Duongkinh_Zumbach_thucte");

                entity.Property(e => e.MaxZb).HasColumnName("Max_ZB");

                entity.Property(e => e.MinZb).HasColumnName("Min_ZB");

                entity.Property(e => e.OnCut).HasColumnName("ON_CUT");

                entity.Property(e => e.RunSys).HasColumnName("Run_sys");

                entity.Property(e => e.SlchatMau).HasColumnName("SLChatMau");

                entity.Property(e => e.SpKhoiluongPh).HasColumnName("SP_KhoiluongPH");

                entity.Property(e => e.SpKhoiluongdaiPh).HasColumnName("SP_KhoiluongdaiPH");

                entity.Property(e => e.WriteData).HasColumnName("Write_data");
            });

            modelBuilder.Entity<DataPlcMaydun>(entity =>
            {
                entity.ToTable("DATA_PLC_MAYDUN");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AtmDauTrucNgoai).HasColumnName("ATM_DauTruc_Ngoai");

                entity.Property(e => e.AtmDauTrucTrong).HasColumnName("ATM_DauTruc_Trong");

                entity.Property(e => e.EBarcode).HasColumnName("e_Barcode");

                entity.Property(e => e.NhietBeNuoc).HasColumnName("Nhiet_BeNuoc");

                entity.Property(e => e.RunSys).HasColumnName("Run_sys");

                entity.Property(e => e.TDauMay1Heater).HasColumnName("T_DauMay1_Heater");

                entity.Property(e => e.TDauMay1Pv).HasColumnName("T_DauMay1_PV");

                entity.Property(e => e.TDauMay1Sv).HasColumnName("T_DauMay1_SV");

                entity.Property(e => e.TDauMay2Heater).HasColumnName("T_DauMay2_Heater");

                entity.Property(e => e.TDauMay2Pv).HasColumnName("T_DauMay2_PV");

                entity.Property(e => e.TDauMay2Sv).HasColumnName("T_DauMay2_SV");

                entity.Property(e => e.TTruc1Heater).HasColumnName("T_Truc1_Heater");

                entity.Property(e => e.TTruc1Pv).HasColumnName("T_Truc1_PV");

                entity.Property(e => e.TTruc1Sv).HasColumnName("T_Truc1_SV");

                entity.Property(e => e.TTruc2Heater).HasColumnName("T_Truc2_Heater");

                entity.Property(e => e.TTruc2Pv).HasColumnName("T_Truc2_PV");

                entity.Property(e => e.TTruc2Sv).HasColumnName("T_Truc2_SV");

                entity.Property(e => e.TTrucVit1Heater).HasColumnName("T_TrucVit1_Heater");

                entity.Property(e => e.TTrucVit1Pv).HasColumnName("T_TrucVit1_PV");

                entity.Property(e => e.TTrucVit1Sv).HasColumnName("T_TrucVit1_SV");

                entity.Property(e => e.TTrucVit2Heater).HasColumnName("T_TrucVit2_Heater");

                entity.Property(e => e.TTrucVit2Pv).HasColumnName("T_TrucVit2_PV");

                entity.Property(e => e.TTrucVit2Sv).HasColumnName("T_TrucVit2_SV");

                entity.Property(e => e.TTvTruc1Heater).HasColumnName("T_TV_Truc1_Heater");

                entity.Property(e => e.TTvTruc1Pv).HasColumnName("T_TV_Truc1_PV");

                entity.Property(e => e.TTvTruc1Sv).HasColumnName("T_TV_Truc1_SV");

                entity.Property(e => e.TTvTruc2Heater).HasColumnName("T_TV_Truc2_Heater");

                entity.Property(e => e.TTvTruc2Pv).HasColumnName("T_TV_Truc2_PV");

                entity.Property(e => e.TTvTruc2Sv).HasColumnName("T_TV_Truc2_SV");

                entity.Property(e => e.TocDoTrucVitDunNgoai).HasColumnName("TocDoTrucVit_DunNgoai");

                entity.Property(e => e.TocDoTrucVitDunTrong).HasColumnName("TocDoTrucVit_DunTrong");

                entity.Property(e => e.Xe1Ngoai).HasColumnName("Xe1_Ngoai");

                entity.Property(e => e.Xe1Trong).HasColumnName("Xe1_Trong");

                entity.Property(e => e.Xe2Ngoai).HasColumnName("Xe2_Ngoai");

                entity.Property(e => e.Xe2Trong).HasColumnName("Xe2_Trong");

                entity.Property(e => e.Xe3Trong).HasColumnName("Xe3_Trong");
            });

            modelBuilder.Entity<DataPlcMaydunWrite>(entity =>
            {
                entity.ToTable("DATA_PLC_MAYDUN_WRITE");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AtmBeNuocNgoai).HasColumnName("ATM_BeNuoc_Ngoai");

                entity.Property(e => e.AtmBeNuocTrong).HasColumnName("ATM_BeNuoc_Trong");

                entity.Property(e => e.AtmMaxNgoai).HasColumnName("ATM_Max_Ngoai");

                entity.Property(e => e.AtmMaxTrong).HasColumnName("ATM_Max_Trong");

                entity.Property(e => e.AtmMinNgoai).HasColumnName("ATM_Min_Ngoai");

                entity.Property(e => e.AtmMinTrong).HasColumnName("ATM_Min_Trong");

                entity.Property(e => e.AtmSafetyNgoai).HasColumnName("ATM_Safety_Ngoai");

                entity.Property(e => e.AtmSafetyTrong).HasColumnName("ATM_Safety_Trong");

                entity.Property(e => e.AtmTieuChuanNgoai).HasColumnName("ATM_TieuChuan_Ngoai");

                entity.Property(e => e.AtmTieuChuanTrong).HasColumnName("ATM_TieuChuan_Trong");

                entity.Property(e => e.BarcodeOk).HasColumnName("Barcode_OK");

                entity.Property(e => e.ChangeMaSp).HasColumnName("ChangeMaSP");

                entity.Property(e => e.LocalRemote).HasColumnName("Local_Remote");

                entity.Property(e => e.LoiServer).HasColumnName("Loi_server");

                entity.Property(e => e.MicrosopeOk).HasColumnName("Microsope_OK");

                entity.Property(e => e.OnDauMayBnNgoai).HasColumnName("ON_DauMay_BN_Ngoai");

                entity.Property(e => e.OnDauMayBnTrong).HasColumnName("ON_DauMay_BN_Trong");

                entity.Property(e => e.OnDauMaySdNgoai).HasColumnName("ON_DauMay_SD_Ngoai");

                entity.Property(e => e.OnDauMaySdTrong).HasColumnName("ON_DauMay_SD_Trong");

                entity.Property(e => e.OnTruc1BnNgoai).HasColumnName("ON_Truc1_BN_Ngoai");

                entity.Property(e => e.OnTruc1BnTrong).HasColumnName("ON_Truc1_BN_Trong");

                entity.Property(e => e.OnTruc1SdNgoai).HasColumnName("ON_Truc1_SD_Ngoai");

                entity.Property(e => e.OnTruc1SdTrong).HasColumnName("ON_Truc1_SD_Trong");

                entity.Property(e => e.OnTruc2BnNgoai).HasColumnName("ON_Truc2_BN_Ngoai");

                entity.Property(e => e.OnTruc2BnTrong).HasColumnName("ON_Truc2_BN_Trong");

                entity.Property(e => e.OnTruc2SdNgoai).HasColumnName("ON_Truc2_SD_Ngoai");

                entity.Property(e => e.OnTruc2SdTrong).HasColumnName("ON_Truc2_SD_Trong");

                entity.Property(e => e.OnTrucVit1BnNgoai).HasColumnName("ON_TrucVit1_BN_Ngoai");

                entity.Property(e => e.OnTrucVit1SdNgoai).HasColumnName("ON_TrucVit1_SD_Ngoai");

                entity.Property(e => e.OnTrucVit2BnTrong).HasColumnName("ON_TrucVit2_BN_Trong");

                entity.Property(e => e.OnTrucVit2SdTrong).HasColumnName("ON_TrucVit2_SD_Trong");

                entity.Property(e => e.RunSys).HasColumnName("Run_sys");

                entity.Property(e => e.Stop).HasColumnName("STOP");

                entity.Property(e => e.TDauMayNgoai).HasColumnName("T_DauMay_Ngoai");

                entity.Property(e => e.TDauMayTrong).HasColumnName("T_DauMay_Trong");

                entity.Property(e => e.TDungSoiDotDauMayNgoai).HasColumnName("T_DungSoiDot_DauMay_Ngoai");

                entity.Property(e => e.TDungSoiDotDauMayTrong).HasColumnName("T_DungSoiDot_DauMay_Trong");

                entity.Property(e => e.TDungSoiDotTruc1Ngoai).HasColumnName("T_DungSoiDot_Truc1_Ngoai");

                entity.Property(e => e.TDungSoiDotTruc1Trong).HasColumnName("T_DungSoiDot_Truc1_Trong");

                entity.Property(e => e.TDungSoiDotTruc2Ngoai).HasColumnName("T_DungSoiDot_Truc2_Ngoai");

                entity.Property(e => e.TDungSoiDotTruc2Trong).HasColumnName("T_DungSoiDot_Truc2_Trong");

                entity.Property(e => e.TDungSoiDotTrucVitNgoai).HasColumnName("T_DungSoiDot_TrucVit_Ngoai");

                entity.Property(e => e.TDungSoiDotTrucVitTrong).HasColumnName("T_DungSoiDot_TrucVit_Trong");

                entity.Property(e => e.TGhDauMayNgoai).HasColumnName("T_GH_DauMay_Ngoai");

                entity.Property(e => e.TGhDauMayTrong).HasColumnName("T_GH_DauMay_Trong");

                entity.Property(e => e.TGhTruc1Ngoai).HasColumnName("T_GH_Truc1_Ngoai");

                entity.Property(e => e.TGhTruc1Trong).HasColumnName("T_GH_Truc1_Trong");

                entity.Property(e => e.TGhTruc2Ngoai).HasColumnName("T_GH_Truc2_Ngoai");

                entity.Property(e => e.TGhTruc2Trong).HasColumnName("T_GH_Truc2_Trong");

                entity.Property(e => e.TGhTrucVitNgoai).HasColumnName("T_GH_TrucVit_Ngoai");

                entity.Property(e => e.TGhTrucVitTrong).HasColumnName("T_GH_TrucVit_Trong");

                entity.Property(e => e.TTruc1Ngoai).HasColumnName("T_Truc1_Ngoai");

                entity.Property(e => e.TTruc1Trong).HasColumnName("T_Truc1_Trong");

                entity.Property(e => e.TTruc2Ngoai).HasColumnName("T_Truc2_Ngoai");

                entity.Property(e => e.TTruc2Trong).HasColumnName("T_Truc2_Trong");

                entity.Property(e => e.TTrucVitNgoai).HasColumnName("T_TrucVit_Ngoai");

                entity.Property(e => e.TTrucVitTrong).HasColumnName("T_TrucVit_Trong");

                entity.Property(e => e.WriteData).HasColumnName("Write_data");
            });

            modelBuilder.Entity<DlThucte>(entity =>
            {
                entity.ToTable("DL_THUCTE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AtmDauTrucNgoai).HasColumnName("ATM_DauTruc_Ngoai");

                entity.Property(e => e.AtmDauTrucTrong).HasColumnName("ATM_DauTruc_Trong");

                entity.Property(e => e.ChieuDaiBuSv).HasColumnName("Chieu_dai_bu_SV");

                entity.Property(e => e.ChieuDaiDatSv).HasColumnName("Chieu_dai_dat_SV");

                entity.Property(e => e.DauMayICr).HasColumnName("DauMay_i_Cr");

                entity.Property(e => e.DauMayISetup).HasColumnName("DauMay_i_setup");

                entity.Property(e => e.DauMayOCr).HasColumnName("DauMay_o_Cr");

                entity.Property(e => e.DauMayOSetup).HasColumnName("DauMay_o_setup");

                entity.Property(e => e.DunNgoaiMax).HasColumnName("DunNgoai_Max");

                entity.Property(e => e.DunNgoaiMin).HasColumnName("DunNgoai_Min");

                entity.Property(e => e.DunTrongMax).HasColumnName("DunTrong_Max");

                entity.Property(e => e.DunTrongMin).HasColumnName("DunTrong_Min");

                entity.Property(e => e.DuongkinhZumbachThucte).HasColumnName("Duongkinh_Zumbach_thucte");

                entity.Property(e => e.HinhAnh).HasMaxLength(200);

                entity.Property(e => e.HinhThuc).HasMaxLength(20);

                entity.Property(e => e.IdspthongSo).HasColumnName("IDSPThongSo");

                entity.Property(e => e.InnerCode1).HasColumnName("Inner_code_1");

                entity.Property(e => e.InnerCode2).HasColumnName("Inner_code_2");

                entity.Property(e => e.InnerCode3).HasColumnName("Inner_code_3");

                entity.Property(e => e.MaMicroscop).HasColumnName("Ma_Microscop");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(25)
                    .HasColumnName("MaSP");

                entity.Property(e => e.NhietBeNuoc).HasColumnName("Nhiet_BeNuoc");

                entity.Property(e => e.OuterCode1).HasColumnName("Outer_code_1");

                entity.Property(e => e.OuterCode2).HasColumnName("Outer_code_2");

                entity.Property(e => e.RunSys).HasColumnName("Run_sys");

                entity.Property(e => e.Size)
                    .HasMaxLength(50)
                    .HasColumnName("SIZE");

                entity.Property(e => e.TenCn)
                    .HasMaxLength(25)
                    .HasColumnName("TenCN");

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");

                entity.Property(e => e.ThoiGianHinhAnh)
                    .HasColumnType("datetime")
                    .HasColumnName("ThoiGian_HinhAnh");

                entity.Property(e => e.TocDoToiCut).HasColumnName("TocDoToi_Cut");

                entity.Property(e => e.TocDoTrucVitDunNgoai).HasColumnName("TocDoTrucVit_DunNgoai");

                entity.Property(e => e.TocDoTrucVitDunTrong).HasColumnName("TocDoTrucVit_DunTrong");

                entity.Property(e => e.Truc1ICr).HasColumnName("Truc1_i_Cr");

                entity.Property(e => e.Truc1ISetup).HasColumnName("Truc1_i_setup");

                entity.Property(e => e.Truc1OCr).HasColumnName("Truc1_o_Cr");

                entity.Property(e => e.Truc1OSetup).HasColumnName("Truc1_o_setup");

                entity.Property(e => e.Truc2ICr).HasColumnName("Truc2_i_Cr");

                entity.Property(e => e.Truc2ISetup).HasColumnName("Truc2_i_setup");

                entity.Property(e => e.Truc2OCr).HasColumnName("Truc2_o_Cr");

                entity.Property(e => e.Truc2OSetup).HasColumnName("Truc2_o_setup");

                entity.Property(e => e.TrucVitICr).HasColumnName("TrucVit_i_Cr");

                entity.Property(e => e.TrucVitISetup).HasColumnName("TrucVit_i_setup");

                entity.Property(e => e.TrucVitOCr).HasColumnName("TrucVit_o_Cr");

                entity.Property(e => e.TrucVitOSetup).HasColumnName("TrucVit_o_setup");

                entity.Property(e => e.ZumbachMax).HasColumnName("Zumbach_Max");

                entity.Property(e => e.ZumbachMin).HasColumnName("Zumbach_Min");
            });

            modelBuilder.Entity<Kehoachsanxuat>(entity =>
            {
                entity.ToTable("KEHOACHSANXUAT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("Ghi_chu");

                entity.Property(e => e.IdspthongSo).HasColumnName("IDSPThongSo");

                entity.Property(e => e.InnerCode1).HasColumnName("Inner_code_1");

                entity.Property(e => e.InnerCode2).HasColumnName("Inner_code_2");

                entity.Property(e => e.InnerCode3).HasColumnName("Inner_code_3");

                entity.Property(e => e.OuterCode1).HasColumnName("Outer_code_1");

                entity.Property(e => e.OuterCode2).HasColumnName("Outer_code_2");

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");
            });

            modelBuilder.Entity<LichsuDangnhap>(entity =>
            {
                entity.ToTable("LICHSU_DANGNHAP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdnhanSu).HasColumnName("IDNhanSu");

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");
            });

            modelBuilder.Entity<LichsuLoi>(entity =>
            {
                entity.ToTable("LICHSU_LOI");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NoiDung).HasMaxLength(250);

                entity.Property(e => e.ThoiGianBatdau)
                    .HasColumnType("datetime")
                    .HasColumnName("ThoiGian_batdau");

                entity.Property(e => e.ThoiGianKetthuc)
                    .HasColumnType("datetime")
                    .HasColumnName("ThoiGian_ketthuc");
            });

            modelBuilder.Entity<LoaiSanpham>(entity =>
            {
                entity.ToTable("LOAI_SANPHAM");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LoaiSp)
                    .HasMaxLength(100)
                    .HasColumnName("LoaiSP");

                entity.Property(e => e.NoiDung).HasMaxLength(100);
            });

            modelBuilder.Entity<Nhansu>(entity =>
            {
                entity.ToTable("NHANSU");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GioiTinh).HasMaxLength(10);

                entity.Property(e => e.IdPqns).HasColumnName("ID_PQNS");

                entity.Property(e => e.NgaySinh).HasColumnType("datetime");

                entity.Property(e => e.PassWord).HasMaxLength(50);

                entity.Property(e => e.Sdt)
                    .HasMaxLength(20)
                    .HasColumnName("SDT");

                entity.Property(e => e.Ten).HasMaxLength(100);
            });

            modelBuilder.Entity<NhietdosoidotFix>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NHIETDOSOIDOT_FIX");

                entity.Property(e => e.ViTri).HasMaxLength(500);
            });

            modelBuilder.Entity<Phanquyen>(entity =>
            {
                entity.HasKey(e => e.IdPq);

                entity.ToTable("PHANQUYEN");

                entity.Property(e => e.IdPq).HasColumnName("ID_PQ");

                entity.Property(e => e.ViTriPq)
                    .HasMaxLength(20)
                    .HasColumnName("ViTri_PQ");
            });

            modelBuilder.Entity<SanphamLoaiong>(entity =>
            {
                entity.ToTable("SANPHAM_LOAIONG");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Size)
                    .HasMaxLength(300)
                    .HasColumnName("SIZE");
            });

            modelBuilder.Entity<SanphamThongso>(entity =>
            {
                entity.ToTable("SANPHAM_THONGSO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AtmBeNuocNgoai).HasColumnName("ATM_BeNuoc_Ngoai");

                entity.Property(e => e.AtmBeNuocTrong).HasColumnName("ATM_BeNuoc_Trong");

                entity.Property(e => e.DunNgoaiMax).HasColumnName("DunNgoai_Max");

                entity.Property(e => e.DunNgoaiMin).HasColumnName("DunNgoai_Min");

                entity.Property(e => e.DunNgoaiSafety).HasColumnName("DunNgoai_Safety");

                entity.Property(e => e.DunNgoaiTieuChuan).HasColumnName("DunNgoai_TieuChuan");

                entity.Property(e => e.DunTrongMax).HasColumnName("DunTrong_Max");

                entity.Property(e => e.DunTrongMin).HasColumnName("DunTrong_Min");

                entity.Property(e => e.DunTrongSafety).HasColumnName("DunTrong_Safety");

                entity.Property(e => e.DunTrongTieuChuan).HasColumnName("DunTrong_TieuChuan");

                entity.Property(e => e.HinhAnh).HasMaxLength(250);

                entity.Property(e => e.IdnlInner).HasColumnName("IDNL_Inner");

                entity.Property(e => e.IdnlOuter).HasColumnName("IDNL_Outer");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(100)
                    .HasColumnName("MaSP");

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.Property(e => e.SlSanPham).HasColumnName("SL_SanPham");

                entity.Property(e => e.SpKhoiluongPh).HasColumnName("SP_KhoiluongPH");

                entity.Property(e => e.SpKhoiluongdaiPh).HasColumnName("SP_KhoiluongdaiPH");

                entity.Property(e => e.SpKichThuocChatGhtren).HasColumnName("SP_KichThuocChat_GHTren");

                entity.Property(e => e.SpKichThuocChatTieuChuan).HasColumnName("SP_KichThuocChat_TieuChuan");

                entity.Property(e => e.SpKichThuocLayMau).HasColumnName("SP_KichThuocLayMau");

                entity.Property(e => e.SpThoiGianLayMau).HasColumnName("SP_ThoiGianLayMau");

                entity.Property(e => e.TenCn)
                    .HasMaxLength(100)
                    .HasColumnName("TenCN");

                entity.Property(e => e.ThoiGianHinhAnh)
                    .HasColumnType("datetime")
                    .HasColumnName("ThoiGian_HinhAnh");

                entity.Property(e => e.ZumbachMax).HasColumnName("Zumbach_Max");

                entity.Property(e => e.ZumbachMin).HasColumnName("Zumbach_Min");

                entity.Property(e => e.ZumbachTieuChuan).HasColumnName("Zumbach_TieuChuan");
            });

            modelBuilder.Entity<SanphamThongsoKtchat>(entity =>
            {
                entity.ToTable("SANPHAM_THONGSO_KTCHAT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdspthongSo).HasColumnName("IDSPThongSo");

                entity.Property(e => e.SpKhoiluongPh).HasColumnName("SP_KhoiluongPH");

                entity.Property(e => e.SpKhoiluongdaiPh).HasColumnName("SP_KhoiluongdaiPH");
            });

            modelBuilder.Entity<SanphamThongsoMicrocop>(entity =>
            {
                entity.ToTable("SANPHAM_THONGSO_MICROCOP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdspthongSo).HasColumnName("IDSPThongSo");

                entity.Property(e => e.Item).HasMaxLength(500);
            });

            modelBuilder.Entity<SanphamThongsoNhietdosoidot>(entity =>
            {
                entity.ToTable("SANPHAM_THONGSO_NHIETDOSOIDOT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdspthongSo).HasColumnName("IDSPThongSo");

                entity.Property(e => e.ViTri).HasMaxLength(500);
            });

            modelBuilder.Entity<SanphamThongsoTooling>(entity =>
            {
                entity.ToTable("SANPHAM_THONGSO_TOOLING");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdspthongSo).HasColumnName("IDSPThongSo");

                entity.Property(e => e.KhuonKichThuoc1).HasColumnName("Khuon_KichThuoc1");

                entity.Property(e => e.KhuonKichThuoc2).HasColumnName("Khuon_KichThuoc2");

                entity.Property(e => e.KichThuocKhuon).HasMaxLength(50);

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.Type1).HasColumnName("Type_1");

                entity.Property(e => e.Type2).HasColumnName("Type_2");
            });

            modelBuilder.Entity<SanphamTieuchuanlab>(entity =>
            {
                entity.ToTable("SANPHAM_TIEUCHUANLAB");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CmbMsGioiHan).HasColumnName("CMB_MS_GioiHan");

                entity.Property(e => e.CmbMsMax).HasColumnName("CMB_MS_Max");

                entity.Property(e => e.CmbMsMin).HasColumnName("CMB_MS_Min");

                entity.Property(e => e.Cmbg).HasColumnName("CMBG");

                entity.Property(e => e.Cmbm).HasColumnName("CMBM");

                entity.Property(e => e.FmbMhMax).HasColumnName("FMB_MH_Max");

                entity.Property(e => e.FmbMhMin).HasColumnName("FMB_MH_Min");

                entity.Property(e => e.FmbMs14GioiHan).HasColumnName("FMB_MS14_GioiHan");

                entity.Property(e => e.FmbMs14Max).HasColumnName("FMB_MS14_Max");

                entity.Property(e => e.FmbMs14Min).HasColumnName("FMB_MS14_Min");

                entity.Property(e => e.Fmbm).HasColumnName("FMBM");

                entity.Property(e => e.Fmbr).HasColumnName("FMBR");

                entity.Property(e => e.GravityCmbGioiHan).HasColumnName("Gravity_CMB_GioiHan");

                entity.Property(e => e.GravityCmbMax).HasColumnName("Gravity_CMB_Max");

                entity.Property(e => e.GravityCmbMin).HasColumnName("Gravity_CMB_Min");

                entity.Property(e => e.KindofNumber).HasMaxLength(9);

                entity.Property(e => e.Mois).HasColumnName("MOIS");

                entity.Property(e => e.MoistureMax).HasColumnName("Moisture_Max");

                entity.Property(e => e.Tbel).HasColumnName("TBEL");

                entity.Property(e => e.TenlsiBelongMin).HasColumnName("Tenlsi_Belong_Min");

                entity.Property(e => e.TenlsiUtsMin).HasColumnName("Tenlsi_UTS_Min");

                entity.Property(e => e.TimeMax).HasColumnName("Time_Max");

                entity.Property(e => e.TimeMin).HasColumnName("Time_Min");

                entity.Property(e => e.TsMax).HasColumnName("TS_Max");

                entity.Property(e => e.TsMin).HasColumnName("TS_Min");

                entity.Property(e => e.Tuts).HasColumnName("TUTS");
            });

            modelBuilder.Entity<Thongbao>(entity =>
            {
                entity.ToTable("THONGBAO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdnhanVien).HasColumnName("IDNhanVien");

                entity.Property(e => e.TrangThaiLogin).HasColumnName("TrangThai_Login");
            });

            modelBuilder.Entity<Trangthai>(entity =>
            {
                entity.ToTable("TRANGTHAI");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.May).HasMaxLength(500);

                entity.Property(e => e.NoiDung).HasMaxLength(1000);

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");

                entity.Property(e => e.TrangThai1).HasColumnName("TrangThai");

                entity.Property(e => e.ViTri).HasMaxLength(500);
            });

            modelBuilder.Entity<TrichmauMicrocop>(entity =>
            {
                entity.ToTable("TRICHMAU_MICROCOP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.HinhAnh).HasMaxLength(500);

                entity.Property(e => e.IdkeHoach).HasColumnName("IDKeHoach");

                entity.Property(e => e.IdspthongSo).HasColumnName("IDSPThongSo");

                entity.Property(e => e.MrcChieuDayTong).HasColumnName("Mrc_ChieuDayTong");

                entity.Property(e => e.MrcDoDayLopNgoai).HasColumnName("Mrc_DoDayLopNgoai");

                entity.Property(e => e.MrcDoDayLopTrong).HasColumnName("Mrc_DoDayLopTrong");

                entity.Property(e => e.MrcDodaimau).HasColumnName("Mrc_Dodaimau");

                entity.Property(e => e.MrcDuongKinhNgoai).HasColumnName("Mrc_DuongKinhNgoai");

                entity.Property(e => e.MrcDuongKinhTrong).HasColumnName("Mrc_DuongKinhTrong");

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");
            });

            modelBuilder.Entity<VBaoCao>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_BaoCao");

                entity.Property(e => e.Ca).HasMaxLength(15);

                entity.Property(e => e.ChiềuDầyTổng).HasColumnName("Chiều dầy tổng");

                entity.Property(e => e.CmbI).HasColumnName("CMB_i");

                entity.Property(e => e.CmbO).HasColumnName("CMB_o");

                entity.Property(e => e.FmbI).HasColumnName("FMB_i");

                entity.Property(e => e.FmbO).HasColumnName("FMB_o");

                entity.Property(e => e.HinhAnh).HasMaxLength(500);

                entity.Property(e => e.IdspthongSo).HasColumnName("IDSPThongSo");

                entity.Property(e => e.KindofNumber).HasMaxLength(9);

                entity.Property(e => e.LoaiSp)
                    .HasMaxLength(100)
                    .HasColumnName("LoaiSP");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(100)
                    .HasColumnName("MaSP");

                entity.Property(e => e.ReometerI).HasColumnName("Reometer_i");

                entity.Property(e => e.ReometerO).HasColumnName("Reometer_o");

                entity.Property(e => e.SpKichThuocChatGhtren).HasColumnName("SP_KichThuocChat_GHTren");

                entity.Property(e => e.SpKichThuocLayMau).HasColumnName("SP_KichThuocLayMau");

                entity.Property(e => e.SpThoiGianLayMau).HasColumnName("SP_ThoiGianLayMau");

                entity.Property(e => e.TenCn)
                    .HasMaxLength(100)
                    .HasColumnName("TenCN");

                entity.Property(e => e.TenlsiI).HasColumnName("Tenlsi_i");

                entity.Property(e => e.TenlsiO).HasColumnName("Tenlsi_o");

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");

                entity.Property(e => e.ĐườngKínhNgoài).HasColumnName("Đường kính ngoài");

                entity.Property(e => e.ĐườngKínhTrong).HasColumnName("Đường kính trong");

                entity.Property(e => e.ĐộDầyLớpNgoài).HasColumnName("Độ dầy lớp ngoài");

                entity.Property(e => e.ĐộDầyLớpTrong).HasColumnName("Độ dầy lớp trong");
            });

            modelBuilder.Entity<VBaoCaoChanged>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_BaoCao_Changed");

                entity.Property(e => e.AtmBeNuocNgoai).HasColumnName("ATM_BeNuoc_Ngoai");

                entity.Property(e => e.AtmBeNuocTrong).HasColumnName("ATM_BeNuoc_Trong");

                entity.Property(e => e.AtmDauTrucNgoai).HasColumnName("ATM_DauTruc_Ngoai");

                entity.Property(e => e.AtmDauTrucTrong).HasColumnName("ATM_DauTruc_Trong");

                entity.Property(e => e.ChieuDaiBuSv).HasColumnName("Chieu_dai_bu_SV");

                entity.Property(e => e.ChieuDaiDatSv).HasColumnName("Chieu_dai_dat_SV");

                entity.Property(e => e.DauMayICr).HasColumnName("DauMay_i_Cr");

                entity.Property(e => e.DauMayISetup).HasColumnName("DauMay_i_setup");

                entity.Property(e => e.DauMayOCr).HasColumnName("DauMay_o_Cr");

                entity.Property(e => e.DauMayOSetup).HasColumnName("DauMay_o_setup");

                entity.Property(e => e.DunNgoaiMax).HasColumnName("DunNgoai_Max");

                entity.Property(e => e.DunNgoaiMin).HasColumnName("DunNgoai_Min");

                entity.Property(e => e.DunNgoaiSafety).HasColumnName("DunNgoai_Safety");

                entity.Property(e => e.DunNgoaiTieuChuan).HasColumnName("DunNgoai_TieuChuan");

                entity.Property(e => e.DunTrongMax).HasColumnName("DunTrong_Max");

                entity.Property(e => e.DunTrongMin).HasColumnName("DunTrong_Min");

                entity.Property(e => e.DunTrongSafety).HasColumnName("DunTrong_Safety");

                entity.Property(e => e.DunTrongTieuChuan).HasColumnName("DunTrong_TieuChuan");

                entity.Property(e => e.DuongkinhZumbachThucte).HasColumnName("Duongkinh_Zumbach_thucte");

                entity.Property(e => e.HinhAnh).HasMaxLength(250);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InnerCode1).HasColumnName("Inner_code_1");

                entity.Property(e => e.InnerCode2).HasColumnName("Inner_code_2");

                entity.Property(e => e.InnerCode3).HasColumnName("Inner_code_3");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(100)
                    .HasColumnName("MaSP");

                entity.Property(e => e.MrcChieuDayTong).HasColumnName("Mrc_ChieuDayTong");

                entity.Property(e => e.MrcDoDayLopNgoai).HasColumnName("Mrc_DoDayLopNgoai");

                entity.Property(e => e.MrcDoDayLopTrong).HasColumnName("Mrc_DoDayLopTrong");

                entity.Property(e => e.MrcDodaimau).HasColumnName("Mrc_Dodaimau");

                entity.Property(e => e.MrcDuongKinhNgoai).HasColumnName("Mrc_DuongKinhNgoai");

                entity.Property(e => e.MrcDuongKinhTrong).HasColumnName("Mrc_DuongKinhTrong");

                entity.Property(e => e.NhietBeNuoc).HasColumnName("Nhiet_BeNuoc");

                entity.Property(e => e.OuterCode1).HasColumnName("Outer_code_1");

                entity.Property(e => e.OuterCode2).HasColumnName("Outer_code_2");

                entity.Property(e => e.RunSys).HasColumnName("Run_sys");

                entity.Property(e => e.Size)
                    .HasMaxLength(300)
                    .HasColumnName("SIZE");

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.Property(e => e.SpKichThuocChatGhtren).HasColumnName("SP_KichThuocChat_GHTren");

                entity.Property(e => e.SpKichThuocChatTieuChuan).HasColumnName("SP_KichThuocChat_TieuChuan");

                entity.Property(e => e.SpKichThuocLayMau).HasColumnName("SP_KichThuocLayMau");

                entity.Property(e => e.SpThoiGianLayMau).HasColumnName("SP_ThoiGianLayMau");

                entity.Property(e => e.TenCn)
                    .HasMaxLength(100)
                    .HasColumnName("TenCN");

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");

                entity.Property(e => e.ThoiGianHinhAnh)
                    .HasColumnType("datetime")
                    .HasColumnName("ThoiGian_HinhAnh");

                entity.Property(e => e.TocDoToiCut).HasColumnName("TocDoToi_Cut");

                entity.Property(e => e.TocDoTrucVitDunNgoai).HasColumnName("TocDoTrucVit_DunNgoai");

                entity.Property(e => e.TocDoTrucVitDunTrong).HasColumnName("TocDoTrucVit_DunTrong");

                entity.Property(e => e.Truc1ICr).HasColumnName("Truc1_i_Cr");

                entity.Property(e => e.Truc1ISetup).HasColumnName("Truc1_i_setup");

                entity.Property(e => e.Truc1OCr).HasColumnName("Truc1_o_Cr");

                entity.Property(e => e.Truc1OSetup).HasColumnName("Truc1_o_setup");

                entity.Property(e => e.Truc2ICr).HasColumnName("Truc2_i_Cr");

                entity.Property(e => e.Truc2ISetup).HasColumnName("Truc2_i_setup");

                entity.Property(e => e.Truc2OCr).HasColumnName("Truc2_o_Cr");

                entity.Property(e => e.Truc2OSetup).HasColumnName("Truc2_o_setup");

                entity.Property(e => e.TrucVitICr).HasColumnName("TrucVit_i_Cr");

                entity.Property(e => e.TrucVitISetup).HasColumnName("TrucVit_i_setup");

                entity.Property(e => e.TrucVitOCr).HasColumnName("TrucVit_o_Cr");

                entity.Property(e => e.TrucVitOSetup).HasColumnName("TrucVit_o_setup");

                entity.Property(e => e.ZumbachMax).HasColumnName("Zumbach_Max");

                entity.Property(e => e.ZumbachMin).HasColumnName("Zumbach_Min");

                entity.Property(e => e.ZumbachTieuChuan).HasColumnName("Zumbach_TieuChuan");
            });

            modelBuilder.Entity<VChonSp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ChonSP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(100)
                    .HasColumnName("MaSP");

                entity.Property(e => e.Size)
                    .HasMaxLength(300)
                    .HasColumnName("SIZE");

                entity.Property(e => e.SpKichThuocChatTieuChuan).HasColumnName("SP_KichThuocChat_TieuChuan");

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<VDlthucTe>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_DLThucTe");

                entity.Property(e => e.AtmDauTrucNgoai).HasColumnName("ATM_DauTruc_Ngoai");

                entity.Property(e => e.AtmDauTrucTrong).HasColumnName("ATM_DauTruc_Trong");

                entity.Property(e => e.ChieuDaiBuSv).HasColumnName("Chieu_dai_bu_SV");

                entity.Property(e => e.ChieuDaiDatSv).HasColumnName("Chieu_dai_dat_SV");

                entity.Property(e => e.DuongkinhZumbachThucte).HasColumnName("Duongkinh_Zumbach_thucte");

                entity.Property(e => e.NhietBeNuoc).HasColumnName("Nhiet_BeNuoc");

                entity.Property(e => e.TDauMay1Pv).HasColumnName("T_DauMay1_PV");

                entity.Property(e => e.TDauMay2Pv).HasColumnName("T_DauMay2_PV");

                entity.Property(e => e.TTruc1Pv).HasColumnName("T_Truc1_PV");

                entity.Property(e => e.TTruc2Pv).HasColumnName("T_Truc2_PV");

                entity.Property(e => e.TTrucVit1Pv).HasColumnName("T_TrucVit1_PV");

                entity.Property(e => e.TTrucVit2Pv).HasColumnName("T_TrucVit2_PV");

                entity.Property(e => e.TTvTruc1Pv).HasColumnName("T_TV_Truc1_PV");

                entity.Property(e => e.TTvTruc2Pv).HasColumnName("T_TV_Truc2_PV");

                entity.Property(e => e.TocDoToiCut).HasColumnName("TocDoToi_Cut");

                entity.Property(e => e.TocDoTrucVitDunNgoai).HasColumnName("TocDoTrucVit_DunNgoai");

                entity.Property(e => e.TocDoTrucVitDunTrong).HasColumnName("TocDoTrucVit_DunTrong");
            });

            modelBuilder.Entity<VKeHoachSanXuat>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_KeHoachSanXuat");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("Ghi_chu");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdTssp).HasColumnName("ID_TSSP");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(100)
                    .HasColumnName("MaSP");

                entity.Property(e => e.Size)
                    .HasMaxLength(300)
                    .HasColumnName("SIZE");

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.Property(e => e.SpKichThuocChatTieuChuan).HasColumnName("SP_KichThuocChat_TieuChuan");

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");
            });

            modelBuilder.Entity<VRun>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Run");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idkh).HasColumnName("IDKH");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(100)
                    .HasColumnName("MaSP");

                entity.Property(e => e.Size)
                    .HasMaxLength(300)
                    .HasColumnName("SIZE");

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.Property(e => e.SpKichThuocChatTieuChuan).HasColumnName("SP_KichThuocChat_TieuChuan");

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

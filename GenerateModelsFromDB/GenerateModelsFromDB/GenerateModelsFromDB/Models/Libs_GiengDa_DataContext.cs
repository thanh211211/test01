using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace GenerateModelsFromDB.Models
{
    public partial class Libs_GiengDa_DataContext : DbContext
    {
        public Libs_GiengDa_DataContext()
        {
        }

        public Libs_GiengDa_DataContext(DbContextOptions<Libs_GiengDa_DataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<LstProduct> LstProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=isacc01.isolutions.com.vn;user id=libs;password=libsA01*;Connect Timeout=30;Database=Libs_GiengDa_Data");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<LstProduct>(entity =>
            {
                entity.ToTable("lstProducts");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CachXuat)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("cach_xuat");

                entity.Property(e => e.CoLo)
                    .HasColumnType("numeric(14, 3)")
                    .HasColumnName("co_lo");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CostType).HasColumnName("Cost_Type");

                entity.Property(e => e.Datetime0)
                    .HasColumnType("datetime")
                    .HasColumnName("datetime0");

                entity.Property(e => e.Datetime2)
                    .HasColumnType("datetime")
                    .HasColumnName("datetime2");

                entity.Property(e => e.Density)
                    .HasColumnType("numeric(13, 3)")
                    .HasColumnName("density");

                entity.Property(e => e.Depth)
                    .HasColumnType("numeric(13, 3)")
                    .HasColumnName("depth");

                entity.Property(e => e.Diameter)
                    .HasColumnType("numeric(13, 3)")
                    .HasColumnName("diameter");

                entity.Property(e => e.Dvtdensity)
                    .HasMaxLength(10)
                    .HasColumnName("dvtdensity")
                    .IsFixedLength(true);

                entity.Property(e => e.Dvtdepth)
                    .HasMaxLength(10)
                    .HasColumnName("dvtdepth")
                    .IsFixedLength(true);

                entity.Property(e => e.Dvtdiameter)
                    .HasMaxLength(10)
                    .HasColumnName("dvtdiameter")
                    .IsFixedLength(true);

                entity.Property(e => e.Dvtgauge)
                    .HasMaxLength(10)
                    .HasColumnName("dvtgauge")
                    .IsFixedLength(true);

                entity.Property(e => e.Dvtheight)
                    .HasMaxLength(10)
                    .HasColumnName("dvtheight")
                    .IsFixedLength(true);

                entity.Property(e => e.Dvtheight0)
                    .HasMaxLength(10)
                    .HasColumnName("dvtheight0")
                    .IsFixedLength(true);

                entity.Property(e => e.Dvtlength)
                    .HasMaxLength(10)
                    .HasColumnName("dvtlength")
                    .IsFixedLength(true);

                entity.Property(e => e.Dvtlength0)
                    .HasMaxLength(10)
                    .HasColumnName("dvtlength0")
                    .IsFixedLength(true);

                entity.Property(e => e.Dvtpacks)
                    .HasMaxLength(10)
                    .HasColumnName("dvtpacks")
                    .IsFixedLength(true);

                entity.Property(e => e.DvtslLoChuan)
                    .HasMaxLength(10)
                    .HasColumnName("dvtsl_lo_chuan")
                    .IsFixedLength(true);

                entity.Property(e => e.DvttgTh)
                    .HasMaxLength(10)
                    .HasColumnName("dvttg_th")
                    .IsFixedLength(true);

                entity.Property(e => e.Dvtvolume)
                    .HasMaxLength(10)
                    .HasColumnName("dvtvolume")
                    .IsFixedLength(true);

                entity.Property(e => e.Dvtvolume0)
                    .HasMaxLength(10)
                    .HasColumnName("dvtvolume0")
                    .IsFixedLength(true);

                entity.Property(e => e.Dvtweight)
                    .HasMaxLength(10)
                    .HasColumnName("dvtweight")
                    .IsFixedLength(true);

                entity.Property(e => e.Dvtweight0)
                    .HasMaxLength(10)
                    .HasColumnName("dvtweight0")
                    .IsFixedLength(true);

                entity.Property(e => e.Dvtweight2)
                    .HasMaxLength(10)
                    .HasColumnName("dvtweight2")
                    .IsFixedLength(true);

                entity.Property(e => e.Dvtwidth)
                    .HasMaxLength(10)
                    .HasColumnName("dvtwidth")
                    .IsFixedLength(true);

                entity.Property(e => e.Dvtwidth0)
                    .HasMaxLength(10)
                    .HasColumnName("dvtwidth0")
                    .IsFixedLength(true);

                entity.Property(e => e.Gauge)
                    .HasColumnType("numeric(13, 3)")
                    .HasColumnName("gauge");

                entity.Property(e => e.GcTd1)
                    .HasMaxLength(64)
                    .HasColumnName("gc_td1")
                    .IsFixedLength(true);

                entity.Property(e => e.GcTd2)
                    .HasMaxLength(64)
                    .HasColumnName("gc_td2")
                    .IsFixedLength(true);

                entity.Property(e => e.GcTd3)
                    .HasMaxLength(64)
                    .HasColumnName("gc_td3")
                    .IsFixedLength(true);

                entity.Property(e => e.GhiChu)
                    .HasColumnType("ntext")
                    .HasColumnName("ghi_chu");

                entity.Property(e => e.Group1)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Group2)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Group3)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Height)
                    .HasColumnType("numeric(13, 3)")
                    .HasColumnName("height");

                entity.Property(e => e.Height0)
                    .HasColumnType("numeric(13, 3)")
                    .HasColumnName("height0");

                entity.Property(e => e.InventoryYn).HasColumnName("Inventory_yn");

                entity.Property(e => e.KieuHd)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("kieu_hd");

                entity.Property(e => e.KieuLo)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("kieu_lo");

                entity.Property(e => e.KkYn).HasColumnName("kk_yn");

                entity.Property(e => e.Length)
                    .HasColumnType("numeric(13, 3)")
                    .HasColumnName("length");

                entity.Property(e => e.Length0)
                    .HasColumnType("numeric(13, 3)")
                    .HasColumnName("length0");

                entity.Property(e => e.LotYn).HasColumnName("Lot_yn");

                entity.Property(e => e.MaKh)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("ma_kh")
                    .IsFixedLength(true);

                entity.Property(e => e.MaKh0)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ma_kh0")
                    .IsFixedLength(true);

                entity.Property(e => e.MaKh2)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("ma_kh2")
                    .IsFixedLength(true);

                entity.Property(e => e.MaLoTrinh)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("ma_lo_trinh")
                    .IsFixedLength(true);

                entity.Property(e => e.MaTd1)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("ma_td1")
                    .IsFixedLength(true);

                entity.Property(e => e.MaTd2)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("ma_td2")
                    .IsFixedLength(true);

                entity.Property(e => e.MaTd3)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("ma_td3")
                    .IsFixedLength(true);

                entity.Property(e => e.MaThue)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ma_thue")
                    .IsFixedLength(true);

                entity.Property(e => e.MaThueNk)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ma_thue_nk")
                    .IsFixedLength(true);

                entity.Property(e => e.MaViTri)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ma_vi_tri")
                    .IsFixedLength(true);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.Property(e => e.Name2).HasMaxLength(128);

                entity.Property(e => e.NgayMua)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ngay_mua");

                entity.Property(e => e.NgayTd1)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ngay_td1");

                entity.Property(e => e.NgayTd2)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ngay_td2");

                entity.Property(e => e.NgayTd3)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ngay_td3");

                entity.Property(e => e.NuocSx)
                    .HasMaxLength(24)
                    .HasColumnName("nuoc_sx")
                    .IsFixedLength(true);

                entity.Property(e => e.OngBa)
                    .HasMaxLength(24)
                    .HasColumnName("ong_ba")
                    .IsFixedLength(true);

                entity.Property(e => e.PackSize)
                    .HasMaxLength(16)
                    .HasColumnName("pack_size")
                    .IsFixedLength(true);

                entity.Property(e => e.Packs)
                    .HasColumnType("numeric(13, 3)")
                    .HasColumnName("packs");

                entity.Property(e => e.S1)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("s1")
                    .IsFixedLength(true);

                entity.Property(e => e.S2)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("s2")
                    .IsFixedLength(true);

                entity.Property(e => e.S3)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("s3")
                    .IsFixedLength(true);

                entity.Property(e => e.S4)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("s4");

                entity.Property(e => e.S5)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("s5");

                entity.Property(e => e.S6)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("s6");

                entity.Property(e => e.S7)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("s7");

                entity.Property(e => e.S8)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("s8");

                entity.Property(e => e.S9)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("s9");

                entity.Property(e => e.SlDatKt)
                    .HasColumnType("numeric(14, 3)")
                    .HasColumnName("sl_dat_kt");

                entity.Property(e => e.SlLoChuan)
                    .HasColumnType("numeric(13, 3)")
                    .HasColumnName("sl_lo_chuan");

                entity.Property(e => e.SlMax)
                    .HasColumnType("numeric(12, 3)")
                    .HasColumnName("sl_max");

                entity.Property(e => e.SlMin)
                    .HasColumnType("numeric(12, 3)")
                    .HasColumnName("sl_min");

                entity.Property(e => e.SlTd1)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("sl_td1");

                entity.Property(e => e.SlTd2)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("sl_td2");

                entity.Property(e => e.SlTd3)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("sl_td3");

                entity.Property(e => e.SoNgayBh)
                    .HasColumnType("numeric(5, 0)")
                    .HasColumnName("so_ngay_bh");

                entity.Property(e => e.SoNgayDh)
                    .HasColumnType("numeric(3, 0)")
                    .HasColumnName("so_ngay_dh");

                entity.Property(e => e.SoNgaySp)
                    .HasColumnType("numeric(5, 0)")
                    .HasColumnName("so_ngay_sp");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .IsFixedLength(true);

                entity.Property(e => e.SuaTkVt).HasColumnName("sua_tk_vt");

                entity.Property(e => e.TaoLo).HasColumnName("tao_lo");

                entity.Property(e => e.TgTh)
                    .HasColumnType("numeric(3, 0)")
                    .HasColumnName("tg_th");

                entity.Property(e => e.TkCk)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("tk_ck")
                    .IsFixedLength(true);

                entity.Property(e => e.TkClVt)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("tk_cl_vt")
                    .IsFixedLength(true);

                entity.Property(e => e.TkCpbh)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("tk_cpbh")
                    .IsFixedLength(true);

                entity.Property(e => e.TkDl)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("tk_dl")
                    .IsFixedLength(true);

                entity.Property(e => e.TkDt)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("tk_dt")
                    .IsFixedLength(true);

                entity.Property(e => e.TkDtnb)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("tk_dtnb")
                    .IsFixedLength(true);

                entity.Property(e => e.TkGv)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("tk_gv")
                    .IsFixedLength(true);

                entity.Property(e => e.TkSpdd)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("tk_spdd")
                    .IsFixedLength(true);

                entity.Property(e => e.TkTl)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("tk_tl")
                    .IsFixedLength(true);

                entity.Property(e => e.TkVt)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("tk_vt")
                    .IsFixedLength(true);

                entity.Property(e => e.TonAt)
                    .HasColumnType("numeric(14, 3)")
                    .HasColumnName("ton_at");

                entity.Property(e => e.Type)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Uom)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.UserId0)
                    .HasColumnType("numeric(3, 0)")
                    .HasColumnName("user_id0");

                entity.Property(e => e.UserId2)
                    .HasColumnType("numeric(3, 0)")
                    .HasColumnName("user_id2");

                entity.Property(e => e.Volume)
                    .HasColumnType("numeric(13, 3)")
                    .HasColumnName("volume");

                entity.Property(e => e.Volume0)
                    .HasColumnType("numeric(13, 3)")
                    .HasColumnName("volume0");

                entity.Property(e => e.VungHd)
                    .HasColumnType("numeric(3, 0)")
                    .HasColumnName("vung_hd");

                entity.Property(e => e.Weight)
                    .HasColumnType("numeric(13, 3)")
                    .HasColumnName("weight");

                entity.Property(e => e.Weight0)
                    .HasColumnType("numeric(13, 3)")
                    .HasColumnName("weight0");

                entity.Property(e => e.Weight2)
                    .HasColumnType("numeric(13, 3)")
                    .HasColumnName("weight2");

                entity.Property(e => e.Width)
                    .HasColumnType("numeric(13, 3)")
                    .HasColumnName("width");

                entity.Property(e => e.Width0)
                    .HasColumnType("numeric(13, 3)")
                    .HasColumnName("width0");

                entity.Property(e => e.Xcolor)
                    .HasMaxLength(16)
                    .HasColumnName("xcolor")
                    .IsFixedLength(true);

                entity.Property(e => e.Xsize)
                    .HasMaxLength(16)
                    .HasColumnName("xsize")
                    .IsFixedLength(true);

                entity.Property(e => e.Xstyle)
                    .HasMaxLength(16)
                    .HasColumnName("xstyle")
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

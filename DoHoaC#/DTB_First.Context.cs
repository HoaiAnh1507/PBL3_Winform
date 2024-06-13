using System.Data.Entity;

namespace DoHoaC_
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    public partial class PBL3_CSDLEntities : DbContext
    {
        public PBL3_CSDLEntities() : base("name=PBL3_CSDLEntities")
        {
        }

        public virtual DbSet<DONHANG> DONHANGs { get; set; }
        public virtual DbSet<DONHANGCHITIET> DONHANGCHITIETs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<SANPHAM> SANPHAMs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }
    }

    public class SANPHAMs
    {
        public string ID_SP { get; set; }
        public string TEN_SAN_PHAM { get; set; }
        public string ID_NCC { get; set; }
        public string TEN_DANH_MUC { get; set; }
        public string DON_VI { get; set; }
        public string DON_GIA { get; set; }
        public string SO_LUONG_CON_LAI { get; set; }
    }

    public class NHACUNGCAPs
    {
        public string ID_NCC { get; set; }
        public string TEN_NHA_CUNG_CAP { get; set; }
        public string DIACHI { get; set; }
        public string SDT { get; set; }
        public string INFOR { get; set; }
    }
    public class KHACHHANGs
    {
        public string ID_KH { get; set; }
        public string TEN_KHACH_HANG { get; set; }
        public string DIACHI { get; set; }
        public string SDT { get; set; }
        public string INFOR { get; set; }
    }
    public class DONHANGs
    {
        public string ID_DH { get; set; }
        public string ID_NV { get; set; }
        public string TEN_NHAN_VIEN { get; set; }
        public string ID_KH { get; set; }
        public string TEN_KHACH_HANG { get; set; }
        public string ID_SP { get; set; }
        public DateTime NGAY_MUA { get; set; }
        public string TEN_SAN_PHAM { get; set; }
        public string DONVI { get; set; }
        public int DONGIA { get; set; }
        public int SOLUONG { get; set; }
        public int THANHTIEN { get; set; }
        public int TONGTHANHTOAN { get; set; }
        public bool TRANG_THAI { get; set; }
    }
    public class NHANVIENs
    {
        public string ID_NV { get; set; }
        public string TEN_NHAN_VIEN { get; set; }
        public string DIACHI { get; set; }
        public string SDT { get; set; }
        public string CHUCVU { get; set; }
    }
    public class TAIKHOANs
    {
        private string tenTaiKhoan;
        public string TenTaiKhoan
        {
            get => tenTaiKhoan;
            set => tenTaiKhoan = value;
        }
        private string matKhau;
        public string MatKhau
        {
            get => matKhau;
            set => matKhau = value;
        }
        private bool loaiTaiKhoan;
        public bool LoaiTaiKhoan
        {
            get => loaiTaiKhoan;
            set => loaiTaiKhoan = value;
        }
        public TAIKHOANs(string tentaikhoan, string matkhau, bool loaiTaiKhoan)
        {
            this.TenTaiKhoan = tentaikhoan;
            this.MatKhau = matkhau;
            this.LoaiTaiKhoan = loaiTaiKhoan;
        }
    }
}

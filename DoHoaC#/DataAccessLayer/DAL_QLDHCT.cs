using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace DoHoaC_.DataAccessLayer
{
    public class DAL_QLDHCT
    {
        private PBL3_CSDLEntities db;

        public DAL_QLDHCT()
        {
            db = new PBL3_CSDLEntities();
        }

        public List<DONHANGCHITIET> GetDHCT(int iddh)
        {
            return db.DONHANGCHITIETs.Where(dhct => dhct.ID_DH == iddh).ToList();
        }

        public void AddSP_DHCT(DONHANGCHITIET dhct)
        {
            db.DONHANGCHITIETs.Add(dhct);
            db.SaveChanges();
        }

        public void UpdateSoLuong(int ID_DH, int ID_SP, int soLuong)
        {
            var dhct = db.DONHANGCHITIETs.SingleOrDefault(d => d.ID_DH == ID_DH && d.ID_SP == ID_SP);
            if (dhct != null)
            {
                dhct.SO_LUONG += soLuong;
                dhct.THANH_TIEN = dhct.DON_GIA * dhct.SO_LUONG;
                db.SaveChanges();
            }
        }

        public void XoaSP_DHCT(int ID_SP, int ID_DH)
        {
            var dhct = db.DONHANGCHITIETs.SingleOrDefault(d => d.ID_SP == ID_SP && d.ID_DH == ID_DH);
            if (dhct != null)
            {
                db.DONHANGCHITIETs.Remove(dhct);
                db.SaveChanges();
            }
        }

        public bool KiemTraSPTonTai(int ID_DH, int ID_SP)
        {
            return db.DONHANGCHITIETs.Any(d => d.ID_SP == ID_SP && d.ID_DH == ID_DH);
        }

        public List<SANPHAM> GetSanPhamByDM(string dm)
        {
            // Logic to get SanPham by danh mục
            return db.SANPHAMs.Where(sp => sp.TEN_DANH_MUC == dm).ToList();
        }

        public List<SANPHAM> GetSanPhamIDByTen(string tenSP)
        {
            // Logic to get SanPham ID by tenSP
            return db.SANPHAMs.Where(sp => sp.TEN_SAN_PHAM == tenSP).ToList();
        }

        public List<NHANVIEN> GetNhanVienIDByTen(string tenNV)
        {
            // Logic to get NhanVien ID by tenNV
            return db.NHANVIENs.Where(nv => nv.TEN_NHAN_VIEN == tenNV).ToList();
        }

        public List<KHACHHANG> GetKhachHangIDByTen(string tenKH)
        {
            // Logic to get KhachHang ID by tenKH
            return db.KHACHHANGs.Where(kh => kh.TEN_KHACH_HANG == tenKH).ToList();
        }

    }
}

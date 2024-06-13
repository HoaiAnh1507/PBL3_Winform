using System;
using System.Collections.Generic;
using System.Linq;
using DoHoaC_.DataAccessLayer;

namespace DoHoaC_.BusinessLogicLayer
{
    public class BLL_QLDHCT
    {
        private DAL_QLDHCT dal;

        public BLL_QLDHCT()
        {
            dal = new DAL_QLDHCT();
        }

        public List<DONHANGCHITIET> GetDHCT(int iddh)
        {
            return dal.GetDHCT(iddh);
        }

        public void AddSP_DHCT(DONHANGCHITIET dhct)
        {
            if (KiemTraSoLuongSPTrongKho(dhct.ID_DH, dhct.ID_SP, dhct.SO_LUONG ?? 0))
            {
                dal.AddSP_DHCT(dhct);
            }
            else
            {
                throw new Exception("Vượt quá số lượng trong kho");
            }
        }

        public void UpdateSoLuong(int ID_DH, int ID_SP, int soLuong)
        {
            if (KiemTraSoLuongSPTrongKho(ID_DH, ID_SP, soLuong))
            {
                dal.UpdateSoLuong(ID_DH, ID_SP, soLuong);
            }
            else
            {
                throw new Exception("Vượt quá số lượng trong kho");
            }
        }

        public void XoaSP_DHCT(int ID_SP, int ID_DH)
        {
            dal.XoaSP_DHCT(ID_SP, ID_DH);
        }

        public bool KiemTraSPTonTai(int ID_DH, int ID_SP)
        {
            return dal.KiemTraSPTonTai(ID_DH, ID_SP);
        }

        public List<SANPHAM> ShowComboBoxSanPham(string dm)
        {
            // Logic to get SanPham based on dm
            // ...
            return dal.GetSanPhamByDM(dm);
        }

        public List<SANPHAM> ShowComBoBoxIDSP(string tenSP)
        {
            // Logic to get SanPham ID based on tenSP
            // ...
            return dal.GetSanPhamIDByTen(tenSP);
        }

        public List<NHANVIEN> ShowComboBoxIDNV(string tenNV)
        {
            // Logic to get NhanVien ID based on tenNV
            // ...
            return dal.GetNhanVienIDByTen(tenNV);
        }

        public List<KHACHHANG> ShowComboBoxIDKH(string tenKH)
        {
            // Logic to get KhachHang ID based on tenKH
            // ...
            return dal.GetKhachHangIDByTen(tenKH);
        }


        private bool KiemTraSoLuongSPTrongKho(int ID_DH, int ID_SP, int sl)
        {
            // Logic kiểm tra số lượng sản phẩm trong kho
            // ...
            return true; // Hoặc false tùy vào kết quả kiểm tra
        }
    }
}

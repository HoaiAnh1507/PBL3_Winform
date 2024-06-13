using DoHoaC_.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DoHoaC_
{
    public class BLL_QLNV
    {
        private DAL_QLNV _dal;

        public BLL_QLNV()
        {
            _dal = new DAL_QLNV();
        }

        public static BLL_QLNV Instance { get; } = new BLL_QLNV();

        public void GetAllNhanVien(DataGridView dgv)
        {
            dgv.DataSource = _dal.GetAllNhanVien();
        }

        public void AddNhanVien(NHANVIEN nv)
        {
            if (nv == null)
                throw new ArgumentNullException(nameof(nv), "Thông tin Nhân viên không được để trống.");

            if (string.IsNullOrWhiteSpace(nv.TEN_NHAN_VIEN))
                throw new ArgumentException("Tên Nhân viên không được để trống.", nameof(nv.TEN_NHAN_VIEN));
            if (_dal.IsNhanVienExists(nv.TEN_NHAN_VIEN, nv.DIACHI, nv.SDT))
            {
                throw new InvalidOperationException("Nhân viên đã tồn tại trong cơ sở dữ liệu.");
            }
            _dal.AddNhanVien(nv);
        }

        public void UpdateNhanVien(int ID_NV, NHANVIEN nv)
        {
            if (nv == null)
                throw new ArgumentNullException(nameof(nv), "Thông tin Nhân viên không được để trống.");

            if (string.IsNullOrWhiteSpace(nv.TEN_NHAN_VIEN))
                throw new ArgumentException("Tên Nhân viên không được để trống.", nameof(nv.TEN_NHAN_VIEN));

            _dal.UpdateNhanVien(ID_NV, nv);
        }

        public void DeleteNhanVien(int ID_NV)
        {
            _dal.DeleteNhanVien(ID_NV);
        }

        public IEnumerable<NHANVIEN> SearchNhanVien(string keyword)
        {
            return _dal.SearchNhanVien(keyword);
        }
    }
}

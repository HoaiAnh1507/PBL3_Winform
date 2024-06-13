using DoHoaC_.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DoHoaC_
{
    public class BLL_QLNCC
    {
        private DAL_QLNCC _dal;

        public BLL_QLNCC()
        {
            _dal = new DAL_QLNCC();
        }
        public static BLL_QLNCC Instance { get; } = new BLL_QLNCC();

        public void GetAllNCC(DataGridView dgv)
        {
            dgv.DataSource = _dal.GetAllNHACUNGCAP();
        }

        public void AddNCC(NHACUNGCAP ncc)
        {
            if (ncc == null)
                throw new ArgumentNullException(nameof(ncc), "Thông tin Nhà Cung Cấp không được để trống.");

            if (string.IsNullOrWhiteSpace(ncc.TEN_NHA_CUNG_CAP))
                throw new ArgumentException("Tên Nhà Cung Cấp không được để trống.", nameof(ncc.TEN_NHA_CUNG_CAP));
            if (_dal.IsNCCExists(ncc.TEN_NHA_CUNG_CAP, ncc.DIACHI, ncc.SDT))
            {
                throw new InvalidOperationException("Nhà Cung Cấp đã tồn tại trong cơ sở dữ liệu.");
            }
            _dal.AddNCC(ncc);
        }

        public void UpdateNCC(int ID_NCC, NHACUNGCAP ncc)
        {
            if (ncc == null)
                throw new ArgumentNullException(nameof(ncc), "Thông tin Nhà Cung Cấp không được để trống.");

            if (string.IsNullOrWhiteSpace(ncc.TEN_NHA_CUNG_CAP))
                throw new ArgumentException("Tên Nhà Cung Cấp không được để trống.", nameof(ncc.TEN_NHA_CUNG_CAP));

            _dal.UpdateNCC(ID_NCC, ncc);
        }

        public void DeleteNCC(int ID_NCC)
        {
            _dal.DeleteNCC(ID_NCC);
        }

        public IEnumerable<NHACUNGCAP> SearchNCC(string keyword)
        {
            return _dal.SearchNCC(keyword);
        }
    }
}

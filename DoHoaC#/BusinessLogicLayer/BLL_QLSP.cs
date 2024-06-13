using System;
using System.Collections.Generic;
using System.Data;

namespace DoHoaC_
{
    public class BLL_QLSP
    {
        //private DAL_QLSP _dal;

        //public BLL_QLSP()
        //{
        //    _dal = new DAL_QLSP();
        //}

        //public static BLL_QLSP Instance { get; } = new BLL_QLSP();

        //public IEnumerable<SANPHAM> GetAllSanPham()
        //{
        //    return _dal.GetAllSanPham();
        //}

        //public void AddSP(SANPHAM sp)
        //{
        //    if (sp == null)
        //        throw new ArgumentNullException(nameof(sp), "Thông tin Sản Phẩm không được để trống.");

        //    if (string.IsNullOrWhiteSpace(sp.TEN_SAN_PHAM))
        //        throw new ArgumentException("Tên Sản Phẩm không được để trống.", nameof(sp.TEN_SAN_PHAM));

        //    if (_dal.IsSPExists(sp.TEN_SAN_PHAM))
        //    {
        //        throw new InvalidOperationException("Sản Phẩm đã tồn tại trong cơ sở dữ liệu.");
        //    }

        //    _dal.AddSP(sp);
        //}

        //public void UpdateSP(SANPHAM sp)
        //{
        //    if (sp == null)
        //        throw new ArgumentNullException(nameof(sp), "Thông tin Sản Phẩm không được để trống.");

        //    if (string.IsNullOrWhiteSpace(sp.TEN_SAN_PHAM))
        //        throw new ArgumentException("Tên Sản Phẩm không được để trống.");

        //    _dal.UpdateSP(sp);
        //}

        //public void DeleteSP(int id)
        //{
        //    _dal.DeleteSP(id);
        //}

        //public IEnumerable<SANPHAM> SearchSP(string keyword)
        //{
        //    return _dal.SearchSP(keyword);
        //}

        //public IEnumerable<string> GetUniqueDanhMuc()
        //{
        //    return _dal.GetUniqueDanhMuc();
        //}

        //public IEnumerable<string> GetIDNCC()
        //{
        //    return _dal.GetIDNCC();
        //}

        //public void UpdateSLSP(int id, int quantitySold)
        //{
        //    _dal.UpdateSLSP(id, quantitySold);
        //}
    }
}

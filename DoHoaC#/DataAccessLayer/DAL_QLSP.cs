using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;

namespace DoHoaC_
{
    public class DAL_QLSP
    {
        // PBL3_CSDLEntities _context;

        //public DAL_QLSP()
        //{
        //    _context = new PBL3_CSDLEntities();
        //}

        //public IEnumerable<SANPHAM> GetAllSanPham()
        //{
        //    return _context.SANPHAMs.ToList();
        //}

        //public void AddSP(SANPHAM sp)
        //{
        //    _context.SANPHAMs.Add(sp);
        //    _context.SaveChanges();
        //}

        //public void UpdateSP(SANPHAM sp)
        //{
        //    _context.Entry(sp).State = EntityState.Modified;
        //    _context.SaveChanges();
        //}

        //public void DeleteSP(int id)
        //{
        //    var sp = _context.SANPHAMs.Find(id);
        //    if (sp != null)
        //    {
        //        _context.SANPHAMs.Remove(sp);
        //        _context.SaveChanges();
        //    }
        //}

        //public IEnumerable<SANPHAM> SearchSP(string keyword)
        //{
        //    return _context.SANPHAMs.Where(sp => sp.TEN_SAN_PHAM.Contains(keyword) ||
        //                                        sp.ID_NCC.Contains(keyword) ||
        //                                        sp.TEN_DANH_MUC.Contains(keyword)).ToList();
        //}

        //public IEnumerable<string> GetUniqueDanhMuc()
        //{
        //    return _context.SANPHAMs.Select(sp => sp.TEN_DANH_MUC).Distinct().ToList();
        //}

        //public IEnumerable<string> GetIDNCC()
        //{
        //    return _context.NHACUNGCAPs.Select(ncc => ncc.ID_NCC).ToList();
        //}

        //public void UpdateSLSP(int id, int quantitySold)
        //{
        //    var sp = _context.SANPHAMs.Find(id);
        //    if (sp != null)
        //    {
        //        sp.SO_LUONG_CON_LAI -= quantitySold;
        //        _context.SaveChanges();
        //    }
        //}

        //public bool IsSPExists(string tenSP)
        //{
        //    return _context.SANPHAMs.Any(sp => sp.TEN_SAN_PHAM == tenSP);
        //}
    }
}

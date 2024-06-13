using System;
using System.Collections.Generic;
using DoHoaC_.DataAccessLayer;

namespace DoHoaC_.BusinessLogicLayer
{
    public class BLL_QLDH
    {
        private static BLL_QLDH _Instance;
        public static BLL_QLDH Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_QLDH();
                return _Instance;
            }
            private set { }
        }

        public List<DONHANG> GetDH()
        {
            return DAL_QLDH.Instance.GetDH();
        }

        public string GetKHNV(int iddh, string ten)
        {
            return DAL_QLDH.Instance.GetKHNV(iddh, ten);
        }

        public void AddDH(DONHANG dh)
        {
            DAL_QLDH.Instance.AddDH(dh);
        }

        public void UpdateDH(DONHANG dh)
        {
            DAL_QLDH.Instance.UpdateDH(dh);
        }

        public void DeleteDH(int id_dh)
        {
            DAL_QLDH.Instance.DeleteDH(id_dh);
        }

        public List<DONHANG> SearchDH(string keyword)
        {
            return DAL_QLDH.Instance.SearchDH(keyword);
        }

        public bool KiemTraDHTonTai(int ID_DH)
        {
            return DAL_QLDH.Instance.KiemTraDHTonTai(ID_DH);
        }
    }
}

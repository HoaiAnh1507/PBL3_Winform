using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoHoaC_
{
    public class DTB_TaiKhoan
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
        public DTB_TaiKhoan(string tentaikhoan, string matkhau, bool loaiTaiKhoan)
        {
            this.TenTaiKhoan = tentaikhoan;
            this.MatKhau = matkhau;
            this.LoaiTaiKhoan = loaiTaiKhoan;
        }
    }
}
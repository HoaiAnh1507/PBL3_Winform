using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoHoaC_
{
    public partial class FormHeThong : Form
    {
        public bool isExit = true;
        public FormHeThong()
        {
            InitializeComponent();
        }
        private void BThethong_Click(object sender, EventArgs e)
        {
            heThong1.Show();

            sanPham1.Hide();
            khachHang1.Hide();
            ncc1.Hide();
            nhanVien1.Hide();
            donHang1.Hide();
            //danhMucHinhAnh1.Hide();

            BThethong.BackColor = Color.AliceBlue;

            BTSanPham.BackColor = Color.FromArgb(31, 53, 66);
            BTSanPham.ForeColor = Color.Black;
            BTkhachhang.BackColor = Color.FromArgb(31, 53, 66);
            BTncc.BackColor = Color.FromArgb(31, 53, 66);
            BTnhanvien.BackColor = Color.FromArgb(31, 53, 66);
            BTdonhang.BackColor = Color.FromArgb(31, 53, 66);
            thongKe1.Hide();
            BTthongke.BackColor = Color.FromArgb(31, 53, 66);
        }

        private void BTSanPham_Click(object sender, EventArgs e)
        {
            sanPham1.Show();

            heThong1.Hide();
            khachHang1.Hide();
            ncc1.Hide();
            nhanVien1.Hide();
            donHang1.Hide();
            thongKe1.Hide();
            //danhMucHinhAnh1.Hide();

            BTSanPham.BackColor = Color.AliceBlue;

            BThethong.BackColor = Color.FromArgb(31, 53, 66);
            BTkhachhang.BackColor = Color.FromArgb(31, 53, 66);
            BTncc.BackColor = Color.FromArgb(31, 53, 66);
            BTnhanvien.BackColor = Color.FromArgb(31, 53, 66);
            BTdonhang.BackColor = Color.FromArgb(31, 53, 66);
            
            BTthongke.BackColor = Color.FromArgb(31, 53, 66);
        }
        private void BTdonhang_Click(object sender, EventArgs e)
        {
            heThong1.Hide();
            sanPham1.Hide();
            khachHang1.Hide();
            ncc1.Hide();
            nhanVien1.Hide();
            donHang1.Show();
            //danhMucHinhAnh1.Hide();

            BTSanPham.BackColor = Color.FromArgb(31, 53, 66);

            BThethong.BackColor = Color.FromArgb(31, 53, 66);
            BTkhachhang.BackColor = Color.FromArgb(31, 53, 66);
            BTncc.BackColor = Color.FromArgb(31, 53, 66);
            BTnhanvien.BackColor = Color.FromArgb(31, 53, 66);
            BTdonhang.BackColor = Color.AliceBlue;
            thongKe1.Hide();
            BTthongke.BackColor = Color.FromArgb(31, 53, 66);
        }

        private void BTkhachhang_Click(object sender, EventArgs e)
        {
            heThong1.Hide();
            sanPham1.Hide();
            khachHang1.Show();
            ncc1.Hide();
            nhanVien1.Hide();
            donHang1.Hide();
            //danhMucHinhAnh1.Hide();
            BTSanPham.BackColor = Color.FromArgb(31, 53, 66);

            BThethong.BackColor = Color.FromArgb(31, 53, 66);
            BTkhachhang.BackColor = Color.AliceBlue;
            BTncc.BackColor = Color.FromArgb(31, 53, 66);
            BTnhanvien.BackColor = Color.FromArgb(31, 53, 66);
            BTdonhang.BackColor = Color.FromArgb(31, 53, 66);
            thongKe1.Hide();
            BTthongke.BackColor = Color.FromArgb(31, 53, 66);

        }

        private void BTncc_Click(object sender, EventArgs e)
        {
            heThong1.Hide();
            sanPham1.Hide();
            khachHang1.Hide();
            ncc1.Show();
            nhanVien1.Hide();
            donHang1.Hide();
            thongKe1.Hide();
            //danhMucHinhAnh1.Hide();
            BTSanPham.BackColor = Color.FromArgb(31, 53, 66);
            BThethong.BackColor = Color.FromArgb(31, 53, 66);
            BTkhachhang.BackColor = Color.FromArgb(31, 53, 66);
            BTncc.BackColor = Color.AliceBlue;
            BTnhanvien.BackColor = Color.FromArgb(31, 53, 66);
            BTdonhang.BackColor = Color.FromArgb(31, 53, 66);
            BTthongke.BackColor = Color.FromArgb(31, 53, 66);
        }

        private void BTnhanvien_Click(object sender, EventArgs e)
        {
            heThong1.Hide();
            sanPham1.Hide();
            khachHang1.Hide();
            ncc1.Hide();
            nhanVien1.Show();
            donHang1.Hide();
            thongKe1.Hide();
            //danhMucHinhAnh1.Hide();

            BTSanPham.BackColor = Color.FromArgb(31, 53, 66);
            BThethong.BackColor = Color.FromArgb(31, 53, 66);
            BTkhachhang.BackColor = Color.FromArgb(31, 53, 66);
            BTncc.BackColor = Color.FromArgb(31, 53, 66);
            BTnhanvien.BackColor = Color.AliceBlue;
            BTdonhang.BackColor = Color.FromArgb(31, 53, 66);
            BTthongke.BackColor = Color.FromArgb(31, 53, 66);
        }
        void PhanQuyen()
        {
            if (Const.LoaiTaiKhoan == false)
            {
                BTnhanvien.Enabled = false;
                BTncc.Enabled = false;
            }

        }

        private void FormHeThong_Load(object sender, EventArgs e)
        {
            PhanQuyen();
            heThong1.Show();
            sanPham1.Hide();
            khachHang1.Hide();
            ncc1.Hide();
            nhanVien1.Hide();
            donHang1.Hide();
            thongKe1.Hide();
            //danhMucHinhAnh1.Hide();

            BTSanPham.BackColor = Color.FromArgb(31, 53, 66);
            BThethong.BackColor = Color.AliceBlue;
            BTkhachhang.BackColor = Color.FromArgb(31, 53, 66);
            BTncc.BackColor = Color.FromArgb(31, 53, 66);
            BTnhanvien.BackColor = Color.FromArgb(31, 53, 66);
            BTdonhang.BackColor = Color.FromArgb(31, 53, 66);

            BTthongke.BackColor = Color.FromArgb(31, 53, 66);
        }


        private void FormHeThong_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit == true)
            {
                if (MessageBox.Show("Bạn muốn thoát chương trình không?", "Cảnh báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }

        }
        private void FormHeThong_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit == true)
            {
                Application.Exit();
            }

        }

        private void BTthongke_Click(object sender, EventArgs e)
        {
            heThong1.Hide();
            sanPham1.Hide();
            khachHang1.Hide();
            ncc1.Hide();
            nhanVien1.Hide();
            donHang1.Hide();
            thongKe1.Show();
            BTthongke.BackColor = Color.AliceBlue;
            //danhMucHinhAnh1.Hide();
            BTSanPham.BackColor = Color.FromArgb(31, 53, 66);

            BThethong.BackColor = Color.FromArgb(31, 53, 66);
            BTkhachhang.BackColor = Color.FromArgb(31, 53, 66);
            BTncc.BackColor = Color.FromArgb(31, 53, 66);
            BTnhanvien.BackColor = Color.FromArgb(31, 53, 66);
            BTdonhang.BackColor = Color.FromArgb(31, 53, 66);

        }
    }
}
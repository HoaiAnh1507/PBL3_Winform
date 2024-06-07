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
    public partial class FormDangNhap : Form
    {
        List<DTB_TaiKhoan> ListTaiKhoan = DanhSachTaiKhoan.Instance.ListTaiKhoan;
        public string CurrentUsername { get; private set; }
        public FormDangNhap()
        {
            InitializeComponent();
        }
        private void ThoatBT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void DangNhapBT_Click(object sender, EventArgs e)
        {
            //DanhSachTaiKhoan.Instance.LoadData();
            if (KiemTraDangNhap(textBoxTenDN.Text, textBoxMatkhau.Text))
            {
                CurrentUsername = textBoxTenDN.Text;
                this.Hide();
                FormHeThong f = new FormHeThong();
                f.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
                textBoxTenDN.Focus();
            }
        }
        bool KiemTraDangNhap(string tentaikhoan, string matkhau)
        {
            for (int i = 0; i < ListTaiKhoan.Count; i++)
            {
                if (tentaikhoan == ListTaiKhoan[i].TenTaiKhoan && matkhau == ListTaiKhoan[i].MatKhau)
                {
                    Const.LoaiTaiKhoan = ListTaiKhoan[i].LoaiTaiKhoan;
                    return true;
                }
            }
            return false;
        }
        private void textBoxMatkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (KiemTraDangNhap(textBoxTenDN.Text, textBoxMatkhau.Text))
                {
                    this.Hide();
                    FormHeThong f = new FormHeThong();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu ");
                    textBoxTenDN.Focus();
                }
            }
        }
        private void FormDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
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
    public partial class FormDoiMK : Form
    {
        public FormDoiMK()
        {
            InitializeComponent();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLuuMK_Click(object sender, EventArgs e)
        {
            //DanhSachTaiKhoan.Instance.LoadData();
            string currentUsername = Const.LoaiTaiKhoan ? "admin" : "nhanvien";
            // Lấy tài khoản hiện đang đăng nhập từ danh sách tài khoản
            DTB_TaiKhoan currentAccount = DanhSachTaiKhoan.Instance.ListTaiKhoan.FirstOrDefault(acc => acc.TenTaiKhoan == currentUsername);

            if (currentAccount != null && currentAccount.MatKhau == textBoxMKcu.Text)
            {
                if (!string.IsNullOrEmpty(textBoxMKmoi.Text))
                {
                    if (textBoxMKmoi.Text == textBoxMKmoi2.Text)
                    {
                        if (MessageBox.Show("Xác nhận đổi mật khẩu?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            try
                            {
                                // Thực hiện đổi mật khẩu cho tài khoản
                                QLTaiKhoan.Instance.ChangePassword(currentAccount, textBoxMKmoi.Text);
                                MessageBox.Show("Đổi mật khẩu thành công.");
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Lỗi khi đổi mật khẩu: {ex.Message}");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới không trùng khớp!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền mật khẩu mới");
                }
                
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng!");
            }
        }



        public bool KiemTraTaiKhoan(string tentaikhoan, string matkhau)
        {
            List<DTB_TaiKhoan> ListTaiKhoan = DanhSachTaiKhoan.Instance.ListTaiKhoan;
            for (int i = 0; i < ListTaiKhoan.Count; i++)
            {
                if (tentaikhoan == ListTaiKhoan[i].TenTaiKhoan && matkhau == ListTaiKhoan[i].MatKhau)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

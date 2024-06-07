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
    public partial class HeThong : UserControl
    {
        public HeThong()
        {
            InitializeComponent();
        }
        private void BTdangxuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất không?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.FindForm()?.Hide();
                FormDangNhap f = new FormDangNhap();
                f.Show();
            }
        }

        private void BTdoimk_Click(object sender, EventArgs e)
        {
            FormDoiMK f = new FormDoiMK();
            f.Show(this);
        }
    }
}

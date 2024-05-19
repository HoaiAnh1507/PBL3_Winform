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
            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Hide();
            }
            FormDangNhap f = new FormDangNhap();
            f.Show();
        }
    }
}

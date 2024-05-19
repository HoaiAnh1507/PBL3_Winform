using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoHoaC_
{
    public partial class ThongKe : UserControl
    {
        public ThongKe()
        {
            InitializeComponent();
            CBB();
        }

        private void CBB()
        {
            string[] loai = { "Tổng doanh thu", "Nhân viên", "Sản phẩm", "Khách hàng" };
            comboBoxloaiTK.Items.AddRange(loai);
            comboBoxloaiTK.SelectedIndex = 0;
        }

        private void comboBoxloaiTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime tuNgay = dateTimePicker1.Value;
            DateTime denNgay = dateTimePicker2.Value;

            DataTable dataTable = new DataTable();
            switch (comboBoxloaiTK.SelectedItem.ToString())
            {
                case "Tổng doanh thu":
                    dataTable = QLTK.Instance.tongDoanhThu(tuNgay, denNgay);
                    break;
                case "Nhân viên":
                    dataTable = QLTK.Instance.DT_NV(tuNgay, denNgay);
                    break;
                case "Sản phẩm":
                    dataTable = QLTK.Instance.DT_SP(tuNgay, denNgay);
                    break;
                case "Khách hàng":
                    dataTable = QLTK.Instance.DT_KH(tuNgay, denNgay);
                    break;
                default:
                    break;
            }

            dataGridView1.DataSource = dataTable;
        }

        private void button_DTthang_Click(object sender, EventArgs e)
        {
            DataTable dataTable = QLTK.Instance.DT_Thang();
            dataGridView1.DataSource = dataTable;

        }
    }
}

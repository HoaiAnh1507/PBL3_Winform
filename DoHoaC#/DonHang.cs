using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoHoaC_
{
    public partial class DonHang : UserControl
    {
        public DonHang()
        {
            InitializeComponent();
            ShowDH();
        }
        public void SubscribeToTaoDonHangEvent(FormDonHangChiTiet form)
        {
            form.TaoDonHangCreated += HandleTaoDonHangCreated;
        }
        private void HandleTaoDonHangCreated(object sender, EventArgs e)
        {
            ShowDH(); // Reload DataGridView khi có sự kiện tạo đơn hàng
        }
        public void ShowDH()
        {
            dataGridView1.DataSource = QLDH.Instance.GetDH().Tables["DONHANG"];
            //textBoxTenKH.DataSource = QLDHCT.Instance.ShowComBoBoxTenKH();
            //comboBoxTenNV.DataSource = QLDHCT.Instance.ShowComBoBoxTenNV();
            //comboBoxDM.DataSource = QLSP.Instance.ShowComboBoxDanhMuc();
            //comboBoxTenKH.SelectedText = QLDH.Instance.GetDH().
        }
        private void ThemBT_Click(object sender, EventArgs e)
        {
            FormDonHangChiTiet f = new FormDonHangChiTiet(-1);
            f.Show();   
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int iddh = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_DH"].Value);
                try
                {
                    FormDonHangChiTiet f = new FormDonHangChiTiet(iddh);
                    f.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi cập nhật Đơn hàng: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một Đơn hàng để sửa.");
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int iddh = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_DH"].Value);
                try
                {
                    // Hiển thị hộp thoại xác nhận trước khi xóa
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa đơn hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        QLDH.Instance.DeleteDHCT(iddh.ToString());
                        // Sau khi xóa, làm mới DataGridView để cập nhật dữ liệu hiển thị
                        dataGridView1.DataSource = QLDH.Instance.GetDH().Tables["DONHANG"];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa Đơn hàng: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một Đơn hàng để xóa.");
            }
        }

    }
}

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
        }
        private void ThemBT_Click(object sender, EventArgs e)
        {
            try
            {
                FormDonHangChiTiet f = new FormDonHangChiTiet(-1, false);
                SubscribeToTaoDonHangEvent(f);
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm Đơn hàng: {ex.Message}");
            }

        }
        private void buttonSua_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                bool trangthai = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells["TRANG_THAI"].Value);
                int iddh = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_DH"].Value);
                try
                {
                        
                    FormDonHangChiTiet f = new FormDonHangChiTiet(iddh, trangthai);
                    SubscribeToTaoDonHangEvent(f);
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
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa đơn hàng này?", "Xác nhận xóa",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textBoxTenKH.Text = dataGridView1.SelectedRows[0].Cells["TEN_KHACH_HANG"].Value.ToString();
                textBoxTenNV.Text = dataGridView1.SelectedRows[0].Cells["TEN_NHAN_VIEN"].Value.ToString();
                textBoxTongTien.Text = dataGridView1.SelectedRows[0].Cells["TONG_THANH_TOAN"].Value.ToString();
                object trangThaiValue = dataGridView1.SelectedRows[0].Cells["TRANG_THAI"].Value;
                if (trangThaiValue != DBNull.Value)
                {
                    bool trangThai = Convert.ToBoolean(trangThaiValue);
                    RBTDaTT.Checked = trangThai;
                    RBTChuaTT.Checked = !trangThai;
                }
                else
                {
                    RBTDaTT.Checked = false;
                    RBTChuaTT.Checked = true;
                }
                object ngayMuaValue = dataGridView1.SelectedRows[0].Cells["NGAY_MUA"].Value;
                if (ngayMuaValue != DBNull.Value)
                {
                    DateTime ngayMua = Convert.ToDateTime(ngayMuaValue);
                    dateTimePicker1.Value = ngayMua;
                }
                else
                {
                    // Nếu giá trị của ô dữ liệu NGAY_MUA là DBNull, đặt DateTimePicker1 về thời gian hiện tại
                    dateTimePicker1.Value = DateTime.Now;
                }
            }
        }
        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxFind.Text;
            dataGridView1.DataSource = QLDH.Instance.SearchDH(keyword).Tables["DONHANG"];
        }
    }
}

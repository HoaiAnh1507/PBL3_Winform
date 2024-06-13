using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoHoaC_
{
    public partial class UserControlKhachHang : UserControl
    {
        public UserControlKhachHang()
        {
            InitializeComponent();
            ShowAllKH();
        }
        public void ShowAllKH()
        {
            dataGridView1.DataSource = QLKH.Instance.GetAllKhachHang().Tables["KHACHHANG"];
            textBoxTen.Clear();
            textBoxDiachi.Clear();
            textBoxSDT.Clear();
            textBoxMota.Clear();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận thêm thông tin khách hàng mới?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                DTB_KH kh = new DTB_KH
                {
                    TEN_KHACH_HANG = textBoxTen.Text,
                    DIACHI = textBoxDiachi.Text,
                    SDT = textBoxSDT.Text,
                    INFOR = textBoxMota.Text
                };

                try
                {
                    QLKH.Instance.AddKH(kh); // Thêm Khách hàng mới
                    MessageBox.Show("Thêm Khách Hàng thành công.");
                    ShowAllKH(); // Tải lại dữ liệu sau khi thêm
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thêm Khách Hàng: {ex.Message}");
                }
            }
        }
        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận chỉnh sửa thông tin khách hàng?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string ID_KH = dataGridView1.SelectedRows[0].Cells["ID_KH"].Value.ToString();
                    DTB_KH kh = new DTB_KH
                    {
                        ID_KH = ID_KH,
                        TEN_KHACH_HANG = textBoxTen.Text,
                        DIACHI = textBoxDiachi.Text,
                        SDT = textBoxSDT.Text,
                        INFOR = textBoxMota.Text
                    };
                    try
                    {
                        QLKH.Instance.UpdateKH(ID_KH, kh); // Cập nhật thông tin 
                        MessageBox.Show("Cập nhật Khách Hàng thành công.");
                        ShowAllKH(); // Tải lại dữ liệu sau khi sửa
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi cập nhật Khách Hàng: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một Khách Hàng để sửa.");
                }
            }
        }
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa khách hàng này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string ID_KH = dataGridView1.SelectedRows[0].Cells["ID_KH"].Value.ToString();
                    try
                    {
                        QLKH.Instance.DeleteKH(ID_KH); // Xóa Khách Hàng
                        MessageBox.Show("Xóa Khách Hàng thành công.");
                        ShowAllKH(); // Tải lại dữ liệu sau khi xóa
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xóa Khách Hàng: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một Khách Hàng để xóa.");
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textBoxTen.Text = dataGridView1.SelectedRows[0].Cells["TEN_KHACH_HANG"].Value.ToString();
                textBoxDiachi.Text = dataGridView1.SelectedRows[0].Cells["DIACHI"].Value.ToString();
                textBoxSDT.Text = dataGridView1.SelectedRows[0].Cells["SDT"].Value.ToString();
                textBoxMota.Text = dataGridView1.SelectedRows[0].Cells["INFOR"].Value.ToString();
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxSearch.Text;
            dataGridView1.DataSource = QLKH.Instance.SearchKH(keyword).Tables["KhachHang"];
        }
    }
}

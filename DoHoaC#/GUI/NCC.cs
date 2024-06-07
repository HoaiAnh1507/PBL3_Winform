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

namespace DoHoaC_
{
    public partial class NCC : UserControl
    {
        public NCC()
        {
            InitializeComponent();
            ShowAllNCC();
        }
        private void ShowAllNCC()
        {
            dataGridView1.DataSource = QLNCC.Instance.GetAllNCC().Tables["NHACUNGCAP"]; // Hiển thị danh sách Nhà Cung Cấp
            textBoxTen.Clear();
            textBoxDiachi.Clear();
            textBoxSDT.Clear();
            textBoxMota.Clear();
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận thêm thông tin nhà cung cấp mới?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                DTB_NCC ncc = new DTB_NCC
                {
                    TEN_NHA_CUNG_CAP = textBoxTen.Text,
                    DIACHI = textBoxDiachi.Text,
                    SDT = textBoxSDT.Text,
                    INFOR = textBoxMota.Text
                };

                try
                {
                    QLNCC.Instance.AddNCC(ncc); // Thêm Nhà Cung Cấp mới
                    MessageBox.Show("Thêm Nhà Cung Cấp thành công.");
                    ShowAllNCC(); // Tải lại dữ liệu sau khi thêm
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thêm Nhà Cung Cấp: {ex.Message}");
                }
            }
        }
        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận chỉnh sửa thông tin nhà cung cấp?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string ID_NCC = dataGridView1.SelectedRows[0].Cells["ID_NCC"].Value.ToString();
                    DTB_NCC ncc = new DTB_NCC
                    {
                        ID_NCC = ID_NCC,
                        TEN_NHA_CUNG_CAP = textBoxTen.Text,
                        DIACHI = textBoxDiachi.Text,
                        SDT = textBoxSDT.Text,
                        INFOR = textBoxMota.Text
                    };

                    try
                    {
                        QLNCC.Instance.UpdateNCC(ID_NCC, ncc); // Cập nhật thông tin Nhà Cung Cấp
                        MessageBox.Show("Cập nhật Nhà Cung Cấp thành công.");
                        ShowAllNCC(); // Tải lại dữ liệu sau khi sửa
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi cập nhật Nhà Cung Cấp: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một Nhà Cung Cấp để sửa.");
                }
            }
        }
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa nhà cung cấp này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string ID_NCC = dataGridView1.SelectedRows[0].Cells["ID_NCC"].Value.ToString();
                    try
                    {
                        QLNCC.Instance.DeleteNCC(ID_NCC); // Xóa Nhà Cung Cấp
                        MessageBox.Show("Xóa Nhà Cung Cấp thành công.");
                        ShowAllNCC(); // Tải lại dữ liệu sau khi xóa
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xóa Nhà Cung Cấp: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một Nhà Cung Cấp để xóa.");
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) // Sự kiện click vào một ô trong DataGridView
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textBoxTen.Text = dataGridView1.SelectedRows[0].Cells["TEN_NHA_CUNG_CAP"].Value.ToString();
                textBoxDiachi.Text = dataGridView1.SelectedRows[0].Cells["DIACHI"].Value.ToString();
                textBoxSDT.Text = dataGridView1.SelectedRows[0].Cells["SDT"].Value.ToString();
                textBoxMota.Text = dataGridView1.SelectedRows[0].Cells["INFOR"].Value.ToString();
            }
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxSearch.Text;
            dataGridView1.DataSource = QLNCC.Instance.SearchNCC(keyword).Tables["NhaCungCap"];
        }
    }
}


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
    public partial class NhanVien : UserControl
    {
        public NhanVien()
        {
            InitializeComponent();
            ShowAllNV();
        }
        private void ShowAllNV()
        {
            dataGridView1.DataSource = QLNV.Instance.GetAllNV().Tables["NHANVIEN"] ;
            textBoxTen.Clear();
            textBoxDiachi.Clear();
            textBoxSDT.Clear();
            textBoxChucvu.Clear();
        }
        

        private void buttonThemNV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận thêm thông tin nhân viên mới?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                DTB_NV nv = new DTB_NV
                {
                    TEN_NHAN_VIEN = textBoxTen.Text,
                    DIACHI = textBoxDiachi.Text,
                    SDT = textBoxSDT.Text,
                    CHUCVU = textBoxChucvu.Text
                };

                try
                {
                    QLNV.Instance.AddNV(nv);
                    MessageBox.Show("Thêm Nhân viên thành công.");
                    ShowAllNV();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thêm Nhân viên: {ex.Message}");
                }
            }
        }

        private void buttonSuaNV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận chỉnh sửa thông tin nhân viên?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string ID_NV = dataGridView1.SelectedRows[0].Cells["ID_NV"].Value.ToString();
                    DTB_NV nv = new DTB_NV
                    {
                        ID_NV = ID_NV,
                        TEN_NHAN_VIEN = textBoxTen.Text,
                        DIACHI = textBoxDiachi.Text,
                        SDT = textBoxSDT.Text,
                        CHUCVU = textBoxChucvu.Text
                    };
                    try
                    {
                        QLNV.Instance.UpdateNV(ID_NV, nv);
                        MessageBox.Show("Cập nhật Nhân viên thành công.");
                        ShowAllNV();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi cập nhật Nhân viên: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một Nhân viên để sửa.");
                }
            }
        }

        private void buttonXoaNV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa nhân viên này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string ID_NV = dataGridView1.SelectedRows[0].Cells["ID_NV"].Value.ToString();
                    try
                    {
                        QLNV.Instance.DeleteNV(ID_NV);
                        MessageBox.Show("Xóa Nhân viên thành công.");
                        ShowAllNV();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xóa Nhân viên: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một Nhân viên để xóa.");
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textBoxTen.Text = dataGridView1.SelectedRows[0].Cells["TEN_NHAN_VIEN"].Value.ToString();
                textBoxDiachi.Text = dataGridView1.SelectedRows[0].Cells["DIACHI"].Value.ToString();
                textBoxSDT.Text = dataGridView1.SelectedRows[0].Cells["SDT"].Value.ToString();
                textBoxChucvu.Text = dataGridView1.SelectedRows[0].Cells["CHUCVU"].Value.ToString();

            }
        }

        private void textBoxTimkiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxTimkiem.Text;
            List<DTB_NV> searchResult = QLNV.Instance.SearchNV(keyword);
            dataGridView1.DataSource = searchResult;
        }
        
    }
}
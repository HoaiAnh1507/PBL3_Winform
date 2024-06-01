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
    public partial class SanPham : UserControl
    {
        public SanPham()
        {
            InitializeComponent();
            ShowAllSanPham();
            ShowComboBox();
        }
        public void SubscribeToTaoDonHangEvent(FormDonHangChiTiet form)
        {
            form.TaoDonHangCreated += HandleTaoDonHangCreated;
        }
        private void HandleTaoDonHangCreated(object sender, EventArgs e)
        {
            ShowAllSanPham(); // Reload DataGridView khi có sự kiện tạo đơn hàng
        }
        private void ShowAllSanPham()
        {
            dataGridView.DataSource = QLSP.Instance.GetAllSanPham().Tables["SANPHAM"]; // Hiển thị danh sách Sản Phẩm
            binding();
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            DTB_SP sp = new DTB_SP
            {
                TEN_DANH_MUC = comboBoxDanhMuc.Text,
                TEN_SAN_PHAM = textBoxTen.Text,
                ID_NCC = cbbIdNCC.Text,
                DON_VI = textBoxDonVi.Text,
                DON_GIA = textBoxDonGia.Text,
                SO_LUONG_CON_LAI = textBoxSL.Text
            };

            try
            {
                QLSP.Instance.AddSP(sp); // Thêm Sản Phẩm mới

                if (!comboBoxDanhMuc.Items.Contains(sp.TEN_DANH_MUC))
                {
                    comboBoxDanhMuc.Items.Add(sp.TEN_DANH_MUC); // Thêm danh mục mới vào comboBox
                    comboBoxDanhMuc.SelectedItem = sp.TEN_DANH_MUC; // Chọn danh mục mới vừa thêm
                    //ShowComboBox();
                }
                MessageBox.Show("Thêm Sản Phẩm thành công.");
                ShowAllSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm Sản Phẩm: {ex.Message}");
            }
        }
        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                string ID_SP = dataGridView.SelectedRows[0].Cells["ID_SP"].Value.ToString();
                DTB_SP sp = new DTB_SP
                {
                    ID_SP = ID_SP,
                    TEN_DANH_MUC = comboBoxDanhMuc.Text,
                    TEN_SAN_PHAM = textBoxTen.Text,
                    ID_NCC = cbbIdNCC.Text,
                    DON_VI = textBoxDonVi.Text,
                    DON_GIA = textBoxDonGia.Text,
                    SO_LUONG_CON_LAI = textBoxSL.Text
                };

                try
                {
                    QLSP.Instance.UpdateSP(ID_SP, sp); // Cập nhật thông tin Sản Phẩm
                    MessageBox.Show("Cập nhật Sản Phẩm thành công.");
                    ShowAllSanPham(); // Tải lại dữ liệu sau khi sửa
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi cập nhật Sản Phẩm: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một Sản Phẩm để sửa.");
            }
        }
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                string ID_SP = dataGridView.SelectedRows[0].Cells["ID_SP"].Value.ToString();
                try
                {
                    QLSP.Instance.DeleteSP(ID_SP); // Xóa Sản Phẩm
                    MessageBox.Show("Xóa Sản Phẩm thành công.");
                    ShowAllSanPham(); // Tải lại dữ liệu sau khi xóa
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa Sản Phẩm: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một Sản Phẩm để xóa.");
            }
        }
        public void binding()
        {
            textBoxTen.DataBindings.Clear();
            cbbIdNCC.DataBindings.Clear();
            textBoxDonVi.DataBindings.Clear();
            textBoxDonGia.DataBindings.Clear();
            textBoxSL.DataBindings.Clear();
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                comboBoxDanhMuc.Text = dataGridView.SelectedRows[0].Cells["TEN_DANH_MUC"].Value.ToString();
                textBoxTen.Text = dataGridView.SelectedRows[0].Cells["TEN_SAN_PHAM"].Value.ToString();
                cbbIdNCC.Text = dataGridView.SelectedRows[0].Cells["ID_NCC"].Value.ToString();
                textBoxDonVi.Text = dataGridView.SelectedRows[0].Cells["DON_VI"].Value.ToString();
                textBoxDonGia.Text = dataGridView.SelectedRows[0].Cells["DON_GIA"].Value.ToString();
                textBoxSL.Text = dataGridView.SelectedRows[0].Cells["SO_LUONG_CON_LAI"].Value.ToString();
            }
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxSearch.Text;
            dataGridView.DataSource = QLSP.Instance.SearchSP(keyword).Tables["SanPham"];
        }
        private void Search_Danhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = Search_Danhmuc.Text;
            if (str == "Tất cả")
            {
                ShowAllSanPham();
            }
            else
            {
                dataGridView.DataSource = QLSP.Instance.SearchSP(str).Tables["SanPham"];
            }
        }
        public void ShowComboBox()
        {
            comboBoxDanhMuc.DataSource = QLSP.Instance.ShowComboBoxDanhMuc();
            List<string> danhMucList = QLSP.Instance.ShowComboBoxDanhMuc();
            danhMucList.Insert(0, "Tất cả");
            Search_Danhmuc.DataSource = danhMucList;
            cbbIdNCC.DataSource = QLSP.Instance.ShowComboBoxIDNCC();
        }
    }
}
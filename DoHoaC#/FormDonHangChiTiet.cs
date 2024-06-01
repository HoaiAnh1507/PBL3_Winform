using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoHoaC_
{
    public partial class FormDonHangChiTiet : Form
    {
        private int currentIddh;
        public delegate void TaoDonHangEventHandler(object sender, EventArgs e);

        public event TaoDonHangEventHandler TaoDonHangCreated;
        public FormDonHangChiTiet(int iddh, bool trangthai)
        {
            InitializeComponent();
            if (trangthai)
            {
                textBoxIDDH.Enabled = false;
                comboBoxIDKH.Enabled = false;
                comboBoxIDNV.Enabled = false;
                comboBoxTenKH.Enabled = false;
                comboBoxTenNV.Enabled = false;
                comboBoxDM.Enabled = false;
                comboBoxIDSP.Enabled = false;
                comboBoxTenSP.Enabled = false;
                buttonThemSP.Enabled = false;
                dataGridView1.Enabled = false;
                TaoBT.Enabled = false;
                NhapBT.Enabled = false;
            }
            currentIddh = iddh;
            ShowDHCT(currentIddh);
        }
        private void ShowDHCT(int iddh)
        {
            if (iddh != -1)
            {
                dataGridView1.DataSource = QLDHCT.Instance.GetDHCT(iddh).Tables["DONHANGCHITIET"];
                
                textBoxIDDH.Text = currentIddh.ToString();
                comboBoxTenKH.DataSource = QLDHCT.Instance.ShowComBoBoxTenKH();
                comboBoxTenNV.DataSource = QLDHCT.Instance.ShowComBoBoxTenNV();
                comboBoxDM.DataSource = QLSP.Instance.ShowComboBoxDanhMuc();
                // Lấy dữ liệu từ bảng DONHANG để hiển thị trong các ComboBox
                //comboBoxIDKH.Text = QLDH.Instance.GetKHNV(iddh).ID_KH.ToString();
                //comboBoxIDNV.Text = QLDH.Instance.GetKHNV(iddh).ID_NV.ToString();
                comboBoxTenKH.Text = QLDH.Instance.GetKHNV(iddh, "kh");
                comboBoxTenNV.SelectedItem = QLDH.Instance.GetKHNV(iddh, "nv");
                textBoxThanhToan.Text = QLDHCT.Instance.TongThanhToan(iddh.ToString()).ToString();
            }
            else
            {
                dataGridView1.DataSource = QLDHCT.Instance.GetDHCT(0).Tables["DONHANGCHITIET"];
                comboBoxTenKH.DataSource = QLDHCT.Instance.ShowComBoBoxTenKH();
                comboBoxTenNV.DataSource = QLDHCT.Instance.ShowComBoBoxTenNV();
                comboBoxDM.DataSource = QLSP.Instance.ShowComboBoxDanhMuc();
                textBoxThanhToan.Text = QLDHCT.Instance.TongThanhToan(iddh.ToString()).ToString();
            }
        }
        private void HuyBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void NhapBT_Click(object sender, EventArgs e)
        {

            DTB_DH dh = new DTB_DH
            {
                ID_DH = textBoxIDDH.Text,
                ID_NV = comboBoxIDNV.Text,
                TEN_NHAN_VIEN = comboBoxTenNV.Text,
                ID_KH = comboBoxIDKH.Text,
                TEN_KHACH_HANG = comboBoxTenKH.Text,
                NGAY_MUA = DateTime.Now,
                TONGTHANHTOAN = QLDHCT.Instance.TongThanhToan(textBoxIDDH.Text),
                TRANG_THAI = false,
            };
            try
            {
                if (QLDHCT.Instance.KiemTraDHTonTai(textBoxIDDH.Text))
                {
                    QLDH.Instance.UpdateDHCT(dh);
                }
                else
                {
                    QLDH.Instance.AddDHCT(dh);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm & cập nhật đơn hàng: {ex.Message}");
            }
            if (TaoDonHangCreated != null)
            {
                TaoDonHangCreated(this, EventArgs.Empty);
            }
            this.Close();
        }
        private void TaoBT_Click(object sender, EventArgs e)
        {
            DTB_DH dh = new DTB_DH
            {
                ID_DH = textBoxIDDH.Text,
                ID_NV = comboBoxIDNV.Text,
                TEN_NHAN_VIEN = comboBoxTenNV.Text,
                ID_KH = comboBoxIDKH.Text,
                TEN_KHACH_HANG = comboBoxTenKH.Text,
                NGAY_MUA = DateTime.Now,
                TONGTHANHTOAN = QLDHCT.Instance.TongThanhToan(textBoxIDDH.Text),
                TRANG_THAI = true,
            };
            try
            {
                if (QLDHCT.Instance.KiemTraDHTonTai(textBoxIDDH.Text))
                {
                    QLDH.Instance.UpdateDHCT(dh);
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row != null && !row.IsNewRow)
                        {
                            string ID_SP = row.Cells["ID_SP"].Value.ToString();
                            int SO_LUONG = Convert.ToInt32(row.Cells["SO_LUONG"].Value);
                            QLSP.Instance.UpdateSLSP(ID_SP, SO_LUONG);
                        }
                    }
                }
                else
                {
                    QLDH.Instance.AddDHCT(dh);
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row != null && !row.IsNewRow)
                        {
                            string ID_SP = row.Cells["ID_SP"].Value.ToString();
                            int SO_LUONG = Convert.ToInt32(row.Cells["SO_LUONG"].Value);
                            QLSP.Instance.UpdateSLSP(ID_SP, SO_LUONG);
                        }
                    }
                }
                if (TaoDonHangCreated != null)
                {
                    TaoDonHangCreated(this, EventArgs.Empty);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm & cập nhật đơn hàng: {ex.Message}");
            }

            this.Close();
        }
        private void buttonThemSP_Click(object sender, EventArgs e)
        {
            DTB_DH dh = new DTB_DH
            {
                ID_DH = textBoxIDDH.Text,
                ID_NV = comboBoxIDNV.Text,
                ID_KH = comboBoxIDKH.Text,
                ID_SP = comboBoxIDSP.Text,
                TEN_SAN_PHAM = comboBoxTenSP.Text,
                //NGAYMUA = DateTime.Today,
                DONVI = QLDHCT.Instance.GetDonVi(comboBoxIDSP.Text),
                DONGIA = QLDHCT.Instance.GetDonGia(comboBoxIDSP.Text),
                SOLUONG = (int)domainSL.Value,
                THANHTIEN = QLDHCT.Instance.ThanhTien(comboBoxIDSP.Text, (int)domainSL.Value),
                TONGTHANHTOAN = QLDHCT.Instance.TongThanhToan(textBoxIDDH.Text),
            };
            try
            {
                if (QLDHCT.Instance.KiemTraSPTonTai(dh.ID_DH, dh.ID_SP))
                {
                    QLDHCT.Instance.UpdateSoLuong(dh.ID_DH, dh.ID_SP, dh.SOLUONG);
                    dataGridView1.DataSource = QLDHCT.Instance.GetDHCT(Convert.ToInt32(dh.ID_DH)).Tables["DONHANGCHITIET"];
                }
                else
                {
                    QLDHCT.Instance.AddSP_DHCT(dh); // Thêm mới
                    dataGridView1.DataSource = QLDHCT.Instance.GetDHCT(Convert.ToInt32(dh.ID_DH)).Tables["DONHANGCHITIET"];
                    
                }
                textBoxThanhToan.Text = QLDHCT.Instance.TongThanhToan(textBoxIDDH.Text).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm Sản phẩm: {ex.Message}");
            }
        }
        private void comboBoxDM_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTenSP.DataSource = QLDHCT.Instance.ShowComboBoxSanPham(comboBoxDM.Text);
        }
        private void comboBoxTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxIDSP.DataSource = QLDHCT.Instance.ShowComBoBoxIDSP(comboBoxTenSP.Text);
        }
        private void comboBoxTenNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxIDNV.DataSource = QLDHCT.Instance.ShowComboBoxIDNV(comboBoxTenNV.Text);
        }
        private void comboBoxTenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxIDKH.DataSource = QLDHCT.Instance.ShowComboBoxIDKH(comboBoxTenKH.Text);
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa sản phẩm này?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                QLDHCT.Instance.XoaSP_DHCT(dataGridView1.Rows[e.RowIndex].Cells["ID_SP"].Value.ToString());
                ShowDHCT(currentIddh);
            }
        }
    
    }
}
        
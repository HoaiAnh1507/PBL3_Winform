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
        public FormDonHangChiTiet(int iddh)
        {
            InitializeComponent();
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
                comboBoxIDKH.Text = QLDH.Instance.GetKHNV(iddh).ID_KH.ToString();
                comboBoxIDNV.Text = QLDH.Instance.GetKHNV(iddh).ID_NV.ToString();
                textBoxThanhToan.Text = QLDHCT.Instance.TongThanhToan(iddh.ToString()).ToString();



                //DataSet donHangData = QLDH.Instance.GetDH();
                //if (donHangData.Tables["DONHANG"].Rows.Count > 0)
                //{
                //    // Hiển thị dữ liệu từ bảng DONHANG trong các ComboBox
                //    comboBoxTenKH.DataSource = donHangData.Tables["DONHANG"];
                //    comboBoxTenKH.DisplayMember = "TEN_KHACH_HANG";
                //    comboBoxTenKH.ValueMember = "ID_KH";

                //    comboBoxTenNV.DataSource = donHangData.Tables["DONHANG"];
                //    comboBoxTenNV.DisplayMember = "TEN_NHAN_VIEN";
                //    comboBoxTenNV.ValueMember = "ID_NV";
                //}

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
            this.Hide();
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
                TONGTHANHTOAN = QLDHCT.Instance.TongThanhToan(textBoxIDDH.Text),
            };
            if (QLDHCT.Instance.KiemTraDHTonTai(textBoxIDDH.Text))
            {
                QLDH.Instance.UpdateDHCT(dh);
            }
            else
            {
                QLDH.Instance.AddDHCT(dh);
            }
            //DonHang.Instance.ShowDH();
            OnTaoDonHangCreated(EventArgs.Empty);
            this.Close();
            //DataGridView DonHang.Instance.dataGridView1.DataSource = QLDH.Instance.GetDH();
        }
        protected virtual void OnTaoDonHangCreated(EventArgs e)
        {
            // Kiểm tra xem có ai đăng ký sự kiện không
            TaoDonHangCreated?.Invoke(this, e);
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
                    
                    dataGridView1.DataSource = QLDHCT.Instance.GetDHCT(currentIddh).Tables["DONHANGCHITIET"];
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

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("Bạn muốn xóa sản phẩm này?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                QLDHCT.Instance.XoaSP_DHCT(dataGridView1.Rows[e.RowIndex].Cells["ID_SP"].Value.ToString());
                ShowDHCT(currentIddh);
            }
            
        }
    }
}
        
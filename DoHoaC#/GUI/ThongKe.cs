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
using System.Windows.Forms.DataVisualization.Charting;

namespace DoHoaC_
{
    public partial class ThongKe : UserControl
    {
        public ThongKe()
        {
            InitializeComponent();
            CBB();
            InitControls();
        }

        private void CBB()
        {
            string[] loai = { "Tổng doanh thu", "Nhân viên", "Khách hàng" };
            comboBoxloaiTK.Items.AddRange(loai);
            comboBoxloaiTK.SelectedIndex = 0;

            string[] thang = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            comboBoxThang.Items.AddRange(thang);
            comboBoxThang.SelectedIndex = 0;
        }
        private void InitControls()
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            comboBoxThang.Enabled = false;
            textBoxNam.Enabled = false;
        }
        private void buttonXem_Click(object sender, EventArgs e)
        {
            string loaiTK = comboBoxloaiTK.SelectedItem.ToString();
            DataTable dataTable = new DataTable();

            if (radioButton1.Checked)
            {
                DateTime startDate = dateTimePicker1.Value;
                DateTime endDate = dateTimePicker2.Value;

                switch (loaiTK)
                {
                    case "Tổng doanh thu":
                        dataTable = QLThongKe.Instance.ThongkeByDate(startDate, endDate, "");
                        break;
                    case "Nhân viên":
                        dataTable = QLThongKe.Instance.ThongkeByDate(startDate, endDate, "NhanVien");
                        break;
                    case "Khách hàng":
                        dataTable = QLThongKe.Instance.ThongkeByDate(startDate, endDate, "KhachHang");
                        break;
                }
            }
            else if (radioButton2.Checked)
            {
                int month = int.Parse(comboBoxThang.SelectedItem.ToString());
                switch (loaiTK)
                {
                    case "Tổng doanh thu":
                        dataTable = QLThongKe.Instance.ThongkeByMonth(month, "");
                        break;
                    case "Nhân viên":
                        dataTable = QLThongKe.Instance.ThongkeByMonth(month, "NhanVien");
                        break;
                    case "Khách hàng":
                        dataTable = QLThongKe.Instance.ThongkeByMonth(month, "KhachHang");
                        break;
                }
            }
            else if (radioButton3.Checked)
            {
                int year = int.Parse(textBoxNam.Text);
                switch (loaiTK)
                {
                    case "Tổng doanh thu":
                        dataTable = QLThongKe.Instance.ThongkeByYear(year, "");
                        break;
                    case "Nhân viên":
                        dataTable = QLThongKe.Instance.ThongkeByYear(year, "NhanVien");
                        break;
                    case "Khách hàng":
                        dataTable = QLThongKe.Instance.ThongkeByYear(year, "KhachHang");
                        break;
                }
            }
            dataGridView1.DataSource = dataTable;
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add("ChartArea1");

            // Tạo series mới cho biểu đồ
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;

            // Lặp qua các dòng trong DataTable để thêm dữ liệu vào Series
            foreach (DataRow row in dataTable.Rows)
            {
                
                if (dataTable.Columns.Count == 2)
                {
                    string xValue = row[0].ToString();
                    double yValue = Convert.ToDouble(row[1]);
                    series.Points.AddXY(xValue, yValue);
                }
                else
                {
                    string xValue = row[0].ToString();
                    double yValue = Convert.ToDouble(row[2]);
                    series.Points.AddXY(xValue, yValue);
                }
                
            }
            // Thêm series vào biểu đồ
            chart1.Series.Add(series);
        }
    private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                comboBoxThang.Enabled = false;
                textBoxNam.Enabled = false;
            }
            else if (radioButton2.Checked)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                comboBoxThang.Enabled = true;
                textBoxNam.Enabled = false;
            }
            else if (radioButton3.Checked)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                comboBoxThang.Enabled = false;
                textBoxNam.Enabled = true;
            }
        }
    }
}

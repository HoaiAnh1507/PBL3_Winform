using System;
using System.Data;
using System.Data.SqlClient;

namespace DoHoaC_
{
    public class QLThongKe
    {
        private static QLThongKe _Instance;
        public static QLThongKe Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new QLThongKe();
                return _Instance;
            }
            private set { }
        }

        private QLThongKe() { }

        public DataTable ThongkeByDate(DateTime startDate, DateTime endDate, string a)
        {
            DataTable dataTable = new DataTable();
            string query;

            if (a == "NhanVien")
            {
                query = "SELECT ID_NV, TEN_NHAN_VIEN, SUM(TONG_THANH_TOAN) AS DoanhThu FROM DONHANG WHERE NGAY_MUA BETWEEN @startDate AND @endDate GROUP BY ID_NV, TEN_NHAN_VIEN;";
            }
            else if (a == "KhachHang")
            {
                query = "SELECT ID_KH, TEN_KHACH_HANG, SUM(TONG_THANH_TOAN) AS DoanhThu FROM DONHANG WHERE NGAY_MUA BETWEEN @startDate AND @endDate GROUP BY ID_KH, TEN_KHACH_HANG;";
            }
            else // Tổng doanh thu
            {
                query = "SELECT NGAY_MUA, SUM(TONG_THANH_TOAN) AS DoanhThu FROM DONHANG WHERE NGAY_MUA BETWEEN @startDate AND @endDate GROUP BY NGAY_MUA;";
            }

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        public DataTable ThongkeByMonth(int month, string a)
        {
            DataTable dataTable = new DataTable();
            string query;

            if (a == "NhanVien")
            {
                query = "SELECT ID_NV, TEN_NHAN_VIEN, SUM(TONG_THANH_TOAN) AS DoanhThu FROM DONHANG WHERE MONTH(NGAY_MUA) = @month GROUP BY ID_NV, TEN_NHAN_VIEN;";
            }
            else if (a == "KhachHang")
            {
                query = "SELECT ID_KH, TEN_KHACH_HANG, SUM(TONG_THANH_TOAN) AS DoanhThu FROM DONHANG WHERE MONTH(NGAY_MUA) = @month GROUP BY ID_KH, TEN_KHACH_HANG;";
            }
            else // Tổng doanh thu
            {
                query = "SELECT DAY(NGAY_MUA) AS Ngay, SUM(TONG_THANH_TOAN) AS DoanhThu FROM DONHANG WHERE MONTH(NGAY_MUA) = @month GROUP BY DAY(NGAY_MUA);";
            }

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@month", month);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        public DataTable ThongkeByYear(int year, string a)
        {
            DataTable dataTable = new DataTable();
            string query;

            if (a == "NhanVien")
            {
                query = "SELECT ID_NV, TEN_NHAN_VIEN, SUM(TONG_THANH_TOAN) AS DoanhThu FROM DONHANG WHERE YEAR(NGAY_MUA) = @year GROUP BY ID_NV, TEN_NHAN_VIEN;";
            }
            else if (a == "KhachHang")
            {
                query = "SELECT ID_KH, TEN_KHACH_HANG, SUM(TONG_THANH_TOAN) AS DoanhThu FROM DONHANG WHERE YEAR(NGAY_MUA) = @year GROUP BY ID_KH, TEN_KHACH_HANG;";
            }
            else // Tổng doanh thu
            {
                query = "SELECT MONTH(NGAY_MUA) AS Thang, SUM(TONG_THANH_TOAN) AS DoanhThu FROM DONHANG WHERE YEAR(NGAY_MUA) = @year GROUP BY MONTH(NGAY_MUA);";
            }

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@year", year);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }
    }
}

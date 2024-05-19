using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoHoaC_
{
    public class QLTK
    {
        private static QLTK _Instance;
        public static QLTK Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new QLTK();
                return _Instance;
            }
            private set { }
        }
        public DataTable DT_NV(DateTime tuNgay, DateTime denNgay)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT ID_NV, SUM(TONG_THANH_TOAN) AS DoanhThu FROM DONHANGCHITIET WHERE NGAY_MUA BETWEEN @TuNgay AND @DenNgay GROUP BY ID_NV;";

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TuNgay", tuNgay);
                    command.Parameters.AddWithValue("@DenNgay", denNgay);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }
        public DataTable DT_KH(DateTime tuNgay, DateTime denNgay)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT ID_KH, SUM(TONG_THANH_TOAN) AS DoanhThu FROM DONHANGCHITIET WHERE NGAY_MUA BETWEEN @TuNgay AND @DenNgay GROUP BY ID_KH;";

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TuNgay", tuNgay);
                    command.Parameters.AddWithValue("@DenNgay", denNgay);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;

        }
        public DataTable DT_SP(DateTime tuNgay, DateTime denNgay)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT ID_SP, SUM(TONG_THANH_TOAN) AS DoanhThu FROM DONHANGCHITIET WHERE NGAY_MUA BETWEEN @TuNgay AND @DenNgay GROUP BY ID_SP;";

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TuNgay", tuNgay);
                    command.Parameters.AddWithValue("@DenNgay", denNgay);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;

        }
        public DataTable tongDoanhThu(DateTime tuNgay, DateTime denNgay)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT NGAY_MUA, SUM(TONG_THANH_TOAN) AS DoanhThu FROM DONHANGCHITIET WHERE NGAY_MUA BETWEEN @TuNgay AND @DenNgay GROUP BY NGAY_MUA;";

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TuNgay", tuNgay);
                    command.Parameters.AddWithValue("@DenNgay", denNgay);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;

        }
        public DataTable DT_Thang()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT YEAR(NGAY_MUA) AS Nam, MONTH(NGAY_MUA) AS Thang, SUM(TONG_TIEN) AS TongDoanhThu " +
                           "FROM DONHANG " +
                           "GROUP BY YEAR(NGAY_MUA), MONTH(NGAY_MUA);";

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
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

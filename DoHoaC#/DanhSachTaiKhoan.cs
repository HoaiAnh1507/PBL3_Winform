using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoHoaC_
{
    public class DanhSachTaiKhoan
    {
        private static DanhSachTaiKhoan instance;
        public static DanhSachTaiKhoan Instance
        {
            get
            {
                if (instance == null)
                    instance = new DanhSachTaiKhoan();
                return instance;
            }
            set => instance = value;
        }
        List<DTB_TaiKhoan> listTaiKhoan;
        public List<DTB_TaiKhoan> ListTaiKhoan
        {
            get => listTaiKhoan;
            set => listTaiKhoan = value;
        }
        DanhSachTaiKhoan()
        {
            listTaiKhoan = new List<DTB_TaiKhoan>();
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                string query = "SELECT * FROM TAIKHOAN";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    DTB_TaiKhoan acc = new DTB_TaiKhoan
                    {
                        TenTaiKhoan = reader["TenTaiKhoan"].ToString(),
                        MatKhau = reader["MatKhau"].ToString(),
                        LoaiTaiKhoan = bool.Parse(reader["LoaiTaiKhoan"].ToString()),
                    };
                    listTaiKhoan.Add(acc);
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoHoaC_
{
    public class QLTaiKhoan
    {
        private static QLTaiKhoan _Instance;
        public static QLTaiKhoan Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new QLTaiKhoan();
                return _Instance;
            }
            private set { }
        }
        public void ChangePassword(DTB_TaiKhoan acc, string newPass)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    string query = "UPDATE TAIKHOAN SET MatKhau = @NewMatKhau WHERE TenTaiKhoan = @TenTaiKhoan AND MatKhau = @OldMatKhau";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NewMatKhau", newPass);
                    command.Parameters.AddWithValue("@TenTaiKhoan", acc.TenTaiKhoan);
                    command.Parameters.AddWithValue("@OldMatKhau", acc.MatKhau);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        throw new InvalidOperationException("Mật khẩu cũ không đúng hoặc không tìm thấy tài khoản để cập nhật!");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Đã xảy ra lỗi khi đổi mật khẩu!", ex);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;  
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DoHoaC_
{
    internal class QLKH
    {
        private static QLKH _Instance;
        public static QLKH Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new QLKH();
                return _Instance;
            }
            private set { }
        }
        public DataSet GetAllKhachHang()
        {
            DataSet data = new DataSet();
            string query = "Select * from KHACHHANG";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data, "KHACHHANG");
                connection.Close();
            }
            return data;
        }
        public void AddKH(DTB_KH kh)
        {
            try
            {
                if (kh == null)
                    throw new ArgumentNullException(nameof(kh), "Thông tin Khách hàng không được để trống.");

                if (string.IsNullOrWhiteSpace(kh.TEN_KHACH_HANG))
                    throw new ArgumentException("Tên Khách hàng không được để trống.", nameof(kh.TEN_KHACH_HANG));

                if (IsKHExists(kh.TEN_KHACH_HANG))
                {
                    throw new InvalidOperationException("Khách hàng đã tồn tại trong cơ sở dữ liệu.");
                }
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {

                    string query = "INSERT INTO KHACHHANG (TEN_KHACH_HANG, DIACHI, SDT, INFOR) VALUES (@TEN_KHACH_HANG, @DIACHI, @SDT, @INFOR)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TEN_KHACH_HANG", kh.TEN_KHACH_HANG);
                    command.Parameters.AddWithValue("@DIACHI", kh.DIACHI ?? "");
                    command.Parameters.AddWithValue("@SDT", kh.SDT ?? "");
                    command.Parameters.AddWithValue("@INFOR", kh.INFOR ?? "");
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateKH(string ID_KH, DTB_KH kh)
        {
            try
            {
                if (kh == null)
                    throw new ArgumentNullException(nameof(kh), "Thông tin Khách Hàng không được để trống.");

                if (string.IsNullOrWhiteSpace(kh.TEN_KHACH_HANG))
                    throw new ArgumentException("Tên Khách hàng không được để trống.", nameof(kh.TEN_KHACH_HANG));
                
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    string query = "UPDATE KHACHHANG SET TEN_KHACH_HANG = @TEN_KHACH_HANG, DIACHI = @DIACHI, SDT = @SDT, INFOR = @INFOR WHERE ID_KH = @ID_KH";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID_KH", ID_KH);
                    command.Parameters.AddWithValue("@TEN_KHACH_HANG", kh.TEN_KHACH_HANG);
                    command.Parameters.AddWithValue("@DIACHI", kh.DIACHI ?? "");
                    command.Parameters.AddWithValue("@SDT", kh.SDT ?? "");
                    command.Parameters.AddWithValue("@INFOR", kh.INFOR ?? "");
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        throw new InvalidOperationException("Không tìm thấy Khách Hàng để cập nhật.");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DeleteKH(string ID_KH)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ID_KH))
                    throw new ArgumentException("ID Khách Hàng không được để trống.", nameof(ID_KH));
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    string query = "DELETE FROM KHACHHANG WHERE ID_KH = @ID_KH";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID_KH", ID_KH);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        throw new InvalidOperationException("Không tìm thấy Khách Hàng để xóa.");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet SearchKH(string keyword)
        {
            DataSet dataSet = new DataSet();
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    string query = "SELECT * FROM KHACHHANG WHERE TEN_KHACH_HANG LIKE @keyword OR DIACHI LIKE @keyword OR SDT LIKE @keyword OR INFOR LIKE @keyword";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    connection.Open();
                    // Tạo SqlDataAdapter và điền dữ liệu vào DataSet
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataSet, "KhachHang");
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
            return dataSet;
        }

        private bool IsKHExists(string tenKH)
        {
            string query = "SELECT COUNT(*) FROM KHACHHANG WHERE TEN_KHACH_HANG = @TEN_KHACH_HANG";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TEN_KHACH_HANG", tenKH);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}

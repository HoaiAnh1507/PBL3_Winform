using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DoHoaC_
{
    public class QLNV
    {
        private static QLNV _Instance;
        public static QLNV Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new QLNV();
                return _Instance;
            }
            private set { }
        }
        public DataSet GetAllNV()
        {
            DataSet data = new DataSet();
            string query = "Select * from NHANVIEN";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data, "NHANVIEN");
                connection.Close();
            }
            return data;
        }
        public void AddNV(DTB_NV nv)
        {
            try
            {
                if (nv == null)
                    throw new ArgumentNullException(nameof(nv), "Thông tin Nhân viên không được để trống.");

                if (string.IsNullOrWhiteSpace(nv.TEN_NHAN_VIEN))
                    throw new ArgumentException("Tên Nhân viên không được để trống.", nameof(nv.TEN_NHAN_VIEN));
                if (IsNVExists(nv.TEN_NHAN_VIEN, nv.DIACHI, nv.SDT))
                {
                    throw new InvalidOperationException("Nhân viên đã tồn tại trong cơ sở dữ liệu.");
                }
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    string query = "INSERT INTO NHANVIEN (TEN_NHAN_VIEN, DIACHI, SDT, CHUCVU) VALUES (@TEN_NHAN_VIEN, @DIACHI, @SDT, @CHUCVU)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TEN_NHAN_VIEN", nv.TEN_NHAN_VIEN);
                    command.Parameters.AddWithValue("@DIACHI", nv.DIACHI ?? "");
                    command.Parameters.AddWithValue("@SDT", nv .SDT ?? "");
                    command.Parameters.AddWithValue("@CHUCVU", nv.CHUCVU ?? "");
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
        public void UpdateNV(string ID_NV, DTB_NV nv)
        {
            try
            {
                if (nv == null)
                    throw new ArgumentNullException(nameof(nv), "Thông tin Nhân viên không được để trống.");

                if (string.IsNullOrWhiteSpace(nv.TEN_NHAN_VIEN))
                    throw new ArgumentException("ID Nhân viên không được để trống.", nameof(nv.TEN_NHAN_VIEN));
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    string query = "UPDATE NHANVIEN SET TEN_NHAN_VIEN = @TEN_NHAN_VIEN, DIACHI = @DIACHI, SDT = @SDT, CHUCVU = @CHUCVU WHERE ID_NV = @ID_NV";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID_NV", ID_NV);
                    command.Parameters.AddWithValue("@TEN_NHAN_VIEN", nv.TEN_NHAN_VIEN);
                    command.Parameters.AddWithValue("@DIACHI", nv.DIACHI ?? "");
                    command.Parameters.AddWithValue("@SDT", nv.SDT ?? "");
                    command.Parameters.AddWithValue("@CHUCVU", nv.CHUCVU ?? "");

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        throw new InvalidOperationException("Không tìm thấy Nhân viên để cập nhật.");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DeleteNV(string ID_NV)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ID_NV))
                    throw new ArgumentException("ID Nhân viên không được để trống.", nameof(ID_NV));
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    string query = "DELETE FROM NHANVIEN WHERE ID_NV = @ID_NV";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID_NV", ID_NV);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        throw new InvalidOperationException("Không tìm thấy Nhân viên để xóa.");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public DataSet SearchNV(string keyword)
        {
            DataSet dataSet = new DataSet();
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    string query = "SELECT * FROM NHANVIEN WHERE TEN_NHAN_VIEN LIKE @keyword OR DIACHI LIKE @keyword OR SDT LIKE @keyword OR CHUCVU LIKE @keyword";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    connection.Open();

                    // Tạo SqlDataAdapter và điền dữ liệu vào DataSet
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataSet, "NhanVien");
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
            return dataSet;
        }
        private bool IsNVExists(string tenNV, string diachi, string sdt)
        {
            string query = "SELECT COUNT(*) FROM NHANVIEN WHERE TEN_NHAN_VIEN = @TEN_NHAN_VIEN AND DIACHI = @DIACHI AND SDT = @SDT";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TEN_NHAN_VIEN", tenNV);
                    command.Parameters.AddWithValue("@DIACHI", diachi);
                    command.Parameters.AddWithValue("@SDT", sdt);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

    }
}
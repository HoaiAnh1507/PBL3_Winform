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
    public class QLNCC
    {
        private static QLNCC _Instance;
        public static QLNCC Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new QLNCC();
                return _Instance;
            }
            private set { }
        }
        public DataSet GetAllNCC()
        {
            DataSet data = new DataSet();
            string query = "Select * from NHACUNGCAP";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data, "NHACUNGCAP");
                connection.Close();
            }
            return data;
        }
        public void AddNCC(DTB_NCC ncc)
        {
            try
            {
                if (ncc == null)
                    throw new ArgumentNullException(nameof(ncc), "Thông tin Nhà Cung Cấp không được để trống.");

                if (string.IsNullOrWhiteSpace(ncc.TEN_NHA_CUNG_CAP))
                    throw new ArgumentException("Tên Nhà Cung Cấp không được để trống.", nameof(ncc.TEN_NHA_CUNG_CAP));
                
                if (IsNCCExists(ncc.TEN_NHA_CUNG_CAP, ncc.DIACHI, ncc.SDT))
                {
                    throw new InvalidOperationException("Nhà Cung Cấp đã tồn tại trong cơ sở dữ liệu.");
                }
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    string query = "INSERT INTO NHACUNGCAP (TEN_NHA_CUNG_CAP, DIACHI, SDT, INFOR) VALUES (@TEN_NHA_CUNG_CAP, @DIACHI, @SDT, @INFOR)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TEN_NHA_CUNG_CAP", ncc.TEN_NHA_CUNG_CAP);
                    command.Parameters.AddWithValue("@DIACHI", ncc.DIACHI ?? "");
                    command.Parameters.AddWithValue("@SDT", ncc.SDT ?? "");
                    command.Parameters.AddWithValue("@INFOR", ncc.INFOR ?? "");

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception( ex.Message);
            }
        }
        public void UpdateNCC(string ID_NCC, DTB_NCC ncc)
        {
            try
            {
                if (ncc == null)
                    throw new ArgumentNullException(nameof(ncc), "Thông tin Nhà Cung Cấp không được để trống.");

                if (string.IsNullOrWhiteSpace(ID_NCC))
                    throw new ArgumentException("ID Nhà Cung Cấp không được để trống.", nameof(ID_NCC));
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    string query = "UPDATE NHACUNGCAP SET TEN_NHA_CUNG_CAP = @TEN_NHA_CUNG_CAP, DIACHI = @DIACHI, SDT = @SDT, INFOR = @INFOR WHERE ID_NCC = @ID_NCC";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID_NCC", ID_NCC);
                    command.Parameters.AddWithValue("@TEN_NHA_CUNG_CAP", ncc.TEN_NHA_CUNG_CAP);
                    command.Parameters.AddWithValue("@DIACHI", ncc.DIACHI ?? "");
                    command.Parameters.AddWithValue("@SDT", ncc.SDT ?? "");
                    command.Parameters.AddWithValue("@INFOR", ncc.INFOR ?? "");

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        throw new InvalidOperationException("Không tìm thấy Nhà Cung Cấp để cập nhật.");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DeleteNCC(string ID_NCC)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ID_NCC))
                    throw new ArgumentException("ID Nhà Cung Cấp không được để trống.", nameof(ID_NCC));
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    string query = "DELETE FROM NHACUNGCAP WHERE ID_NCC = @ID_NCC";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID_NCC", ID_NCC);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        throw new InvalidOperationException("Không tìm thấy Nhà Cung Cấp để xóa.");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet SearchNCC(string keyword)
        {
            DataSet dataSet = new DataSet();
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    string query = "SELECT * FROM NHACUNGCAP WHERE TEN_NHA_CUNG_CAP LIKE @keyword OR DIACHI LIKE @keyword OR SDT LIKE @keyword OR INFOR LIKE @keyword";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    connection.Open();

                    // Tạo SqlDataAdapter và điền dữ liệu vào DataSet
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataSet, "NhaCungCap");
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
        private bool IsNCCExists(string tenNCC, string diachi, string sdt)
        {
            string query = "SELECT COUNT(*) FROM NHACUNGCAP WHERE TEN_NHA_CUNG_CAP = @TEN_NHA_CUNG_CAP AND DIACHI = @DIACHI AND SDT = @SDT";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TEN_NHA_CUNG_CAP", tenNCC);
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

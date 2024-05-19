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
    public class QLSP
    {
        private static QLSP _Instance;
        public static QLSP Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new QLSP();
                return _Instance;
            }
            private set { }
        }
        public DataSet GetAllSanPham()
        {
            DataSet data = new DataSet();
            string query = "Select * from SANPHAM";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data, "SANPHAM");
                connection.Close();
            }
            return data;
        }
        public void AddSP(DTB_SP sp)
        {
            try
            {
                if (sp == null)
                    throw new ArgumentNullException(nameof(sp), "Thông tin Sản Phẩm không được để trống.");

                if (string.IsNullOrWhiteSpace(sp.TEN_SAN_PHAM))
                    throw new ArgumentException("Tên Sản Phẩm không được để trống.", nameof(sp.TEN_SAN_PHAM));
                
                if (IsSPExists(sp.TEN_SAN_PHAM))
                {
                    throw new InvalidOperationException("Sản Phẩm đã tồn tại trong cơ sở dữ liệu.");
                }
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    string query = "INSERT INTO SANPHAM (TEN_SAN_PHAM, ID_NCC, TEN_DANH_MUC, DON_VI, DON_GIA, SO_LUONG_CON_LAI) VALUES (@TEN_SAN_PHAM, @ID_NCC, @TEN_DANH_MUC, @DON_VI, @DON_GIA, @SO_LUONG_CON_LAI)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TEN_SAN_PHAM", sp.TEN_SAN_PHAM);
                    command.Parameters.AddWithValue("@ID_NCC", sp.ID_NCC ?? "");
                    command.Parameters.AddWithValue("@TEN_DANH_MUC", sp.TEN_DANH_MUC ?? "");
                    command.Parameters.AddWithValue("@DON_VI", sp.DON_VI ?? "");
                    command.Parameters.AddWithValue("@DON_GIA", sp.DON_GIA ?? "");
                    command.Parameters.AddWithValue("@SO_LUONG_CON_LAI", sp.SO_LUONG_CON_LAI ?? "");

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Đã xảy ra lỗi khi thêm Sản Phẩm vào cơ sở dữ liệu.", ex);
            }
        }
        public void UpdateSP(string ID_SP, DTB_SP sp)
        {
            try
            {
                if (sp == null)
                    throw new ArgumentNullException(nameof(sp), "Thông tin Sản Phẩm không được để trống.");

                if (string.IsNullOrWhiteSpace(sp.TEN_SAN_PHAM))
                    throw new ArgumentException("ID Sản Phẩm không được để trống.", nameof(ID_SP));
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    string query = "UPDATE SANPHAM SET TEN_SAN_PHAM = @TEN_SAN_PHAM, ID_NCC = @ID_NCC, TEN_DANH_MUC = @TEN_DANH_MUC, DON_VI = @DON_VI, DON_GIA = @DON_GIA, SO_LUONG_CON_LAI = @SO_LUONG_CON_LAI WHERE ID_SP = @ID_SP";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID_SP", ID_SP);
                    command.Parameters.AddWithValue("@TEN_SAN_PHAM", sp.TEN_SAN_PHAM);
                    command.Parameters.AddWithValue("@ID_NCC", sp.ID_NCC ?? "");
                    command.Parameters.AddWithValue("@TEN_DANH_MUC", sp.TEN_DANH_MUC ?? "");
                    command.Parameters.AddWithValue("@DON_VI", sp.DON_VI ?? "");
                    command.Parameters.AddWithValue("@DON_GIA", sp.DON_GIA ?? "");
                    command.Parameters.AddWithValue("@SO_LUONG_CON_LAI", sp.SO_LUONG_CON_LAI ?? "");

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        throw new InvalidOperationException("Không tìm thấy Sản Phẩm để cập nhật.");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Đã xảy ra lỗi khi sửa Sản Phẩm.", ex);
            }
        }
        public void DeleteSP(string ID_SP)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ID_SP))
                    throw new ArgumentException("ID Sản Phẩm không được để trống.", nameof(ID_SP));
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    string query = "DELETE FROM SANPHAM WHERE ID_SP = @ID_SP";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID_SP", ID_SP);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        throw new InvalidOperationException("Không tìm thấy Sản Phẩm để xóa.");
                    connection.Close() ;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Đã xảy ra lỗi khi xóa Sản Phẩm.", ex);
            }
        }
        public List<DTB_SP> SearchSP(string keyword)
        {
            List<DTB_SP> spList = new List<DTB_SP>();
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                try
                {
                    string query = "SELECT * FROM SANPHAM WHERE TEN_SAN_PHAM LIKE @keyword OR ID_NCC LIKE @keyword OR TEN_DANH_MUC LIKE @keyword";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        DTB_SP sp = new DTB_SP
                        {
                            ID_SP = reader["ID_SP"].ToString(),
                            TEN_SAN_PHAM = reader["TEN_SAN_PHAM"].ToString(),
                            ID_NCC = reader["ID_NCC"].ToString(),
                            TEN_DANH_MUC = reader["TEN_DANH_MUC"].ToString(),
                            DON_VI = reader["DON_VI"].ToString(),
                            DON_GIA = reader["DON_GIA"].ToString(),
                            SO_LUONG_CON_LAI = reader["SO_LUONG_CON_LAI"].ToString()
                        };
                        spList.Add(sp);
                    }
                }
            
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
            return spList;
        }
        //Hàm kiểm tra sản phẩm đã tồn tại hay chưa
        private bool IsSPExists(string tenSP)
        {
            string query = "SELECT COUNT(*) FROM SANPHAM WHERE TEN_SAN_PHAM = @TEN_SAN_PHAM";

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TEN_SAN_PHAM", tenSP);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        public List<string> ShowComboBoxDanhMuc()
        {
            List<string> uniqueValues = new List<string>();
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                string query = "SELECT DISTINCT TEN_DANH_MUC FROM SANPHAM";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string danhMuc = reader["TEN_DANH_MUC"].ToString();
                            uniqueValues.Add(danhMuc);
                        }
                    }
                }
            }
            return uniqueValues;
        }
        public List<string> ShowComboBoxIDNCC()
        {
            List<string> idList = new List<string>();
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                string query = "SELECT ID_NCC FROM NHACUNGCAP";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string idNCC = reader["ID_NCC"].ToString();
                            idList.Add(idNCC);
                        }
                    }
                }
            }
            return idList;
        }
    }
}

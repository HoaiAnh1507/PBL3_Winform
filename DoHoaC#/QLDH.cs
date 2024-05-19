using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoHoaC_
{
    internal class QLDH
    {
        private static QLDH _Instance;
        public static QLDH Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new QLDH();
                return _Instance;
            }
            private set { }
        }
        public DataSet GetDH()
        {
            DataSet data = new DataSet();
            string query = "Select ID_DH, ID_KH, TEN_KHACH_HANG, ID_NV, TEN_NHAN_VIEN, NGAY_MUA, TONG_THANH_TOAN, TRANG_THAI from DONHANG";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data, "DONHANG");
                connection.Close();
            }
            return data;
        }
        public DTB_DH GetKHNV(int iddh)
        {
            DTB_DH db = new DTB_DH();
            string query = "SELECT ID_KH, ID_NV, TONG_THANH_TOAN FROM DONHANG WHERE ID_DH = @ID_DH";

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID_DH", iddh);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            db.ID_KH = (reader.GetOrdinal("ID_KH").ToString());
                            db.ID_NV = (reader.GetOrdinal("ID_NV").ToString());
                            //db.TONG_THANH_TOAN = reader.GetInt32(reader.GetOrdinal("TONG_THANH_TOAN"));
                            //db.TRANG_THAI = reader.GetString(reader.GetOrdinal("TRANG_THAI"));
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Log or handle exception
                    MessageBox.Show($"Lỗi khi lấy thông tin Đơn hàng: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }

            return db;
        }
        public void AddDHCT(DTB_DH dh)
        {
            try
            {
                if (dh.ID_DH == null)
                    throw new ArgumentNullException(nameof(dh), "Thông tin sản phẩm không được để trống.");
                if (string.IsNullOrWhiteSpace(dh.ID_NV))
                    throw new ArgumentException("Thông tin nhân viên không được để trống.");
                if (string.IsNullOrWhiteSpace(dh.ID_KH))
                    throw new ArgumentException("Thông tin Khách hàng không được để trống.");
                
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    string query2 = "INSERT INTO DONHANG (ID_DH, ID_NV, TEN_NHAN_VIEN, ID_KH, TEN_KHACH_HANG, TONG_THANH_TOAN) VALUES (@ID_DH, @ID_NV, @TEN_NHAN_VIEN, @ID_KH, @TEN_KHACH_HANG, @TONG_THANH_TOAN)";
                    SqlCommand command2 = new SqlCommand(query2, connection);
                    command2.Parameters.AddWithValue("@ID_DH", dh.ID_DH);
                    command2.Parameters.AddWithValue("@ID_NV", dh.ID_NV ?? "");
                    command2.Parameters.AddWithValue("@TEN_NHAN_VIEN", dh.TEN_NHAN_VIEN ?? "");
                    command2.Parameters.AddWithValue("@ID_KH", dh.ID_KH ?? "");
                    command2.Parameters.AddWithValue("@TEN_KHACH_HANG", dh.TEN_KHACH_HANG ?? "");
                    command2.Parameters.AddWithValue("@TONG_THANH_TOAN", dh.TONGTHANHTOAN.ToString() ?? "");
                    connection.Open();
                    command2.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateDHCT(DTB_DH dh)
        {
            try
            {
                if (dh == null)
                    throw new ArgumentNullException(nameof(dh), "Thông tin sản phẩm không được để trống.");
                if (string.IsNullOrWhiteSpace(dh.ID_NV))
                    throw new ArgumentException("Thông tin nhân viên không được để trống.");
                if (string.IsNullOrWhiteSpace(dh.ID_KH))
                    throw new ArgumentException("Thông tin Khách hàng không được để trống.");
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    string query = "UPDATE DONHANG SET ID_NV = @ID_NV, TEN_NHAN_VIEN = @TEN_NHAN_VIEN, ID_KH = @ID_KH, TEN_KHACH_HANG = @TEN_KHACH_HANG, TONG_THANH_TOAN = @TONG_THANH_TOAN WHERE ID_DH = @ID_DH";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID_NV", dh.ID_NV ?? "");
                    command.Parameters.AddWithValue("@TEN_NHAN_VIEN", dh.TEN_NHAN_VIEN ?? "");
                    command.Parameters.AddWithValue("@ID_KH", dh.ID_KH ?? "");
                    command.Parameters.AddWithValue("@TEN_KHACH_HANG", dh.TEN_KHACH_HANG ?? "");
                    command.Parameters.AddWithValue("@TONG_THANH_TOAN", dh.TONGTHANHTOAN.ToString() ?? "");
                    command.Parameters.AddWithValue("@ID_DH", dh.ID_DH);
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

        public void DeleteDHCT(string id_dh)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    string query = "DELETE FROM DONHANG WHERE ID_DH = @ID_DH";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID_DH", id_dh);
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


    }
}

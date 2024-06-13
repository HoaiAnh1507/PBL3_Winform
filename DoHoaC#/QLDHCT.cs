using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoHoaC_
{
    internal class QLDHCT
    {
        private static QLDHCT _Instance;
        public static QLDHCT Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new QLDHCT();
                return _Instance;
            }
            private set { }
        }
        public DataSet GetDHCT(int iddh)
        {
            DataSet data = new DataSet();
            if (iddh != 0)
            {
                string query = "Select ID_SP, TEN_SAN_PHAM, DON_VI, SO_LUONG, DON_GIA, THANH_TIEN  from DONHANGCHITIET where ID_DH = @ID_DH";
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@ID_DH", iddh);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(data, "DONHANGCHITIET");
                    connection.Close();
                }
            }
            return data;
        }
        public void AddSP_DHCT(DTB_DH dh)
        {
            if (KiemTraSoLuongSPTrongKho(dh.ID_DH, dh.ID_SP, dh.SOLUONG))
            {
                try
                {
                    if (dh == null)
                        throw new ArgumentNullException(nameof(dh), "Thông tin sản phẩm không được để trống.");
                    using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                    {
                        string query1 = "INSERT INTO DONHANGCHITIET (ID_DH, ID_SP, TEN_SAN_PHAM, DON_VI, DON_GIA, SO_LUONG, THANH_TIEN, TONG_THANH_TOAN) VALUES (@ID_DH, @ID_SP, @TEN_SAN_PHAM, @DON_VI, @DON_GIA, @SO_LUONG, @THANH_TIEN, @TONG_THANH_TOAN)";
                        SqlCommand command = new SqlCommand(query1, connection);
                        command.Parameters.AddWithValue("@ID_DH", dh.ID_DH);
                        command.Parameters.AddWithValue("@ID_SP", dh.ID_SP ?? "");
                        command.Parameters.AddWithValue("@TEN_SAN_PHAM", dh.TEN_SAN_PHAM ?? "");
                        command.Parameters.AddWithValue("@DON_VI", dh.DONVI ?? "");
                        command.Parameters.AddWithValue("@DON_GIA", dh.DONGIA.ToString() ?? "");
                        command.Parameters.AddWithValue("@SO_LUONG", dh.SOLUONG.ToString() ?? "");
                        command.Parameters.AddWithValue("@THANH_TIEN", dh.THANHTIEN.ToString() ?? "");
                        command.Parameters.AddWithValue("@TONG_THANH_TOAN", dh.TONGTHANHTOAN.ToString() ?? "");
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
            else
            {
                MessageBox.Show("error", "Vượt quá số lượng trong kho");
            }
        }
        public void UpdateSoLuong(string ID_DH, string ID_SP, int soLuong)
        {
            if (KiemTraSoLuongSPTrongKho(ID_DH, ID_SP, soLuong))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                    {
                        string query = "UPDATE DONHANGCHITIET SET SO_LUONG = SO_LUONG + @SO_LUONG, THANH_TIEN = DON_GIA * (SO_LUONG + @SO_LUONG) WHERE ID_SP = @ID_SP and ID_DH = @ID_DH";
                        SqlCommand command = new SqlCommand(query, connection);

                        command.Parameters.AddWithValue("@ID_SP", ID_SP);
                        command.Parameters.AddWithValue("@ID_DH", ID_DH);
                        command.Parameters.AddWithValue("@SO_LUONG", soLuong);

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
            else
            {
                MessageBox.Show("Vượt quá số lượng trong kho", "Error");
            }
            
        }
        public void XoaSP_DHCT(string ID_SP)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    string query = "DELETE FROM DONHANGCHITIET WHERE ID_SP = @ID_SP";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@ID_SP", ID_SP);

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
        public List<string> ShowComBoBoxTenNV()
        {
            List<string> listnv = new List<string>();
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                string query = "SELECT TEN_NHAN_VIEN FROM NHANVIEN";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string tennv = reader["TEN_NHAN_VIEN"].ToString();
                            listnv.Add(tennv);
                        }
                    }
                }
            }
            return listnv;
        }
        public List<string> ShowComBoBoxTenKH()
        {
            List<string> listkh = new List<string>();
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                string query = "SELECT TEN_KHACH_HANG FROM KHACHHANG";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string tenkh = reader["TEN_KHACH_HANG"].ToString();
                            listkh.Add(tenkh);
                        }
                    }
                }
            }
            return listkh;
        }
        public List<string> ShowComboBoxSanPham(string TEN_DANH_MUC)
        {
            List<string> uniqueValues = new List<string>();
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                string query = "SELECT DISTINCT TEN_SAN_PHAM FROM SANPHAM where TEN_DANH_MUC = @TEN_DANH_MUC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TEN_DANH_MUC", TEN_DANH_MUC);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string tensp = reader["TEN_SAN_PHAM"].ToString();
                            uniqueValues.Add(tensp);
                        }
                    }
                }
            }
            return uniqueValues;
        }
        public List<string> ShowComboBoxIDNV(string TEN_NHAN_VIEN)
        {
            List<string> idnv = new List<string>();
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                string query = "SELECT ID_NV FROM NHANVIEN WHERE TEN_NHAN_VIEN = @TEN_NHAN_VIEN";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TEN_NHAN_VIEN", TEN_NHAN_VIEN);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string id = reader["ID_NV"].ToString();
                            idnv.Add(id);
                        }
                    }
                }
            }
            return idnv;
        }
        public List<string> ShowComboBoxIDKH(string TEN_KHACH_HANG)
        {
            List<string> idkh = new List<string>();
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                string query = "SELECT ID_KH FROM KHACHHANG WHERE TEN_KHACH_HANG = @TEN_KHACH_HANG";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TEN_KHACH_HANG", TEN_KHACH_HANG);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string id = reader["ID_KH"].ToString();
                            idkh.Add(id);
                        }
                    }
                }
            }
            return idkh;
        }
        public List<string> ShowComBoBoxIDSP(string TEN_SAN_PHAM)
        {
            List<string> idsp = new List<string>();
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                string query = "SELECT ID_SP FROM SANPHAM WHERE TEN_SAN_PHAM = @TEN_SAN_PHAM";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TEN_SAN_PHAM", TEN_SAN_PHAM);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            idsp.Add(reader["ID_SP"].ToString());
                        }
                    }
                }
            }
            return idsp;
        }
        public int GetDonGia(string ID_SP)
        {
            int dongia = 0;
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                string query = "SELECT DON_GIA FROM SANPHAM WHERE ID_SP = @ID_SP";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID_SP", ID_SP);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            dongia = Convert.ToInt32(reader["DON_GIA"]);
                        }
                    }
                }
            }
            return dongia;
        }
        public string GetDonVi(string ID_SP)
        {
            string donvi = "";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                string query = "SELECT DON_VI FROM SANPHAM WHERE ID_SP = @ID_SP";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID_SP", ID_SP);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            donvi = Convert.ToString(reader["DON_VI"]);
                        }
                    }
                }
            }
            return donvi;
        }
        public int ThanhTien(string ID_SP, int sl)
        {
            int tt = 0;
            tt = QLDHCT.Instance.GetDonGia(ID_SP) * sl;
            return tt;
        }
        public int TongThanhToan(string ID_DH)
        {
            int tongThanhToan = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    string query = "SELECT SUM(THANH_TIEN) AS TongThanhToan FROM DONHANGCHITIET WHERE ID_DH = @ID_DH";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_DH", ID_DH);
                        object result = command.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            tongThanhToan = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tính tổng thành toán: {ex.Message}");
            }
            return tongThanhToan;
        }
        public bool KiemTraSPTonTai(string ID_DH, string ID_SP)
        {
            string query = "SELECT COUNT(*) FROM DONHANGCHITIET WHERE ID_SP = @ID_SP and ID_DH = @ID_DH";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID_SP", ID_SP);
                    command.Parameters.AddWithValue("@ID_DH", ID_DH);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        public bool KiemTraSoLuongSPTrongKho(string ID_DH, string ID_SP, int sl)
        {
            int soluongtrongkho = 0, soluongdhct = 0;
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                string query1 = "SELECT SO_LUONG_CON_LAI FROM SANPHAM WHERE ID_SP = @ID_SP";
                using (SqlCommand command = new SqlCommand(query1, connection))
                {
                    command.Parameters.AddWithValue("@ID_SP", ID_SP);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            soluongtrongkho = Convert.ToInt32(reader["SO_LUONG_CON_LAI"]);
                        }
                    }
                }
            }
            if(KiemTraSPTonTai(ID_DH, ID_SP))
            {
                string query = "SELECT SO_LUONG FROM DONHANGCHITIET WHERE ID_SP = @ID_SP and ID_DH = @ID_DH";
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID_SP", ID_SP);
                        command.Parameters.AddWithValue("@ID_DH", ID_DH);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                soluongdhct = Convert.ToInt32(reader["SO_LUONG"]);
                            }
                        }
                    }
                }
                if (sl + soluongdhct > soluongtrongkho)
                {
                    return false;
                }
                return true;
            }
            else
            {
                if (sl > soluongtrongkho)
                {
                    return false;
                }
                return true;
            }
            
            
        }
        public bool KiemTraDHCTTonTai(string ID_DH)
        {
            string query = "SELECT COUNT(*) FROM DONHANGCHITIET where ID_DH = @ID_DH";

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID_DH", ID_DH);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        public void DeleteDHCT(string id_dh)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    string query = "DELETE FROM DONHANGCHITIET WHERE ID_DH = @ID_DH";
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
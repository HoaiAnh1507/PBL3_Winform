using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoHoaC_
{
    internal class ConnectionString
    {
        public static SqlConnection cnn;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public static string connectionString = @"Data Source=HOAI-ANH\SQLEXPRESS;Initial Catalog=PBL3_CSDL;Integrated Security=True;";
        public SqlConnection OpenDB()
        {
            cnn = new SqlConnection(connectionString);
            return cnn;
        }


        public static void OpenConnection()
        {
            cnn = new SqlConnection(connectionString);
            cnn.Open();
        }

        public static void CloseConnection()
        {
            cnn.Close();
            cnn.Dispose();
            cnn = null;
        }

        public static DataTable getDataTable(string query)
        {
            cmd = new SqlCommand(query, cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable table = new DataTable();
            da.Fill(table);
            da.Dispose();
            cmd.Dispose();
            return table;

        }
        public static void Excute(string query)
        {
            cmd = new SqlCommand(query, cnn);
            cmd.ExecuteNonQuery();
        }
    }


}

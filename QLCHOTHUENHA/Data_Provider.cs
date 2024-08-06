using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHOTHUENHA
{
    public static class Data_Provider
    {
        private static SqlConnection cnn;
        private static SqlDataAdapter da;
        private static SqlCommand cmd;

        public static void moKetNoi()
        {
            cnn = new SqlConnection();
            cnn.ConnectionString = ConfigurationManager.ConnectionStrings["QLCTN"].ConnectionString.ToString();
            cnn.Open();
        }
        public static void dongKetNoi() 
        {
            cnn.Close();
        }

        public static DataTable getTable(string sql)
        {
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(sql, cnn);
            da.Fill(dt);
            return dt;
        }
        public static void updateData(string sql, object[] value=null, string[] name=null) 
        { 
            cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.Clear();
            if(value != null )
            {
                for(int i = 0; i < value.Length; i++)
                {
                    cmd.Parameters.AddWithValue(name[i], value[i]);
                }
            }
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        public static int checkData(string sql)
        {
            int i = 0;
            cmd = new SqlCommand(sql, cnn);
            i = (int)cmd.ExecuteScalar();
            cmd.Dispose();
            return i;   
        }
    }
}

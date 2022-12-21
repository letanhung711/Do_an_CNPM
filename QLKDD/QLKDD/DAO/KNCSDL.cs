using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLKDD.DAO
{
    class KNCSDL
    {
        private static SqlConnection cnn = new SqlConnection();
        public static void MoKetNoi()
        {
            string sqlcon = @"Data Source=DESKTOP-PDAKNK0\SQLEXPRESS;Initial Catalog=QLKDD;Integrated Security=True";
            cnn.ConnectionString = sqlcon;
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
        }
        public static void DongKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }
        public static DataTable DocDuLieu(string sql)
        {
            MoKetNoi();
            SqlCommand cd = new SqlCommand(sql, cnn);
            SqlDataReader dr = cd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DongKetNoi();
            return dt;
        }
        public static void ThucThiCauTruyVan(string sql)
        {
            MoKetNoi();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            DongKetNoi();
        }
    }
}

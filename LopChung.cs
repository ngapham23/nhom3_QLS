using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
   /* phamquangngadeptrai*/
    internal class LopChung
    {
        string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Đồ Án\LaptrinhNet\QLsach\QLsach.mdf"";Integrated Security=True";
        SqlConnection conn;
        public LopChung()
        {
            conn = new SqlConnection(chuoikn);
        }
        public int themsuaxoa(string sql)
        {
            
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int kq = comm.ExecuteNonQuery();
            conn.Close();
            return kq;
        }
        public object laygt(string sql)
        {
            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();
            object kq = command.ExecuteScalar();
            conn.Close();
            return kq;
        }
        public DataTable LoadDL(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


    }
}

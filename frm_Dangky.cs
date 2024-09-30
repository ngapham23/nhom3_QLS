using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLsach
{
    public partial class frm_Dangky : Form
    {
        public frm_Dangky()
        {

            InitializeComponent();
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Đồ Án\LaptrinhNet\QLsach\QLSach.mdf"";Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoikn);
            try
            {
                conn.Open();
                string tk = txt_taikhoan.Text;
                string mk = txt_matkhau.Text;

                // Kiểm tra xem tài khoản đã tồn tại hay chưa
                string checkSql = "Select * from TaiKhoan where TenDN = @TenDN";
                SqlCommand checkCmd = new SqlCommand(checkSql, conn);
                checkCmd.Parameters.AddWithValue("@TenDN", tk);
                SqlDataReader reader = checkCmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên khác!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    reader.Close();
                }
                else
                {
                    reader.Close(); // Đóng reader trước khi thực hiện lệnh khác

                    // Thêm tài khoản mới vào cơ sở dữ liệu
                    string sql = "INSERT INTO TaiKhoan (TenDN, MatKhau) VALUES (@TenDN, @MatKhau)";
                    SqlCommand comm = new SqlCommand(sql, conn);
                    comm.Parameters.AddWithValue("@TenDN", tk);
                    comm.Parameters.AddWithValue("@MatKhau", mk);

                    int result = comm.ExecuteNonQuery(); // Thực hiện lệnh và trả về số dòng bị ảnh hưởng

                    if (result > 0)
                    {
                        MessageBox.Show("Đăng ký thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Đóng form Đăng Ký
                        this.Close(); // Chỉ đóng form đăng ký, không ảnh hưởng đến ứng dụng chính
                    }
                    else
                    {
                        MessageBox.Show("Đăng ký thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

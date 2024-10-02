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
            this.FormClosed += frm_Dangky_FormClosed;

            InitializeComponent();
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_taikhoan.Text) || string.IsNullOrWhiteSpace(txt_matkhau.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Đồ Án\LaptrinhNet\QLsach\QLsach.mdf"";Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoikn);
            try
            {
                conn.Open();
                string tk = txt_taikhoan.Text;
                string mk = txt_matkhau.Text;

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
                    reader.Close(); 

             
                    string sql = "INSERT INTO TaiKhoan (TenDN, MatKhau) VALUES (@TenDN, @MatKhau)";
                    SqlCommand comm = new SqlCommand(sql, conn);
                    comm.Parameters.AddWithValue("@TenDN", tk);
                    comm.Parameters.AddWithValue("@MatKhau", mk);

                    int result = comm.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Đăng ký thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close(); 
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
                this.Hide();
                frm_Dangnhap danghap = new frm_Dangnhap();
                danghap.Show();
                
            
        }

        private void frm_Dangky_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["frm_Dangnhap"] != null)
            {
                Application.OpenForms["frm_Dangnhap"].Show();
            }
        }

        private void frm_Dangky_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.OpenForms["frm_Dangnhap"].Show();
        }
    }
}

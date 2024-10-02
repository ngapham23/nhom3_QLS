using QuanLySach;
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
    public partial class frm_Dangnhap : Form
    {
        public frm_Dangnhap()
        {

            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn thoát không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Đồ Án\LaptrinhNet\QLsach\QLsach.mdf"";Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoikn);
            try
            {
                conn.Open();
                string tk = txt_taikhoan.Text;
                string mk = txt_matkhau.Text;

                string sql = "Select * from TaiKhoan where TenDN = '" + tk + "' and MatKhau = '" + mk + "'";
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader dat = comm.ExecuteReader();
                if (dat.Read() == true)
                {
                   
                    frm_Trangchu home = new frm_Trangchu();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu hoặc tên đăng nhập !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối !!!", "Thông Báo");

            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            


            

                frm_Dangky frmDangKy = new frm_Dangky();
                frmDangKy.Show();
                this.Hide();

            
           
        }
    }
}

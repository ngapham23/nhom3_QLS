using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySach
{
    public partial class frm_TheLoai : Form
    {
        public frm_TheLoai()
        {
            InitializeComponent();

        }

        LopChung LopChung = new LopChung();
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_matheloai.Text) ||
            string.IsNullOrWhiteSpace(txt_tentheloai.Text))
            {

                MessageBox.Show("Vui lòng nhập đầy đủ thông tin .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = "Insert into TheLoai values ('" + txt_matheloai.Text + "',N'" + txt_tentheloai.Text + "')";
            int kq = LopChung.themsuaxoa(sql);
            if (kq >= 1) MessageBox.Show("Thêm thể loại thành công");
            else MessageBox.Show("Thêm thể loại thất bại");
            LoatTL();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_matheloai.Text) ||
            string.IsNullOrWhiteSpace(txt_tentheloai.Text))
            {

                MessageBox.Show("Vui lòng nhập đầy đủ thông tin .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = "UPDATE TheLoai SET Tentheloai = N'" +txt_tentheloai.Text+ "' WHERE MaTheLoai = '" + txt_matheloai.Text + "'";
            int kq = LopChung.themsuaxoa(sql);
            if (kq >= 1) MessageBox.Show("Sửa thể loại thành công");
            else MessageBox.Show("Sửa thể loại thất bại");
            LoatTL();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sqlDeleteSach = "DELETE FROM Sach WHERE MaTheLoai = '" + txt_matheloai.Text + "'";
            LopChung.themsuaxoa(sqlDeleteSach);

            
            string sqlDeleteTheLoai = "DELETE FROM TheLoai WHERE MaTheLoai = '" + txt_matheloai.Text + "'";
            int kq = LopChung.themsuaxoa(sqlDeleteTheLoai);

            
            if (kq >= 1) MessageBox.Show("Xóa thể loại thành công");
            else MessageBox.Show("Xóa thể loại thất bại");
            LoatTL();
        }

        public void LoatTL()
        {
            string sql = "Select * from TheLoai";
            DataTable dt = LopChung.LoadDL(sql);
            data_dvtl.DataSource = dt;
        }

        public void load_TimKiem()
        {
            string sql = "Select * from TheLoai where TenTheLoai like '%" + txt_TimKiem.Text + "%'";
            DataTable dt = LopChung.LoadDL(sql);
            data_dvtl.DataSource = dt;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            load_TimKiem();
        }

        private void btn_HienThi_Click(object sender, EventArgs e)
        {
            LoatTL();
        }

        private void frm_TheLoai_Load(object sender, EventArgs e)
        {
            LoatTL();
        }

        private void data_dvtl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_matheloai.Text = data_dvtl.CurrentRow.Cells["MaTheLoai"].Value.ToString();
            txt_tentheloai.Text = data_dvtl.CurrentRow.Cells["TenTheLoai"].Value.ToString();
        }
    }
}

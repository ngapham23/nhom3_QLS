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
    public partial class frm_Sach : Form
    {
        public frm_Sach()
        {
            InitializeComponent();
            BringToFront();
        }
        private void OpenChildForm()
        {
            
            frm_Sach frm = new frm_Sach();

            frm.Dock = DockStyle.Fill;

            frm.FormBorderStyle = FormBorderStyle.None;

        }

        LopChung lopchung = new LopChung();
        private void btn_them_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_MaSach.Text) ||
            string.IsNullOrWhiteSpace(txt_TenSach.Text) ||
            string.IsNullOrWhiteSpace(txt_SoLuong.Text) ||
            string.IsNullOrWhiteSpace(txt_GiaBan.Text) ||
            cb_MaTheLoai.SelectedValue == null ||
            cb_MaNXB.SelectedValue == null ||
            cb_MaTacGia.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = "Insert into Sach values ('" + txt_MaSach.Text + "',N'" + txt_TenSach.Text + "',N'" + txt_SoLuong.Text + "',N'" + txt_GiaBan.Text + "', N'" + cb_MaTheLoai.SelectedValue + "', N'" + cb_MaNXB.SelectedValue + "',N'" + cb_MaTacGia.SelectedValue + "' )";
            int kq = lopchung.themsuaxoa(sql);
            if (kq >= 1) MessageBox.Show("Thêm sách thành công");
            else MessageBox.Show("Thêm sách thất bại");
            LoadSach();

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaSach.Text) ||
            string.IsNullOrWhiteSpace(txt_TenSach.Text) ||
            string.IsNullOrWhiteSpace(txt_SoLuong.Text) ||
            string.IsNullOrWhiteSpace(txt_GiaBan.Text) ||
            cb_MaTheLoai.SelectedValue == null || 
            cb_MaNXB.SelectedValue == null ||      
            cb_MaTacGia.SelectedValue == null)     
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = "UPDATE Sach SET TenSach = '" + txt_TenSach.Text +
                 "', SoLuong = '" + txt_SoLuong.Text +
                 "', GiaBan = '" + txt_GiaBan.Text +
                 "', MaTheLoai = '" + cb_MaTheLoai.SelectedValue +
                 "', MaNXB = '" + cb_MaNXB.SelectedValue +
                 "', MaTacGia = '" + cb_MaTacGia.SelectedValue +
                 "' WHERE MaSach = '" + txt_MaSach.Text + "'";
            int kq = lopchung.themsuaxoa(sql);
            if (kq >= 1)
                MessageBox.Show("Cập nhật sách thành công");
            else
                MessageBox.Show("Cập nhật sách thất bại");
            LoadSach();

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM Sach WHERE MaSach = '" + txt_MaSach.Text + "'";
            int kq = lopchung.themsuaxoa(sql);
            if (kq >= 1) MessageBox.Show("Xóa sách thành công");
            else MessageBox.Show("Xóa sách thất bại");
            LoadSach();
            
        }
        public void LoadSach()
        {
            //string sql = "Select MaSach, TenSach, SoLuong, GiaBan, TenTacGia, TenNXB, TenTheLoai from Sach join TheLoai on Sach.MaTheLoai = TheLoai.MaTheLoai join TacGia on Sach.MaTacGia = TacGia.MaTacGia join NhaXuatBan on Sach.MaNXB = NhaXuatBan.MaNXB";
            //DataTable dt = lopchung.LoadDL(sql);
            //dtgv_sach.DataSource = dt;
            string sql = "Select * from Sach";
            DataTable dt = lopchung.LoadDL(sql);
            dtgv_sach.DataSource = dt;
            
        }
        public void LoadTheLoai()
        {
            string sql1 = "Select * from TheLoai";
            DataTable dt2 = lopchung.LoadDL(sql1);
            cb_MaTheLoai.DataSource = dt2;
            cb_MaTheLoai.DisplayMember = "TenTheLoai";
            cb_MaTheLoai.ValueMember = "MaTheLoai";
        }

        public void LoadNXB()
        {
            string sql1 = "Select * from NhaXuatBan";
            DataTable dt2 = lopchung.LoadDL(sql1);
            cb_MaNXB.DataSource = dt2;
            cb_MaNXB.DisplayMember = "TenNXB";
            cb_MaNXB.ValueMember = "MaNXB";
        }

        public void LoadTacGia()
        {
            string sql1 = "Select * from TacGia";
            DataTable dt2 = lopchung.LoadDL(sql1);
            cb_MaTacGia.DataSource = dt2;
            cb_MaTacGia.DisplayMember = "TenTacGia";
            cb_MaTacGia.ValueMember = "MaTacGia";
        }

        private void frm_Sach_Load(object sender, EventArgs e)
        {
          
            this.theLoaiTableAdapter.Fill(this.qLsachDataSet.TheLoai);
            LoadSach();
            LoadTheLoai();
            LoadNXB();
            LoadTacGia();
        }

        private void dtgv_sach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaSach.Text = dtgv_sach.CurrentRow.Cells["MaSach"].Value.ToString();
            txt_TenSach.Text = dtgv_sach.CurrentRow.Cells["TenSach"].Value.ToString();
            txt_SoLuong.Text = dtgv_sach.CurrentRow.Cells["SoLuong"].Value.ToString();
            txt_GiaBan.Text = dtgv_sach.CurrentRow.Cells["GiaBan"].Value.ToString();
            cb_MaTheLoai.SelectedValue = dtgv_sach.CurrentRow.Cells["MaTheLoai"].Value.ToString();
            cb_MaNXB.SelectedValue = dtgv_sach.CurrentRow.Cells["MaNXB"].Value.ToString();
            cb_MaTacGia.SelectedValue = dtgv_sach.CurrentRow.Cells["MaTacGia"].Value.ToString();
        }

        public void load_TimKiem()
        {
            string sql = "Select * from Sach where TenSach like '%" + txt_timkiem.Text + "%'";
            DataTable dt = lopchung.LoadDL(sql);
            dtgv_sach.DataSource = dt;

        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            load_TimKiem();
        }

        private void btn_HienThi_Click(object sender, EventArgs e)
        {
            LoadSach();
        }

        private void txt_MaSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgv_sach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cb_MaTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

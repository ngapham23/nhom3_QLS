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
    public partial class frm_NXB : Form
    {
        public frm_NXB()
        {
            InitializeComponent();
        }
        LopChung lopchung = new LopChung();

        public void LoadNXB()
        {
            string sql = "Select * from NhaXuatBan";
            dt_GridNXB.DataSource = lopchung.LoadDL(sql);
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into NhaXuatBan values ('" + txt_MaNXB.Text + "',N'" + txt_TenNXB.Text + "',N'" + txt_DiaChi.Text + "',N'" + txt_SoDienThoai.Text + "')";
            int kq = lopchung.themsuaxoa(sql);
            if (kq >= 1) MessageBox.Show("Thêm Nhà xuất bản thành công");
            else MessageBox.Show("Thêm Nhà xuất bản thất bại");
            LoadNXB();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete NhaXuatBan where MaNXB = '" + txt_MaNXB.Text + "'";
            int kq = lopchung.themsuaxoa(sql);
            if (kq >= 1) MessageBox.Show("Xóa Nhà xuất bản thành công");
            else MessageBox.Show("Xóa Nhà xuất bản thất bại");
            LoadNXB();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "Update NhaXuatBan set TenNXB = N'" + txt_TenNXB.Text + "', DiaChi = N'" + txt_DiaChi.Text + "', DienThoai = N'" + txt_SoDienThoai.Text + "' where MaNXB = '" + txt_MaNXB.Text + "'";
            int kq = lopchung.themsuaxoa(sql);
            if (kq >= 1) MessageBox.Show("Sửa Nhà xuất bản thành công");
            else MessageBox.Show("Sửa Nhà xuất bản thất bại");
            LoadNXB();
        }

        private void btn_HienThi_Click(object sender, EventArgs e)
        {
            LoadNXB();
        }

        private void frm_NXB_Load(object sender, EventArgs e)
        {
            LoadNXB();
        }

        public void load_TimKiem()
        {
            string sql = "Select * from NhaXuatBan where TenNXB like '%" + txt_TimKiem.Text + "%'";
            DataTable dt = lopchung.LoadDL(sql);
            dt_GridNXB.DataSource = dt;

        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            load_TimKiem();
        }

        private void dt_GridNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNXB.Text = dt_GridNXB.CurrentRow.Cells["MaNXB"].Value.ToString();
            txt_TenNXB.Text = dt_GridNXB.CurrentRow.Cells["TenNXB"].Value.ToString();
            txt_DiaChi.Text = dt_GridNXB.CurrentRow.Cells["DiaChi"].Value.ToString();
            txt_SoDienThoai.Text = dt_GridNXB.CurrentRow.Cells["DienThoai"].Value.ToString();
        }
    }
}

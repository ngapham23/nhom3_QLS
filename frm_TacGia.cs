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
    public partial class frm_TacGia : Form
    {
        public frm_TacGia()
        {
            InitializeComponent();
        }

        LopChung lopchung = new LopChung();
        private void frm_TacGia_Load(object sender, EventArgs e)
        {
            LoatTG();
        }

        private void btn_HienThi_Click(object sender, EventArgs e)
        {
            LoatTG();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into TacGia values ('" + txt_mtg.Text + "',N'" + txt_tentg.Text + "',N'" + txt_lienlac.Text + "')";
            int kq = lopchung.themsuaxoa(sql);
            if (kq >= 1) MessageBox.Show("Thêm tác giả thành công");
            else MessageBox.Show("Thêm tác giả thất bại");
            LoatTG();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE TacGia SET TenTacGia = N'" + txt_tentg.Text + "', QuocGia = N'" + txt_lienlac.Text + "' WHERE MaTacGia = '" + txt_mtg.Text + "'";
            int kq = lopchung.themsuaxoa(sql);
            if (kq >= 1) MessageBox.Show("Sửa tác giả thành công");
            else MessageBox.Show("Sửa tác giả thất bại");
            LoatTG();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM TacGia WHERE MaTacGia = '" + txt_mtg.Text + "'";
            int kq = lopchung.themsuaxoa(sql);
            if (kq >= 1) MessageBox.Show("Xóa tác giả thành công");
            else MessageBox.Show("Xóa tác giả thất bại");
            LoatTG();
        }

        public void LoatTG()
        {
            string sql = "Select * from TacGia";
            DataTable dt = lopchung.LoadDL(sql);
            dt_gridTG.DataSource = dt;
        }

        private void dt_gridTG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mtg.Text = dt_gridTG.CurrentRow.Cells["MaTacGia"].Value.ToString();
            txt_tentg.Text = dt_gridTG.CurrentRow.Cells["TenTacGia"].Value.ToString();
            txt_lienlac.Text = dt_gridTG.CurrentRow.Cells["QuocGia"].Value.ToString();
        }

        public void load_TimKiem()
        {
            string sql = "Select * from TacGia where TenTacGia like '%" + txt_TimKiem.Text + "%'";
            DataTable dt = lopchung.LoadDL(sql);
            dt_gridTG.DataSource = dt;

        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            load_TimKiem();

        }
    }
}

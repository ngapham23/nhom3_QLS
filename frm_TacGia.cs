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
            if (string.IsNullOrWhiteSpace(txt_tentg.Text) ||
            string.IsNullOrWhiteSpace(txt_lienlac.Text) ||
            string.IsNullOrWhiteSpace(txt_mtg.Text))
            {

                MessageBox.Show("Vui lòng nhập đầy đủ thông tin .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = "Insert into TacGia values ('" + txt_mtg.Text + "',N'" + txt_tentg.Text + "',N'" + txt_lienlac.Text + "')";
            int kq = lopchung.themsuaxoa(sql);
            if (kq >= 1) MessageBox.Show("Thêm tác giả thành công");
            else MessageBox.Show("Thêm tác giả thất bại");
            LoatTG();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_tentg.Text) ||
            string.IsNullOrWhiteSpace(txt_lienlac.Text) ||
            string.IsNullOrWhiteSpace(txt_mtg.Text))
            {
                
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Tên tác giả, Quốc gia, và Mã tác giả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;  
            }
            string sql = "UPDATE TacGia SET TenTacGia = N'" + txt_tentg.Text + "', QuocGia = N'" + txt_lienlac.Text + "' WHERE MaTacGia = '" + txt_mtg.Text + "'";
            int kq = lopchung.themsuaxoa(sql);
            if (kq >= 1) MessageBox.Show("Sửa tác giả thành công");
            else MessageBox.Show("Sửa tác giả thất bại");
            LoatTG();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            /*LopChung conn = new LopChung();
            string sqlCheck = "SELECT COUNT(*) FROM Sach WHERE MaTacGia = '" + txt_mtg.Text + "'";
            int count = (int)lopchung.laygt(sqlCheck);

            // Nếu có sách liên quan, không cho phép xóa
            if (count > 0)
            {
                MessageBox.Show("Không thể xóa tác giả vì vẫn còn sách liên quan.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }*/
            // Xóa tất cả sách liên quan trước
            string sqlDeleteSach = "DELETE FROM Sach WHERE MaTacGia = '" + txt_mtg.Text + "'";
            lopchung.themsuaxoa(sqlDeleteSach);

            // Sau đó xóa tác giả
            string sqlDeleteTacGia = "DELETE FROM TacGia WHERE MaTacGia = '" + txt_mtg.Text + "'";
            int kq = lopchung.themsuaxoa(sqlDeleteTacGia);

            
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
           

        }
    }
}

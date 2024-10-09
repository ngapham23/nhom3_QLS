using QuanLySach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLsach
{
    public partial class frm_Quanlydocgia : Form
    {
        public frm_Quanlydocgia()
        {
            InitializeComponent();
            this.MouseClick += new MouseEventHandler(frm_Quanlydocgia_MouseClick);// thêm chuột phải
        }
        LopChung lopchung = new LopChung();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgv_DocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_DocGia.Rows[e.RowIndex];
                txt_HoTen.Text = row.Cells["HoTen"].Value.ToString();
                txt_DiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txt_SDT.Text = row.Cells["SDT"].Value.ToString();
                txt_Email.Text = row.Cells["Email"].Value.ToString();
            }
        }

        private void frm_Quanlydocgia_MouseClick(object sender, MouseEventArgs e) // thêm chuột phải
        {
            if (e.Button == MouseButtons.Right)
    {
        // Lấy vị trí ở giữa màn hình
        int x = (this.ClientSize.Width - contextMenuStrip1.Width) / 2;
        int y = (this.ClientSize.Height - contextMenuStrip1.Height) / 2;

        // Hiển thị ContextMenuStrip tại vị trí đã tính toán
        contextMenuStrip1.Show(this, x, y);
    }
        }

        private void lưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string hoTen = txt_HoTen.Text;
            string diaChi = txt_DiaChi.Text;
            string sdt = txt_SDT.Text;
            string email = txt_Email.Text;

            string sql = $"INSERT INTO DocGia (HoTen, DiaChi, SDT, Email) VALUES (N'{hoTen}', N'{diaChi}', '{sdt}', '{email}')";
            int kq = lopchung.themsuaxoa(sql);
            LoadDocGia();
        }

        private void xoáToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string madocgia = dtgv_DocGia.CurrentRow.Cells["MaDocGia"].Value.ToString();

            // Xóa các bản ghi liên quan trong MuonTraSach
            string sqlDeleteMuonTra = $"DELETE FROM MuonTraSach WHERE MaDocGia = {madocgia}";
            lopchung.themsuaxoa(sqlDeleteMuonTra); 

            
            string sql = $"DELETE FROM DocGia WHERE MaDocGia = {madocgia}";
            int kq = lopchung.themsuaxoa(sql);
            if (kq > 0)
            {
                
            }
            else
            {
                MessageBox.Show("Xóa độc giả thất bại!");
            }
            LoadDocGia() ;
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Madocgia = dtgv_DocGia.CurrentRow.Cells["MaDocGia"].Value.ToString();
            string hoTen = txt_HoTen.Text;
            string diaChi = txt_DiaChi.Text;
            string sdt = txt_SDT.Text;
            string email = txt_Email.Text;
            string sql = $"UPDATE DocGia SET HoTen = N'{hoTen}', DiaChi = N'{diaChi}', SDT = '{sdt}', Email = '{email}' WHERE MaDocGia = {Madocgia}";

            int kq = lopchung.themsuaxoa(sql);
            if (kq > 0)
            {
                MessageBox.Show("Cập nhật độc giả thành công!");
                LoadDocGia(); 
            }
            else
            {
                MessageBox.Show("Cập nhật độc giả thất bại!");
            }
        }

        private void frm_Quanlydocgia_Load(object sender, EventArgs e)
        {
            LoadDocGia();
        }
        private void LoadDocGia()
        {
            string sql = "SELECT * FROM DocGia"; // Giả sử có bảng DocGia
            DataTable dt = lopchung.LoadDL(sql);
            dtgv_DocGia.DataSource = dt; // Gán dữ liệu cho DataGridView
        }
    }
}

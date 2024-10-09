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
    public partial class frm_MuonTraSach : Form
    {
        public frm_MuonTraSach()
        {
            InitializeComponent();
        }
        LopChung lopchung = new LopChung();
        private void frm_MuonTraSach_Load(object sender, EventArgs e)
        {
            LoadMuonTraSach();
        }
        private void LoadMuonTraSach()
        {
            string sql = "Select * from MuonTraSach";
            DataTable dt = lopchung.LoadDL(sql);
            dtgv_muontrasach.DataSource = dt;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string ngayMuon = date_muon.Value.ToString("yyyy-MM-dd");
            string ngayTra = date_tra.Value.ToString("yyyy-MM-dd");
            string maDocGia = txt_madocgia.Text;
            string tinhTrang = cb_tinhtrang.Text;



            string sql = "INSERT INTO MuonTraSach (MaSach, MaDocGia, NgayMuon, NgayTra, TinhTrang) " +
               "VALUES ('" + txt_masach.Text + "', '" + maDocGia + "', '" + ngayMuon + "', '" + ngayTra + "', N'" + tinhTrang + "')";

            // Gọi phương thức themsuaxoa để thực hiện thêm bản ghi
            int kq = lopchung.themsuaxoa(sql);

            if (kq > 0)
            {
                MessageBox.Show("Thêm mới thành công!");
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại!");
            }

            LoadMuonTraSach();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM MuonTraSach WHERE MaSach = '" + txt_masach.Text + "'";
            int kq = lopchung.themsuaxoa(sql);
            if (kq >= 1) MessageBox.Show("Xóa  thành công");
            else MessageBox.Show("Xóa  thất bại");
            LoadMuonTraSach();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string maMuonTra = dtgv_muontrasach.CurrentRow.Cells["MaMuonTra"].Value.ToString(); //lấy từ data grid view ,ko cần thêm nút ở giao diện
            string maDocGia = txt_madocgia.Text;
            string ngayMuon = date_muon.Value.ToString("yyyy-MM-dd");
            string ngayTra = date_tra.Value.ToString("yyyy-MM-dd");

            string tinhTrang = cb_tinhtrang.Text;

            string sql = "UPDATE MuonTraSach SET MaSach = '" + txt_masach.Text +
        "', MaDocGia = '" + maDocGia +
        "', NgayMuon = '" + ngayMuon +
        "', NgayTra = '" + ngayTra +
        "', TinhTrang = N'" + tinhTrang + "' WHERE MaMuonTra = '" + maMuonTra + "'"; // Cần có điều kiện WHERE với MaMuonTra

            int kq = lopchung.themsuaxoa(sql);
            if (kq >= 1)
                MessageBox.Show("Cập nhật  thành công");
            else
                MessageBox.Show("Cập nhật  thất bại");
            LoadMuonTraSach();
        }

        private void dtgv_muontrasach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu có hàng nào đang được chọn
            if (e.RowIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow row = dtgv_muontrasach.Rows[e.RowIndex];

                // Gán dữ liệu từ các cột của hàng được chọn vào các TextBox và ComboBox
                txt_masach.Text = row.Cells["MaSach"].Value.ToString();
                txt_madocgia.Text = row.Cells["MaDocGia"].Value.ToString();
                date_muon.Value = Convert.ToDateTime(row.Cells["NgayMuon"].Value);
                date_tra.Value = Convert.ToDateTime(row.Cells["NgayTra"].Value);
                cb_tinhtrang.Text = row.Cells["TinhTrang"].Value.ToString();
            }
        }
    }
}

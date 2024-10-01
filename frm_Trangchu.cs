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
    public partial class frm_Trangchu : Form
    {
        public frm_Trangchu()
        {
            InitializeComponent();

            this.BackgroundImageLayout = ImageLayout.Stretch;

        }


        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn đăng xuất không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
                frm_Dangnhap dangNhap = new frm_Dangnhap();
                dangNhap.Show();
            }
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name != "frm_Sach")  
                {
                    form.Close();  
                                   // Hoặc form.Hide(); nếu  muốn giữ form trong bộ nhớ
                }
            }

           
            if (Application.OpenForms["frm_Sach"] == null)
            {
                frm_Sach sach = new frm_Sach();
                sach.FormBorderStyle = FormBorderStyle.None;
                sach.Dock = DockStyle.Fill;
                sach.MdiParent = this;
                sach.Show();
            }
            else
            {
                Application.OpenForms["frm_Sach"].Activate();  // Kích hoạt form nếu đã mở
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void frm_Trangchu_Load(object sender, EventArgs e)
        {

        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name != "frm_TacGia")
                {
                    form.Close();
                    // Hoặc form.Hide(); nếu  muốn giữ form trong bộ nhớ
                }
            }


            if (Application.OpenForms["frm_TacGia"] == null)
            {
                frm_TacGia sach = new frm_TacGia();
                sach.FormBorderStyle = FormBorderStyle.None;
                sach.Dock = DockStyle.Fill;
                sach.MdiParent = this;
                sach.Show();
            }
            else
            {
                Application.OpenForms["frm_TacGia"].Activate();  // Kích hoạt form nếu đã mở
            }
        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name != "frm_TheLoai")
                {
                    form.Close();
                    // Hoặc form.Hide(); nếu  muốn giữ form trong bộ nhớ
                }
            }


            if (Application.OpenForms["frm_TheLoai"] == null)
            {
                frm_TheLoai sach = new frm_TheLoai();
                sach.FormBorderStyle = FormBorderStyle.None;
                sach.Dock = DockStyle.Fill;
                sach.MdiParent = this;
                sach.Show();
            }
            else
            {
                Application.OpenForms["frm_TheLoai"].Activate();  // Kích hoạt form nếu đã mở
            }
        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name != "frm_NXB")
                {
                    form.Close();
                    // Hoặc form.Hide(); nếu  muốn giữ form trong bộ nhớ
                }
            }


            if (Application.OpenForms["frm_NXB"] == null)
            {
                frm_NXB sach = new frm_NXB();
                sach.FormBorderStyle = FormBorderStyle.None;
                sach.Dock = DockStyle.Fill;
                sach.MdiParent = this;
                sach.Show();
            }
            else
            {
                Application.OpenForms["frm_NXB"].Activate();  // Kích hoạt form nếu đã mở
            }
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }

            
            MessageBox.Show("Bạn đã trở về trang chủ!");

        }
    }
}

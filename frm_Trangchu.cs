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
            Form s = Application.OpenForms["frm_Sanpham"];
            if (s != null)
            {
               // s.Close();
                  s.Hide(); // giữ ở bộ nhớ
            }
            if (Application.OpenForms["frm_Sach"] == null)
            {
                frm_Sach sach = new frm_Sach();
                sach.FormBorderStyle = FormBorderStyle.None;
                sach.Dock = DockStyle.Fill;
                sach.MdiParent = this;
                sach.Show();
            }
            else Application.OpenForms["frm_Sach"].Activate();
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
    }
}

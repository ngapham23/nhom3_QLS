using QuanLySach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLsach
{
    public partial class frm_Trangchu : Form
    {
        private Timer timer;
        public frm_Trangchu()
        {
            InitializeComponent();

            this.BackgroundImageLayout = ImageLayout.Stretch;
            /*LoadGifFromUrl("https://i.giphy.com/media/v1.Y2lkPTc5MGI3NjExaXFpa2dybjh2NXQwNHI0OGxtenFpN3Y4bmllNWp3d3dmc2xjcTN6MiZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/sIIhZliB2McAo/giphy.gif");*/

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

       /* private void pictureBox1_Click(object sender, EventArgs e)
        {
          *//*  timer = new Timer();
            timer.Interval = 100; // Thời gian kiểm tra (ms)
            timer.Tick += pictureBox1_Click;
            timer.Start();
            pictureBox1.Left += 100;

          
            if (pictureBox1.Left > this.Width)
            {
                pictureBox1.Left = -pictureBox1.Width;
            }
            pictureBox1.Invalidate();*//*
        }


        private void LoadGifFromUrl(string url)
        {
            try
            {
                // Tải GIF từ URL
                using (WebClient webClient = new WebClient())
                {
                    // Tải ảnh GIF và lưu vào tệp tạm thời
                    string tempFilePath = Path.Combine(Path.GetTempPath(), "temp.gif");
                    webClient.DownloadFile(url, tempFilePath);

                    // Gán ảnh GIF cho PictureBox từ tệp tạm
                    pictureBox1.Image = Image.FromFile(tempFilePath);
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }*/
        /* private void pictureBox1_Paint(object sender, PaintEventArgs e)
{
    Graphics g = e.Graphics;

    Font font = new Font("Arial", 30, FontStyle.Bold);
    Brush brush = Brushes.Red; 

    // Vẽ chữ lên PictureBox
    g.DrawString("Ấn Vào Tôi ;))", font, brush, new Point(10, 10)); 
}*/
    }
}

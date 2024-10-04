namespace QuanLySach
{
    partial class frm_TacGia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TacGia));
            this.dt_gridTG = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_mtg = new System.Windows.Forms.Label();
            this.lbl_tentg = new System.Windows.Forms.Label();
            this.lbl_lienlac = new System.Windows.Forms.Label();
            this.txt_mtg = new System.Windows.Forms.TextBox();
            this.txt_lienlac = new System.Windows.Forms.TextBox();
            this.txt_tentg = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_HienThi = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dt_gridTG)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt_gridTG
            // 
            this.dt_gridTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_gridTG.Location = new System.Drawing.Point(202, 217);
            this.dt_gridTG.Name = "dt_gridTG";
            this.dt_gridTG.RowHeadersWidth = 51;
            this.dt_gridTG.RowTemplate.Height = 24;
            this.dt_gridTG.Size = new System.Drawing.Size(469, 445);
            this.dt_gridTG.TabIndex = 13;
            this.dt_gridTG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_gridTG_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(564, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quản Lý Tác Giả";
            // 
            // lbl_mtg
            // 
            this.lbl_mtg.AutoSize = true;
            this.lbl_mtg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mtg.Location = new System.Drawing.Point(21, 43);
            this.lbl_mtg.Name = "lbl_mtg";
            this.lbl_mtg.Size = new System.Drawing.Size(99, 22);
            this.lbl_mtg.TabIndex = 2;
            this.lbl_mtg.Text = "Mã tác giả:";
            // 
            // lbl_tentg
            // 
            this.lbl_tentg.AutoSize = true;
            this.lbl_tentg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tentg.Location = new System.Drawing.Point(21, 109);
            this.lbl_tentg.Name = "lbl_tentg";
            this.lbl_tentg.Size = new System.Drawing.Size(103, 22);
            this.lbl_tentg.TabIndex = 3;
            this.lbl_tentg.Text = "Tên tác giả:";
            // 
            // lbl_lienlac
            // 
            this.lbl_lienlac.AutoSize = true;
            this.lbl_lienlac.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lienlac.Location = new System.Drawing.Point(27, 171);
            this.lbl_lienlac.Name = "lbl_lienlac";
            this.lbl_lienlac.Size = new System.Drawing.Size(87, 22);
            this.lbl_lienlac.TabIndex = 4;
            this.lbl_lienlac.Text = "Quốc gia:";
            // 
            // txt_mtg
            // 
            this.txt_mtg.Location = new System.Drawing.Point(148, 32);
            this.txt_mtg.Name = "txt_mtg";
            this.txt_mtg.Size = new System.Drawing.Size(191, 33);
            this.txt_mtg.TabIndex = 5;
            // 
            // txt_lienlac
            // 
            this.txt_lienlac.Location = new System.Drawing.Point(148, 165);
            this.txt_lienlac.Name = "txt_lienlac";
            this.txt_lienlac.Size = new System.Drawing.Size(191, 33);
            this.txt_lienlac.TabIndex = 7;
            // 
            // txt_tentg
            // 
            this.txt_tentg.Location = new System.Drawing.Point(148, 103);
            this.txt_tentg.Name = "txt_tentg";
            this.txt_tentg.Size = new System.Drawing.Size(191, 33);
            this.txt_tentg.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_mtg);
            this.groupBox1.Controls.Add(this.lbl_tentg);
            this.groupBox1.Controls.Add(this.lbl_lienlac);
            this.groupBox1.Controls.Add(this.txt_mtg);
            this.groupBox1.Controls.Add(this.txt_lienlac);
            this.groupBox1.Controls.Add(this.txt_tentg);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(735, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 222);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý tác giả";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(1012, 494);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 34);
            this.btn_xoa.TabIndex = 16;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(883, 494);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(80, 34);
            this.btn_sua.TabIndex = 15;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(735, 494);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(81, 34);
            this.btn_them.TabIndex = 14;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(741, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tìm Kiếm";
            // 
            // btn_HienThi
            // 
            this.btn_HienThi.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HienThi.Location = new System.Drawing.Point(218, 173);
            this.btn_HienThi.Name = "btn_HienThi";
            this.btn_HienThi.Size = new System.Drawing.Size(181, 38);
            this.btn_HienThi.TabIndex = 20;
            this.btn_HienThi.Text = "Hiện thị tất cả";
            this.btn_HienThi.UseVisualStyleBackColor = true;
            this.btn_HienThi.Click += new System.EventHandler(this.btn_HienThi_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.Location = new System.Drawing.Point(883, 145);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(209, 33);
            this.txt_TimKiem.TabIndex = 19;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // frm_TacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1570, 824);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_HienThi);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.dt_gridTG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Name = "frm_TacGia";
            this.Text = "frm_TacGia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_TacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_gridTG)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_gridTG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_mtg;
        private System.Windows.Forms.Label lbl_tentg;
        private System.Windows.Forms.Label lbl_lienlac;
        private System.Windows.Forms.TextBox txt_mtg;
        private System.Windows.Forms.TextBox txt_lienlac;
        private System.Windows.Forms.TextBox txt_tentg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_HienThi;
        private System.Windows.Forms.TextBox txt_TimKiem;
    }
}
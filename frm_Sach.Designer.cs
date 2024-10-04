namespace QuanLySach
{
    partial class frm_Sach
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Sach));
            this.dtgv_sach = new System.Windows.Forms.DataGridView();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_MaNXB = new System.Windows.Forms.ComboBox();
            this.cb_MaTacGia = new System.Windows.Forms.ComboBox();
            this.cb_MaTheLoai = new System.Windows.Forms.ComboBox();
            this.theLoaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLsachDataSet = new QLsach.QLsachDataSet();
            this.txt_GiaBan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.txt_TenSach = new System.Windows.Forms.TextBox();
            this.txt_MaSach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_HienThi = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lopChungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.frmTheLoaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.theLoaiTableAdapter = new QLsach.QLsachDataSetTableAdapters.TheLoaiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_sach)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLsachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopChungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmTheLoaiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_sach
            // 
            this.dtgv_sach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_sach.Location = new System.Drawing.Point(618, 141);
            this.dtgv_sach.Margin = new System.Windows.Forms.Padding(4);
            this.dtgv_sach.Name = "dtgv_sach";
            this.dtgv_sach.RowHeadersWidth = 51;
            this.dtgv_sach.Size = new System.Drawing.Size(739, 617);
            this.dtgv_sach.TabIndex = 27;
            this.dtgv_sach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_sach_CellClick);
            this.dtgv_sach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_sach_CellContentClick);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_timkiem.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Location = new System.Drawing.Point(1296, 27);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(117, 42);
            this.btn_timkiem.TabIndex = 25;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_timkiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_timkiem.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Location = new System.Drawing.Point(1006, 35);
            this.txt_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(282, 32);
            this.txt_timkiem.TabIndex = 21;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(399, 528);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(117, 42);
            this.btn_xoa.TabIndex = 24;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(230, 528);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(117, 42);
            this.btn_sua.TabIndex = 23;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(62, 528);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(117, 42);
            this.btn_them.TabIndex = 22;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_MaNXB);
            this.groupBox1.Controls.Add(this.cb_MaTacGia);
            this.groupBox1.Controls.Add(this.cb_MaTheLoai);
            this.groupBox1.Controls.Add(this.txt_GiaBan);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_SoLuong);
            this.groupBox1.Controls.Add(this.txt_TenSach);
            this.groupBox1.Controls.Add(this.txt_MaSach);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 70);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(548, 450);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Sách";
            // 
            // cb_MaNXB
            // 
            this.cb_MaNXB.FormattingEnabled = true;
            this.cb_MaNXB.Location = new System.Drawing.Point(184, 325);
            this.cb_MaNXB.Name = "cb_MaNXB";
            this.cb_MaNXB.Size = new System.Drawing.Size(297, 32);
            this.cb_MaNXB.TabIndex = 32;
            // 
            // cb_MaTacGia
            // 
            this.cb_MaTacGia.FormattingEnabled = true;
            this.cb_MaTacGia.Location = new System.Drawing.Point(184, 378);
            this.cb_MaTacGia.Name = "cb_MaTacGia";
            this.cb_MaTacGia.Size = new System.Drawing.Size(297, 32);
            this.cb_MaTacGia.TabIndex = 31;
            // 
            // cb_MaTheLoai
            // 
            this.cb_MaTheLoai.DataSource = this.theLoaiBindingSource;
            this.cb_MaTheLoai.FormattingEnabled = true;
            this.cb_MaTheLoai.Location = new System.Drawing.Point(184, 270);
            this.cb_MaTheLoai.Name = "cb_MaTheLoai";
            this.cb_MaTheLoai.Size = new System.Drawing.Size(297, 32);
            this.cb_MaTheLoai.TabIndex = 30;
            this.cb_MaTheLoai.SelectedIndexChanged += new System.EventHandler(this.cb_MaTheLoai_SelectedIndexChanged);
            // 
            // theLoaiBindingSource
            // 
            this.theLoaiBindingSource.DataMember = "TheLoai";
            this.theLoaiBindingSource.DataSource = this.qLsachDataSet;
            // 
            // qLsachDataSet
            // 
            this.qLsachDataSet.DataSetName = "QLsachDataSet";
            this.qLsachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_GiaBan
            // 
            this.txt_GiaBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_GiaBan.Location = new System.Drawing.Point(184, 217);
            this.txt_GiaBan.Margin = new System.Windows.Forms.Padding(4);
            this.txt_GiaBan.Name = "txt_GiaBan";
            this.txt_GiaBan.Size = new System.Drawing.Size(297, 32);
            this.txt_GiaBan.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 220);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Giá Bán";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SoLuong.Location = new System.Drawing.Point(184, 169);
            this.txt_SoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(297, 32);
            this.txt_SoLuong.TabIndex = 8;
            // 
            // txt_TenSach
            // 
            this.txt_TenSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenSach.Location = new System.Drawing.Point(184, 116);
            this.txt_TenSach.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenSach.Name = "txt_TenSach";
            this.txt_TenSach.Size = new System.Drawing.Size(297, 32);
            this.txt_TenSach.TabIndex = 7;
            // 
            // txt_MaSach
            // 
            this.txt_MaSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaSach.Location = new System.Drawing.Point(184, 62);
            this.txt_MaSach.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaSach.Name = "txt_MaSach";
            this.txt_MaSach.Size = new System.Drawing.Size(297, 32);
            this.txt_MaSach.TabIndex = 6;
            this.txt_MaSach.TextChanged += new System.EventHandler(this.txt_MaSach_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 382);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Mã tác giả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 325);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã NXB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 270);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã thể loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "QUẢN LÝ SÁCH";
            // 
            // btn_HienThi
            // 
            this.btn_HienThi.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HienThi.Location = new System.Drawing.Point(639, 91);
            this.btn_HienThi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_HienThi.Name = "btn_HienThi";
            this.btn_HienThi.Size = new System.Drawing.Size(273, 42);
            this.btn_HienThi.TabIndex = 29;
            this.btn_HienThi.Text = "Hiện thị tất cả";
            this.btn_HienThi.UseVisualStyleBackColor = true;
            this.btn_HienThi.Click += new System.EventHandler(this.btn_HienThi_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(862, 37);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "Nhập tên sách";
            // 
            // lopChungBindingSource
            // 
            this.lopChungBindingSource.DataSource = typeof(QuanLySach.LopChung);
            // 
            // frmTheLoaiBindingSource
            // 
            this.frmTheLoaiBindingSource.DataSource = typeof(QuanLySach.frm_TheLoai);
            // 
            // theLoaiTableAdapter
            // 
            this.theLoaiTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1424, 862);
            this.ControlBox = false;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_HienThi);
            this.Controls.Add(this.dtgv_sach);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_Sach";
            this.Text = "frm_Sach";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Sach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_sach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLsachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopChungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmTheLoaiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgv_sach;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.TextBox txt_TenSach;
        private System.Windows.Forms.TextBox txt_MaSach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_GiaBan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_HienThi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_MaNXB;
        private System.Windows.Forms.ComboBox cb_MaTacGia;
        private System.Windows.Forms.ComboBox cb_MaTheLoai;
        private System.Windows.Forms.BindingSource frmTheLoaiBindingSource;
        private System.Windows.Forms.BindingSource lopChungBindingSource;
        private QLsach.QLsachDataSet qLsachDataSet;
        private System.Windows.Forms.BindingSource theLoaiBindingSource;
        private QLsach.QLsachDataSetTableAdapters.TheLoaiTableAdapter theLoaiTableAdapter;
    }
}
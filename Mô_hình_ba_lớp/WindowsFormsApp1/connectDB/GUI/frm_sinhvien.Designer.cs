namespace connectDB
{
    partial class app_quanly_sinhvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(app_quanly_sinhvien));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.txt_masv = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.lbCount = new System.Windows.Forms.Label();
            this.combox_khoa = new System.Windows.Forms.ComboBox();
            this.button_load = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lb_masv = new System.Windows.Forms.Label();
            this.lb_hoten = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.image_sv = new System.Windows.Forms.PictureBox();
            this.txt_hinhanh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_sv)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(156, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(538, 227);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(156, 164);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(71, 35);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(156, 112);
            this.txt_hoten.Multiline = true;
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(314, 30);
            this.txt_hoten.TabIndex = 2;
            // 
            // txt_masv
            // 
            this.txt_masv.Location = new System.Drawing.Point(156, 70);
            this.txt_masv.Multiline = true;
            this.txt_masv.Name = "txt_masv";
            this.txt_masv.Size = new System.Drawing.Size(314, 30);
            this.txt_masv.TabIndex = 3;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(233, 164);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 35);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(314, 164);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 35);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(395, 164);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 35);
            this.btnCount.TabIndex = 6;
            this.btnCount.Text = "Đếm";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(496, 125);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(97, 17);
            this.lbCount.TabIndex = 7;
            this.lbCount.Text = "Đếm sinh viên";
            // 
            // combox_khoa
            // 
            this.combox_khoa.DropDownHeight = 150;
            this.combox_khoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_khoa.FormattingEnabled = true;
            this.combox_khoa.IntegralHeight = false;
            this.combox_khoa.Location = new System.Drawing.Point(499, 70);
            this.combox_khoa.Name = "combox_khoa";
            this.combox_khoa.Size = new System.Drawing.Size(195, 24);
            this.combox_khoa.TabIndex = 9;
            this.combox_khoa.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button_load
            // 
            this.button_load.Location = new System.Drawing.Point(783, 458);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(110, 50);
            this.button_load.TabIndex = 10;
            this.button_load.Text = "Load";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(156, 221);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(279, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // lb_masv
            // 
            this.lb_masv.AutoSize = true;
            this.lb_masv.Location = new System.Drawing.Point(49, 77);
            this.lb_masv.Name = "lb_masv";
            this.lb_masv.Size = new System.Drawing.Size(87, 17);
            this.lb_masv.TabIndex = 11;
            this.lb_masv.Text = "Mã sinh viên";
            // 
            // lb_hoten
            // 
            this.lb_hoten.AutoSize = true;
            this.lb_hoten.Location = new System.Drawing.Point(49, 115);
            this.lb_hoten.Name = "lb_hoten";
            this.lb_hoten.Size = new System.Drawing.Size(50, 17);
            this.lb_hoten.TabIndex = 12;
            this.lb_hoten.Text = "Họ tên";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(521, 164);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(140, 35);
            this.btn_search.TabIndex = 13;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(499, 221);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(195, 22);
            this.txt_search.TabIndex = 14;
            // 
            // image_sv
            // 
            this.image_sv.Image = ((System.Drawing.Image)(resources.GetObject("image_sv.Image")));
            this.image_sv.Location = new System.Drawing.Point(719, 70);
            this.image_sv.Name = "image_sv";
            this.image_sv.Size = new System.Drawing.Size(215, 212);
            this.image_sv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image_sv.TabIndex = 15;
            this.image_sv.TabStop = false;
            this.image_sv.Click += new System.EventHandler(this.add_image);
            // 
            // txt_hinhanh
            // 
            this.txt_hinhanh.Location = new System.Drawing.Point(719, 306);
            this.txt_hinhanh.Name = "txt_hinhanh";
            this.txt_hinhanh.Size = new System.Drawing.Size(215, 22);
            this.txt_hinhanh.TabIndex = 16;
            // 
            // app_quanly_sinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 544);
            this.Controls.Add(this.txt_hinhanh);
            this.Controls.Add(this.image_sv);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lb_hoten);
            this.Controls.Add(this.lb_masv);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.combox_khoa);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txt_masv);
            this.Controls.Add(this.txt_hoten);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridView1);
            this.Name = "app_quanly_sinhvien";
            this.Text = "App sinh viên";
            this.Load += new System.EventHandler(this.frm_sinhvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_sv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button btnThem;
        public System.Windows.Forms.TextBox txt_hoten;
        public System.Windows.Forms.TextBox txt_masv;
        public System.Windows.Forms.Button btnXoa;
        public System.Windows.Forms.Button btnSua;
        public System.Windows.Forms.Button btnCount;
        public System.Windows.Forms.Label lbCount;
        public System.Windows.Forms.ComboBox combox_khoa;
        public System.Windows.Forms.Button button_load;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Label lb_masv;
        public System.Windows.Forms.Label lb_hoten;
        public System.Windows.Forms.Button btn_search;
        public System.Windows.Forms.TextBox txt_search;
        public System.Windows.Forms.PictureBox image_sv;
        public System.Windows.Forms.TextBox txt_hinhanh;
    }
}
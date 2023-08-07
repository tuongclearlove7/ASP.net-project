using System.Drawing;

namespace TrầnThếTường9157_đồ_án
{
    partial class form_quanly
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_load = new System.Windows.Forms.Button();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.txt_maunv = new System.Windows.Forms.TextBox();
            this.img_player = new System.Windows.Forms.PictureBox();
            this.txt_hinhanhnv = new System.Windows.Forms.TextBox();
            this.txt_nlnv = new System.Windows.Forms.TextBox();
            this.lb_tennv = new System.Windows.Forms.Label();
            this.lb_mau = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_them_nhanvat = new System.Windows.Forms.Button();
            this.btn_sua_nhanvat = new System.Windows.Forms.Button();
            this.btn_xoa_nhanvat = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.img_user = new System.Windows.Forms.PictureBox();
            this.lb_player = new System.Windows.Forms.Label();
            this.lb_nv = new System.Windows.Forms.Label();
            this.btn_sapxep = new System.Windows.Forms.Button();
            this.btnDX = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_manc = new System.Windows.Forms.Label();
            this.chon_nhanvat = new System.Windows.Forms.ComboBox();
            this.lb_nlnv = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_nc = new System.Windows.Forms.TabPage();
            this.btnXoa_nc = new System.Windows.Forms.Button();
            this.tab_nv = new System.Windows.Forms.TabPage();
            this.tab_tool = new System.Windows.Forms.TabPage();
            this.btn_query = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_query = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_user)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_nc.SuspendLayout();
            this.tab_nv.SuspendLayout();
            this.tab_tool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(753, 388);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_load
            // 
            this.btn_load.BackgroundImage = global::TrầnThếTường9157_đồ_án.Properties.Resources.aaaa;
            this.btn_load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_load.Location = new System.Drawing.Point(465, 684);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(88, 69);
            this.btn_load.TabIndex = 7;
            this.btn_load.Text = "Reload";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // txt_tennv
            // 
            this.txt_tennv.Location = new System.Drawing.Point(88, 477);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(313, 22);
            this.txt_tennv.TabIndex = 8;
            // 
            // txt_maunv
            // 
            this.txt_maunv.Location = new System.Drawing.Point(88, 675);
            this.txt_maunv.Name = "txt_maunv";
            this.txt_maunv.Size = new System.Drawing.Size(313, 22);
            this.txt_maunv.TabIndex = 9;
            // 
            // img_player
            // 
            this.img_player.InitialImage = null;
            this.img_player.Location = new System.Drawing.Point(239, 145);
            this.img_player.Name = "img_player";
            this.img_player.Size = new System.Drawing.Size(211, 161);
            this.img_player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_player.TabIndex = 10;
            this.img_player.TabStop = false;
            this.img_player.Click += new System.EventHandler(this.img_player_Click);
            // 
            // txt_hinhanhnv
            // 
            this.txt_hinhanhnv.Location = new System.Drawing.Point(88, 537);
            this.txt_hinhanhnv.Name = "txt_hinhanhnv";
            this.txt_hinhanhnv.Size = new System.Drawing.Size(313, 22);
            this.txt_hinhanhnv.TabIndex = 11;
            // 
            // txt_nlnv
            // 
            this.txt_nlnv.Location = new System.Drawing.Point(88, 603);
            this.txt_nlnv.Name = "txt_nlnv";
            this.txt_nlnv.Size = new System.Drawing.Size(313, 22);
            this.txt_nlnv.TabIndex = 12;
            // 
            // lb_tennv
            // 
            this.lb_tennv.AutoSize = true;
            this.lb_tennv.Location = new System.Drawing.Point(85, 452);
            this.lb_tennv.Name = "lb_tennv";
            this.lb_tennv.Size = new System.Drawing.Size(92, 17);
            this.lb_tennv.TabIndex = 13;
            this.lb_tennv.Text = "Tên nhân vật";
            // 
            // lb_mau
            // 
            this.lb_mau.AutoSize = true;
            this.lb_mau.Location = new System.Drawing.Point(85, 640);
            this.lb_mau.Name = "lb_mau";
            this.lb_mau.Size = new System.Drawing.Size(94, 17);
            this.lb_mau.TabIndex = 14;
            this.lb_mau.Text = "Máu nhân vật";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Hình ảnh của nhận vật";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Chọn nhân vật";
            // 
            // btn_them_nhanvat
            // 
            this.btn_them_nhanvat.Location = new System.Drawing.Point(235, 780);
            this.btn_them_nhanvat.Name = "btn_them_nhanvat";
            this.btn_them_nhanvat.Size = new System.Drawing.Size(75, 35);
            this.btn_them_nhanvat.TabIndex = 18;
            this.btn_them_nhanvat.Text = "Thêm";
            this.btn_them_nhanvat.UseVisualStyleBackColor = true;
            this.btn_them_nhanvat.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua_nhanvat
            // 
            this.btn_sua_nhanvat.Location = new System.Drawing.Point(88, 780);
            this.btn_sua_nhanvat.Name = "btn_sua_nhanvat";
            this.btn_sua_nhanvat.Size = new System.Drawing.Size(68, 34);
            this.btn_sua_nhanvat.TabIndex = 20;
            this.btn_sua_nhanvat.Text = "Sửa";
            this.btn_sua_nhanvat.UseVisualStyleBackColor = true;
            this.btn_sua_nhanvat.Click += new System.EventHandler(this.btn_sua_nhanvat_Click);
            // 
            // btn_xoa_nhanvat
            // 
            this.btn_xoa_nhanvat.Location = new System.Drawing.Point(162, 780);
            this.btn_xoa_nhanvat.Name = "btn_xoa_nhanvat";
            this.btn_xoa_nhanvat.Size = new System.Drawing.Size(67, 34);
            this.btn_xoa_nhanvat.TabIndex = 21;
            this.btn_xoa_nhanvat.Text = "Xóa";
            this.btn_xoa_nhanvat.UseVisualStyleBackColor = true;
            this.btn_xoa_nhanvat.Click += new System.EventHandler(this.btn_xoa_nhanvat_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(752, 281);
            this.dataGridView2.TabIndex = 22;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(88, 743);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(313, 22);
            this.txt_search.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 711);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tìm kiếm người chơi";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(316, 780);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(85, 35);
            this.btn_search.TabIndex = 25;
            this.btn_search.Text = "search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // img_user
            // 
            this.img_user.InitialImage = null;
            this.img_user.Location = new System.Drawing.Point(40, 145);
            this.img_user.Name = "img_user";
            this.img_user.Size = new System.Drawing.Size(193, 161);
            this.img_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_user.TabIndex = 26;
            this.img_user.TabStop = false;
            // 
            // lb_player
            // 
            this.lb_player.AutoSize = true;
            this.lb_player.Location = new System.Drawing.Point(40, 320);
            this.lb_player.Name = "lb_player";
            this.lb_player.Size = new System.Drawing.Size(75, 17);
            this.lb_player.TabIndex = 27;
            this.lb_player.Text = "Người chơi";
            // 
            // lb_nv
            // 
            this.lb_nv.AutoSize = true;
            this.lb_nv.Location = new System.Drawing.Point(385, 320);
            this.lb_nv.Name = "lb_nv";
            this.lb_nv.Size = new System.Drawing.Size(65, 17);
            this.lb_nv.TabIndex = 28;
            this.lb_nv.Text = "Nhân vật";
            // 
            // btn_sapxep
            // 
            this.btn_sapxep.BackgroundImage = global::TrầnThếTường9157_đồ_án.Properties.Resources.aaaa;
            this.btn_sapxep.Location = new System.Drawing.Point(559, 684);
            this.btn_sapxep.Name = "btn_sapxep";
            this.btn_sapxep.Size = new System.Drawing.Size(88, 67);
            this.btn_sapxep.TabIndex = 29;
            this.btn_sapxep.Text = "Sắp xếp";
            this.btn_sapxep.UseVisualStyleBackColor = true;
            this.btn_sapxep.Click += new System.EventHandler(this.btn_sapxep_Click);
            // 
            // btnDX
            // 
            this.btnDX.BackgroundImage = global::TrầnThếTường9157_đồ_án.Properties.Resources.aaaa;
            this.btnDX.Location = new System.Drawing.Point(653, 684);
            this.btnDX.Name = "btnDX";
            this.btnDX.Size = new System.Drawing.Size(88, 67);
            this.btnDX.TabIndex = 30;
            this.btnDX.Text = "Đăng xuất";
            this.btnDX.UseVisualStyleBackColor = true;
            this.btnDX.Click += new System.EventHandler(this.btnDX_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Hình đại diện";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Nhân vật Game";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label.Location = new System.Drawing.Point(143, 66);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(204, 32);
            this.label.TabIndex = 33;
            this.label.Text = "ADMIN FORM";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.lb_manc);
            this.panel1.Controls.Add(this.chon_nhanvat);
            this.panel1.Controls.Add(this.lb_nlnv);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.txt_maunv);
            this.panel1.Controls.Add(this.txt_nlnv);
            this.panel1.Controls.Add(this.lb_mau);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lb_tennv);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_hinhanhnv);
            this.panel1.Controls.Add(this.txt_tennv);
            this.panel1.Controls.Add(this.img_player);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.img_user);
            this.panel1.Controls.Add(this.btn_sua_nhanvat);
            this.panel1.Controls.Add(this.btn_them_nhanvat);
            this.panel1.Controls.Add(this.btn_xoa_nhanvat);
            this.panel1.Controls.Add(this.lb_player);
            this.panel1.Controls.Add(this.lb_nv);
            this.panel1.Location = new System.Drawing.Point(-28, -57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 847);
            this.panel1.TabIndex = 34;
            // 
            // lb_manc
            // 
            this.lb_manc.AutoSize = true;
            this.lb_manc.Location = new System.Drawing.Point(40, 320);
            this.lb_manc.Name = "lb_manc";
            this.lb_manc.Size = new System.Drawing.Size(75, 17);
            this.lb_manc.TabIndex = 36;
            this.lb_manc.Text = "Người chơi";
            this.lb_manc.Visible = false;
            // 
            // chon_nhanvat
            // 
            this.chon_nhanvat.FormattingEnabled = true;
            this.chon_nhanvat.Location = new System.Drawing.Point(88, 414);
            this.chon_nhanvat.Name = "chon_nhanvat";
            this.chon_nhanvat.Size = new System.Drawing.Size(313, 24);
            this.chon_nhanvat.TabIndex = 35;
            this.chon_nhanvat.SelectedIndexChanged += new System.EventHandler(this.cb_nhanvat_SelectedIndexChanged);
            // 
            // lb_nlnv
            // 
            this.lb_nlnv.AutoSize = true;
            this.lb_nlnv.Location = new System.Drawing.Point(85, 572);
            this.lb_nlnv.Name = "lb_nlnv";
            this.lb_nlnv.Size = new System.Drawing.Size(167, 17);
            this.lb_nlnv.TabIndex = 34;
            this.lb_nlnv.Text = "Năng lượng của nhân vật";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_nc);
            this.tabControl1.Controls.Add(this.tab_nv);
            this.tabControl1.Controls.Add(this.tab_tool);
            this.tabControl1.Location = new System.Drawing.Point(445, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(761, 791);
            this.tabControl1.TabIndex = 35;
            // 
            // tab_nc
            // 
            this.tab_nc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab_nc.Controls.Add(this.btnXoa_nc);
            this.tab_nc.Controls.Add(this.dataGridView1);
            this.tab_nc.Controls.Add(this.btn_load);
            this.tab_nc.Controls.Add(this.btnDX);
            this.tab_nc.Controls.Add(this.btn_sapxep);
            this.tab_nc.Location = new System.Drawing.Point(4, 25);
            this.tab_nc.Name = "tab_nc";
            this.tab_nc.Padding = new System.Windows.Forms.Padding(3);
            this.tab_nc.Size = new System.Drawing.Size(753, 762);
            this.tab_nc.TabIndex = 0;
            this.tab_nc.Text = "Người chơi";
            this.tab_nc.UseVisualStyleBackColor = true;
            // 
            // btnXoa_nc
            // 
            this.btnXoa_nc.Location = new System.Drawing.Point(-1, 427);
            this.btnXoa_nc.Name = "btnXoa_nc";
            this.btnXoa_nc.Size = new System.Drawing.Size(741, 51);
            this.btnXoa_nc.TabIndex = 31;
            this.btnXoa_nc.Text = "XÓA NGƯỜI CHƠI";
            this.btnXoa_nc.UseVisualStyleBackColor = true;
            this.btnXoa_nc.Click += new System.EventHandler(this.btnXoa_nc_Click);
            // 
            // tab_nv
            // 
            this.tab_nv.BackgroundImage = global::TrầnThếTường9157_đồ_án.Properties.Resources.bgblue;
            this.tab_nv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab_nv.Controls.Add(this.dataGridView2);
            this.tab_nv.Location = new System.Drawing.Point(4, 25);
            this.tab_nv.Name = "tab_nv";
            this.tab_nv.Padding = new System.Windows.Forms.Padding(3);
            this.tab_nv.Size = new System.Drawing.Size(753, 762);
            this.tab_nv.TabIndex = 1;
            this.tab_nv.Text = "Nhân vật";
            this.tab_nv.UseVisualStyleBackColor = true;
            // 
            // tab_tool
            // 
            this.tab_tool.Controls.Add(this.btn_query);
            this.tab_tool.Controls.Add(this.label6);
            this.tab_tool.Controls.Add(this.txt_query);
            this.tab_tool.Controls.Add(this.dataGridView3);
            this.tab_tool.Location = new System.Drawing.Point(4, 25);
            this.tab_tool.Name = "tab_tool";
            this.tab_tool.Padding = new System.Windows.Forms.Padding(3);
            this.tab_tool.Size = new System.Drawing.Size(753, 762);
            this.tab_tool.TabIndex = 2;
            this.tab_tool.Text = "Cộng cụ";
            this.tab_tool.UseVisualStyleBackColor = true;
            // 
            // btn_query
            // 
            this.btn_query.Location = new System.Drawing.Point(3, 553);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(747, 81);
            this.btn_query.TabIndex = 26;
            this.btn_query.Text = "QUERY";
            this.btn_query.UseVisualStyleBackColor = true;
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Nhập vào câu lệnh SQL để truy vấn dữ liệu";
            // 
            // txt_query
            // 
            this.txt_query.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_query.Location = new System.Drawing.Point(3, 405);
            this.txt_query.Multiline = true;
            this.txt_query.Name = "txt_query";
            this.txt_query.Size = new System.Drawing.Size(747, 100);
            this.txt_query.TabIndex = 24;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(752, 281);
            this.dataGridView3.TabIndex = 23;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // form_quanly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1202, 783);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "form_quanly";
            this.Text = "Ứng dụng quản lý người chơi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_ql_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_user)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_nc.ResumeLayout(false);
            this.tab_nv.ResumeLayout(false);
            this.tab_tool.ResumeLayout(false);
            this.tab_tool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_load;
        public System.Windows.Forms.TextBox txt_tennv;
        public System.Windows.Forms.TextBox txt_maunv;
        public System.Windows.Forms.PictureBox img_player;
        public System.Windows.Forms.TextBox txt_hinhanhnv;
        public System.Windows.Forms.TextBox txt_nlnv;
        private System.Windows.Forms.Label lb_tennv;
        private System.Windows.Forms.Label lb_mau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_them_nhanvat;
        private System.Windows.Forms.Button btn_sua_nhanvat;
        private System.Windows.Forms.Button btn_xoa_nhanvat;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        public System.Windows.Forms.PictureBox img_user;
        private System.Windows.Forms.Label lb_player;
        public System.Windows.Forms.Label lb_nv;
        private System.Windows.Forms.Button btn_sapxep;
        private System.Windows.Forms.Button btnDX;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_nc;
        private System.Windows.Forms.TabPage tab_nv;
        private System.Windows.Forms.TabPage tab_tool;
        private System.Windows.Forms.Label lb_nlnv;
        public System.Windows.Forms.ComboBox chon_nhanvat;
        private System.Windows.Forms.Button btnXoa_nc;
        private System.Windows.Forms.Label lb_manc;
        public System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox txt_query;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_query;
    }
}
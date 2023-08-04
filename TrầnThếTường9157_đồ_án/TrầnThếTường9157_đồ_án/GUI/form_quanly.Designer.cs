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
            this.cb_nhanvat = new System.Windows.Forms.ComboBox();
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
            this.lb_nlnv = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_user)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(141, 346);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(929, 211);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cb_nhanvat
            // 
            this.cb_nhanvat.FormattingEnabled = true;
            this.cb_nhanvat.Location = new System.Drawing.Point(141, 66);
            this.cb_nhanvat.Name = "cb_nhanvat";
            this.cb_nhanvat.Size = new System.Drawing.Size(222, 24);
            this.cb_nhanvat.TabIndex = 6;
            this.cb_nhanvat.SelectedIndexChanged += new System.EventHandler(this.cb_nhanvat_SelectedIndexChanged);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(12, 35);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(88, 69);
            this.btn_load.TabIndex = 7;
            this.btn_load.Text = "Reload";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // txt_tennv
            // 
            this.txt_tennv.Location = new System.Drawing.Point(141, 146);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(222, 22);
            this.txt_tennv.TabIndex = 8;
            // 
            // txt_maunv
            // 
            this.txt_maunv.Location = new System.Drawing.Point(141, 214);
            this.txt_maunv.Name = "txt_maunv";
            this.txt_maunv.Size = new System.Drawing.Size(222, 22);
            this.txt_maunv.TabIndex = 9;
            // 
            // img_player
            // 
            this.img_player.InitialImage = null;
            this.img_player.Location = new System.Drawing.Point(658, 66);
            this.img_player.Name = "img_player";
            this.img_player.Size = new System.Drawing.Size(192, 206);
            this.img_player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_player.TabIndex = 10;
            this.img_player.TabStop = false;
            this.img_player.Click += new System.EventHandler(this.img_player_Click);
            // 
            // txt_hinhanhnv
            // 
            this.txt_hinhanhnv.Location = new System.Drawing.Point(395, 146);
            this.txt_hinhanhnv.Name = "txt_hinhanhnv";
            this.txt_hinhanhnv.Size = new System.Drawing.Size(222, 22);
            this.txt_hinhanhnv.TabIndex = 11;
            // 
            // txt_nlnv
            // 
            this.txt_nlnv.Location = new System.Drawing.Point(395, 68);
            this.txt_nlnv.Name = "txt_nlnv";
            this.txt_nlnv.Size = new System.Drawing.Size(222, 22);
            this.txt_nlnv.TabIndex = 12;
            // 
            // lb_tennv
            // 
            this.lb_tennv.AutoSize = true;
            this.lb_tennv.Location = new System.Drawing.Point(142, 110);
            this.lb_tennv.Name = "lb_tennv";
            this.lb_tennv.Size = new System.Drawing.Size(92, 17);
            this.lb_tennv.TabIndex = 13;
            this.lb_tennv.Text = "Tên nhân vật";
            // 
            // lb_mau
            // 
            this.lb_mau.AutoSize = true;
            this.lb_mau.Location = new System.Drawing.Point(146, 183);
            this.lb_mau.Name = "lb_mau";
            this.lb_mau.Size = new System.Drawing.Size(94, 17);
            this.lb_mau.TabIndex = 14;
            this.lb_mau.Text = "Máu nhân vật";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Hình ảnh của nhận vật";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Chọn nhân vật";
            // 
            // btn_them_nhanvat
            // 
            this.btn_them_nhanvat.Location = new System.Drawing.Point(141, 251);
            this.btn_them_nhanvat.Name = "btn_them_nhanvat";
            this.btn_them_nhanvat.Size = new System.Drawing.Size(70, 35);
            this.btn_them_nhanvat.TabIndex = 18;
            this.btn_them_nhanvat.Text = "Thêm";
            this.btn_them_nhanvat.UseVisualStyleBackColor = true;
            this.btn_them_nhanvat.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // lb_nlnv
            // 
            this.lb_nlnv.AutoSize = true;
            this.lb_nlnv.BackColor = System.Drawing.SystemColors.Control;
            this.lb_nlnv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lb_nlnv.Location = new System.Drawing.Point(392, 35);
            this.lb_nlnv.Name = "lb_nlnv";
            this.lb_nlnv.Size = new System.Drawing.Size(167, 17);
            this.lb_nlnv.TabIndex = 19;
            this.lb_nlnv.Text = "Năng lượng của nhân vật";
            // 
            // btn_sua_nhanvat
            // 
            this.btn_sua_nhanvat.Location = new System.Drawing.Point(217, 251);
            this.btn_sua_nhanvat.Name = "btn_sua_nhanvat";
            this.btn_sua_nhanvat.Size = new System.Drawing.Size(68, 34);
            this.btn_sua_nhanvat.TabIndex = 20;
            this.btn_sua_nhanvat.Text = "Sửa";
            this.btn_sua_nhanvat.UseVisualStyleBackColor = true;
            this.btn_sua_nhanvat.Click += new System.EventHandler(this.btn_sua_nhanvat_Click);
            // 
            // btn_xoa_nhanvat
            // 
            this.btn_xoa_nhanvat.Location = new System.Drawing.Point(291, 251);
            this.btn_xoa_nhanvat.Name = "btn_xoa_nhanvat";
            this.btn_xoa_nhanvat.Size = new System.Drawing.Size(72, 34);
            this.btn_xoa_nhanvat.TabIndex = 21;
            this.btn_xoa_nhanvat.Text = "Xóa";
            this.btn_xoa_nhanvat.UseVisualStyleBackColor = true;
            this.btn_xoa_nhanvat.Click += new System.EventHandler(this.btn_xoa_nhanvat_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(141, 575);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(929, 186);
            this.dataGridView2.TabIndex = 22;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(395, 214);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(222, 22);
            this.txt_search.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tìm kiếm người chơi";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(455, 252);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(88, 35);
            this.btn_search.TabIndex = 25;
            this.btn_search.Text = "search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // img_user
            // 
            this.img_user.InitialImage = null;
            this.img_user.Location = new System.Drawing.Point(878, 68);
            this.img_user.Name = "img_user";
            this.img_user.Size = new System.Drawing.Size(192, 206);
            this.img_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_user.TabIndex = 26;
            this.img_user.TabStop = false;
            // 
            // lb_player
            // 
            this.lb_player.AutoSize = true;
            this.lb_player.Location = new System.Drawing.Point(981, 35);
            this.lb_player.Name = "lb_player";
            this.lb_player.Size = new System.Drawing.Size(75, 17);
            this.lb_player.TabIndex = 27;
            this.lb_player.Text = "Người chơi";
            // 
            // lb_nv
            // 
            this.lb_nv.AutoSize = true;
            this.lb_nv.Location = new System.Drawing.Point(785, 35);
            this.lb_nv.Name = "lb_nv";
            this.lb_nv.Size = new System.Drawing.Size(65, 17);
            this.lb_nv.TabIndex = 28;
            this.lb_nv.Text = "Nhân vật";
            // 
            // btn_sapxep
            // 
            this.btn_sapxep.Location = new System.Drawing.Point(12, 124);
            this.btn_sapxep.Name = "btn_sapxep";
            this.btn_sapxep.Size = new System.Drawing.Size(88, 67);
            this.btn_sapxep.TabIndex = 29;
            this.btn_sapxep.Text = "Sắp xếp";
            this.btn_sapxep.UseVisualStyleBackColor = true;
            this.btn_sapxep.Click += new System.EventHandler(this.btn_sapxep_Click);
            // 
            // btnDX
            // 
            this.btnDX.Location = new System.Drawing.Point(12, 218);
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
            this.label4.Location = new System.Drawing.Point(875, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Hình đại diện";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(655, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Nhân vật Game";
            // 
            // form_quanly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::TrầnThếTường9157_đồ_án.Properties.Resources.bgblue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1202, 783);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDX);
            this.Controls.Add(this.btn_sapxep);
            this.Controls.Add(this.lb_nv);
            this.Controls.Add(this.lb_player);
            this.Controls.Add(this.img_user);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_xoa_nhanvat);
            this.Controls.Add(this.btn_sua_nhanvat);
            this.Controls.Add(this.lb_nlnv);
            this.Controls.Add(this.btn_them_nhanvat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_mau);
            this.Controls.Add(this.lb_tennv);
            this.Controls.Add(this.txt_nlnv);
            this.Controls.Add(this.txt_hinhanhnv);
            this.Controls.Add(this.img_player);
            this.Controls.Add(this.txt_maunv);
            this.Controls.Add(this.txt_tennv);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.cb_nhanvat);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "form_quanly";
            this.Text = "form_quanly";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_ql_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.ComboBox cb_nhanvat;
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
        private System.Windows.Forms.Label lb_nlnv;
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
    }
}
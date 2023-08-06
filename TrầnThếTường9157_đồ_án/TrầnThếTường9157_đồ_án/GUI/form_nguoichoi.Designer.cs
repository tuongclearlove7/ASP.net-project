namespace TrầnThếTường9157_đồ_án
{
    partial class form_nguoichoi
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_home = new System.Windows.Forms.TabPage();
            this.lb_doinv = new System.Windows.Forms.Label();
            this.btn_doi = new System.Windows.Forms.Button();
            this.chon_nhanvat = new System.Windows.Forms.ComboBox();
            this.img_nv = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_filename = new System.Windows.Forms.TextBox();
            this.btn_doianh = new System.Windows.Forms.Button();
            this.lb_ngdk = new System.Windows.Forms.Label();
            this.lb_sdt = new System.Windows.Forms.Label();
            this.lb_ten_nc = new System.Windows.Forms.Label();
            this.lb_nc = new System.Windows.Forms.Label();
            this.img_nc = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.tab_cc = new System.Windows.Forms.TabPage();
            this.btn_playgame = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tab_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_nv)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_nc)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_home);
            this.tabControl1.Controls.Add(this.tab_cc);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(944, 584);
            this.tabControl1.TabIndex = 1;
            // 
            // tab_home
            // 
            this.tab_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab_home.Controls.Add(this.btn_playgame);
            this.tab_home.Controls.Add(this.lb_doinv);
            this.tab_home.Controls.Add(this.btn_doi);
            this.tab_home.Controls.Add(this.chon_nhanvat);
            this.tab_home.Controls.Add(this.img_nv);
            this.tab_home.Controls.Add(this.label1);
            this.tab_home.Controls.Add(this.panel1);
            this.tab_home.Controls.Add(this.btn_logout);
            this.tab_home.Location = new System.Drawing.Point(4, 25);
            this.tab_home.Name = "tab_home";
            this.tab_home.Padding = new System.Windows.Forms.Padding(3);
            this.tab_home.Size = new System.Drawing.Size(936, 555);
            this.tab_home.TabIndex = 0;
            this.tab_home.Text = "Thông tin tài khoản";
            this.tab_home.UseVisualStyleBackColor = true;
            // 
            // lb_doinv
            // 
            this.lb_doinv.AutoSize = true;
            this.lb_doinv.Location = new System.Drawing.Point(458, 368);
            this.lb_doinv.Name = "lb_doinv";
            this.lb_doinv.Size = new System.Drawing.Size(88, 17);
            this.lb_doinv.TabIndex = 10;
            this.lb_doinv.Text = "Đổi nhân vật";
            // 
            // btn_doi
            // 
            this.btn_doi.BackgroundImage = global::TrầnThếTường9157_đồ_án.Properties.Resources.bgblue;
            this.btn_doi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_doi.Location = new System.Drawing.Point(461, 437);
            this.btn_doi.Name = "btn_doi";
            this.btn_doi.Size = new System.Drawing.Size(420, 38);
            this.btn_doi.TabIndex = 9;
            this.btn_doi.Text = "Lưu";
            this.btn_doi.UseVisualStyleBackColor = true;
            this.btn_doi.Click += new System.EventHandler(this.btn_doi_Click);
            // 
            // chon_nhanvat
            // 
            this.chon_nhanvat.FormattingEnabled = true;
            this.chon_nhanvat.Location = new System.Drawing.Point(461, 397);
            this.chon_nhanvat.Name = "chon_nhanvat";
            this.chon_nhanvat.Size = new System.Drawing.Size(420, 24);
            this.chon_nhanvat.TabIndex = 8;
            this.chon_nhanvat.SelectedIndexChanged += new System.EventHandler(this.chon_nhanvat_SelectedIndexChanged);
            // 
            // img_nv
            // 
            this.img_nv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img_nv.Location = new System.Drawing.Point(461, 86);
            this.img_nv.Name = "img_nv";
            this.img_nv.Size = new System.Drawing.Size(420, 256);
            this.img_nv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_nv.TabIndex = 3;
            this.img_nv.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(455, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhân vật của bạn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.txt_filename);
            this.panel1.Controls.Add(this.btn_doianh);
            this.panel1.Controls.Add(this.lb_ngdk);
            this.panel1.Controls.Add(this.lb_sdt);
            this.panel1.Controls.Add(this.lb_ten_nc);
            this.panel1.Controls.Add(this.lb_nc);
            this.panel1.Controls.Add(this.img_nc);
            this.panel1.Controls.Add(this.label);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 555);
            this.panel1.TabIndex = 7;
            // 
            // txt_filename
            // 
            this.txt_filename.Location = new System.Drawing.Point(76, 533);
            this.txt_filename.Name = "txt_filename";
            this.txt_filename.Size = new System.Drawing.Size(239, 22);
            this.txt_filename.TabIndex = 12;
            this.txt_filename.Visible = false;
            // 
            // btn_doianh
            // 
            this.btn_doianh.BackgroundImage = global::TrầnThếTường9157_đồ_án.Properties.Resources.aaaa;
            this.btn_doianh.Location = new System.Drawing.Point(56, 437);
            this.btn_doianh.Name = "btn_doianh";
            this.btn_doianh.Size = new System.Drawing.Size(281, 38);
            this.btn_doianh.TabIndex = 10;
            this.btn_doianh.Text = "Thay đổi ảnh đại diện";
            this.btn_doianh.UseVisualStyleBackColor = true;
            this.btn_doianh.Click += new System.EventHandler(this.btn_doianh_Click);
            // 
            // lb_ngdk
            // 
            this.lb_ngdk.AutoSize = true;
            this.lb_ngdk.Location = new System.Drawing.Point(56, 397);
            this.lb_ngdk.Name = "lb_ngdk";
            this.lb_ngdk.Size = new System.Drawing.Size(68, 20);
            this.lb_ngdk.TabIndex = 9;
            this.lb_ngdk.Text = "Người chơi";
            this.lb_ngdk.UseCompatibleTextRendering = true;
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.Location = new System.Drawing.Point(56, 365);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(68, 20);
            this.lb_sdt.TabIndex = 8;
            this.lb_sdt.Text = "Người chơi";
            this.lb_sdt.UseCompatibleTextRendering = true;
            // 
            // lb_ten_nc
            // 
            this.lb_ten_nc.AutoSize = true;
            this.lb_ten_nc.Location = new System.Drawing.Point(56, 332);
            this.lb_ten_nc.Name = "lb_ten_nc";
            this.lb_ten_nc.Size = new System.Drawing.Size(68, 20);
            this.lb_ten_nc.TabIndex = 7;
            this.lb_ten_nc.Text = "Người chơi";
            this.lb_ten_nc.UseCompatibleTextRendering = true;
            // 
            // lb_nc
            // 
            this.lb_nc.AutoSize = true;
            this.lb_nc.Location = new System.Drawing.Point(53, 299);
            this.lb_nc.Name = "lb_nc";
            this.lb_nc.Size = new System.Drawing.Size(75, 17);
            this.lb_nc.TabIndex = 6;
            this.lb_nc.Text = "Người chơi";
            // 
            // img_nc
            // 
            this.img_nc.Location = new System.Drawing.Point(56, 86);
            this.img_nc.Name = "img_nc";
            this.img_nc.Size = new System.Drawing.Size(281, 197);
            this.img_nc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_nc.TabIndex = 1;
            this.img_nc.TabStop = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label.Location = new System.Drawing.Point(50, 33);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(171, 32);
            this.label.TabIndex = 2;
            this.label.Text = "Ảnh đại diện";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_logout
            // 
            this.btn_logout.BackgroundImage = global::TrầnThếTường9157_đồ_án.Properties.Resources.bgblue;
            this.btn_logout.Location = new System.Drawing.Point(786, 504);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(95, 43);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "Đăng xuất";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // tab_cc
            // 
            this.tab_cc.Location = new System.Drawing.Point(4, 25);
            this.tab_cc.Name = "tab_cc";
            this.tab_cc.Size = new System.Drawing.Size(936, 555);
            this.tab_cc.TabIndex = 1;
            this.tab_cc.Text = "Cửa hàng";
            this.tab_cc.UseVisualStyleBackColor = true;
            // 
            // btn_playgame
            // 
            this.btn_playgame.BackgroundImage = global::TrầnThếTường9157_đồ_án.Properties.Resources.bgblue;
            this.btn_playgame.Location = new System.Drawing.Point(461, 504);
            this.btn_playgame.Name = "btn_playgame";
            this.btn_playgame.Size = new System.Drawing.Size(281, 38);
            this.btn_playgame.TabIndex = 13;
            this.btn_playgame.Text = "Vào game";
            this.btn_playgame.UseVisualStyleBackColor = true;
            this.btn_playgame.Click += new System.EventHandler(this.btn_playgame_Click);
            // 
            // form_nguoichoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 584);
            this.Controls.Add(this.tabControl1);
            this.Name = "form_nguoichoi";
            this.Text = "Tài khoản";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_nc_Closing);
            this.tabControl1.ResumeLayout(false);
            this.tab_home.ResumeLayout(false);
            this.tab_home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_nv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_nc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_home;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox img_nv;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.TabPage tab_cc;
        private System.Windows.Forms.ComboBox chon_nhanvat;
        private System.Windows.Forms.Button btn_doi;
        private System.Windows.Forms.Label lb_doinv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_ngdk;
        private System.Windows.Forms.Label lb_sdt;
        private System.Windows.Forms.Label lb_ten_nc;
        public System.Windows.Forms.Label lb_nc;
        public System.Windows.Forms.PictureBox img_nc;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btn_doianh;
        public System.Windows.Forms.TextBox txt_filename;
        private System.Windows.Forms.Button btn_playgame;
    }
}
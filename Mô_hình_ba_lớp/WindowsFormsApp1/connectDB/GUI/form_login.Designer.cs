
namespace connectDB
{
    partial class form_login
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
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.txt_tendangnhap = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lb_tdn = new System.Windows.Forms.Label();
            this.lb_mk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(239, 187);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(278, 22);
            this.txt_matkhau.TabIndex = 0;
            // 
            // txt_tendangnhap
            // 
            this.txt_tendangnhap.Location = new System.Drawing.Point(239, 134);
            this.txt_tendangnhap.Name = "txt_tendangnhap";
            this.txt_tendangnhap.Size = new System.Drawing.Size(278, 22);
            this.txt_tendangnhap.TabIndex = 1;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(346, 250);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 36);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lb_tdn
            // 
            this.lb_tdn.AutoSize = true;
            this.lb_tdn.Location = new System.Drawing.Point(82, 134);
            this.lb_tdn.Name = "lb_tdn";
            this.lb_tdn.Size = new System.Drawing.Size(138, 17);
            this.lb_tdn.TabIndex = 3;
            this.lb_tdn.Text = "Nhập tên đăng nhập";
            // 
            // lb_mk
            // 
            this.lb_mk.AutoSize = true;
            this.lb_mk.Location = new System.Drawing.Point(116, 187);
            this.lb_mk.Name = "lb_mk";
            this.lb_mk.Size = new System.Drawing.Size(104, 17);
            this.lb_mk.TabIndex = 4;
            this.lb_mk.Text = "Nhập mật khẩu";
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_mk);
            this.Controls.Add(this.lb_tdn);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_tendangnhap);
            this.Controls.Add(this.txt_matkhau);
            this.Name = "form_login";
            this.Text = "form_login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txt_matkhau;
        public System.Windows.Forms.TextBox txt_tendangnhap;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lb_tdn;
        private System.Windows.Forms.Label lb_mk;
    }
}
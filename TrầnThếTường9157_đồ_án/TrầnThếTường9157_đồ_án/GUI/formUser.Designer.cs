namespace TrầnThếTường9157_đồ_án
{
    partial class formUser
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
            this.btnDX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDX
            // 
            this.btnDX.BackgroundImage = global::TrầnThếTường9157_đồ_án.Properties.Resources.bgblue;
            this.btnDX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDX.Location = new System.Drawing.Point(658, 348);
            this.btnDX.Name = "btnDX";
            this.btnDX.Size = new System.Drawing.Size(88, 67);
            this.btnDX.TabIndex = 31;
            this.btnDX.Text = "Đăng xuất";
            this.btnDX.UseVisualStyleBackColor = true;
            this.btnDX.Click += new System.EventHandler(this.btnDX_Click);
            // 
            // formUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrầnThếTường9157_đồ_án.Properties.Resources.bgblue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(758, 427);
            this.Controls.Add(this.btnDX);
            this.Name = "formUser";
            this.Text = "formUser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formUser_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDX;
    }
}
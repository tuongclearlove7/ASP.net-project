namespace WindowsFormsApp1
{
    partial class App2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_total = new System.Windows.Forms.Button();
            this.txt_soA = new System.Windows.Forms.TextBox();
            this.txt_soB = new System.Windows.Forms.TextBox();
            this.txt_ketqua = new System.Windows.Forms.TextBox();
            this.button_sub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số A";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết quả";
            // 
            // button_total
            // 
            this.button_total.Location = new System.Drawing.Point(257, 380);
            this.button_total.Name = "button_total";
            this.button_total.Size = new System.Drawing.Size(75, 32);
            this.button_total.TabIndex = 3;
            this.button_total.Text = "+";
            this.button_total.UseVisualStyleBackColor = true;
            this.button_total.Click += new System.EventHandler(this.button_total_Click);
            // 
            // txt_soA
            // 
            this.txt_soA.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txt_soA.Location = new System.Drawing.Point(257, 87);
            this.txt_soA.Multiline = true;
            this.txt_soA.Name = "txt_soA";
            this.txt_soA.Size = new System.Drawing.Size(297, 48);
            this.txt_soA.TabIndex = 5;
            this.txt_soA.TextChanged += new System.EventHandler(this.txt_soA_TextChanged);
            // 
            // txt_soB
            // 
            this.txt_soB.Location = new System.Drawing.Point(257, 178);
            this.txt_soB.Multiline = true;
            this.txt_soB.Name = "txt_soB";
            this.txt_soB.Size = new System.Drawing.Size(297, 53);
            this.txt_soB.TabIndex = 6;
            this.txt_soB.TextChanged += new System.EventHandler(this.txt_soB_TextChanged);
            // 
            // txt_ketqua
            // 
            this.txt_ketqua.Location = new System.Drawing.Point(257, 273);
            this.txt_ketqua.Multiline = true;
            this.txt_ketqua.Name = "txt_ketqua";
            this.txt_ketqua.Size = new System.Drawing.Size(297, 49);
            this.txt_ketqua.TabIndex = 7;
            this.txt_ketqua.TextChanged += new System.EventHandler(this.txt_ketqua_TextChanged);
            // 
            // button_sub
            // 
            this.button_sub.Location = new System.Drawing.Point(339, 380);
            this.button_sub.Name = "button_sub";
            this.button_sub.Size = new System.Drawing.Size(75, 32);
            this.button_sub.TabIndex = 8;
            this.button_sub.Text = "-";
            this.button_sub.UseVisualStyleBackColor = true;
            this.button_sub.Click += new System.EventHandler(this.button_sub_Click);
            // 
            // App2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 540);
            this.Controls.Add(this.button_sub);
            this.Controls.Add(this.txt_ketqua);
            this.Controls.Add(this.txt_soB);
            this.Controls.Add(this.txt_soA);
            this.Controls.Add(this.button_total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Name = "App2";
            this.Text = "App2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_total;
        private System.Windows.Forms.TextBox txt_soA;
        private System.Windows.Forms.TextBox txt_soB;
        private System.Windows.Forms.TextBox txt_ketqua;
        private System.Windows.Forms.Button button_sub;
    }
}
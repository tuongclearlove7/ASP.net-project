namespace WindowsFormsApp1
{
    partial class App
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
            this.button = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(65, 220);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(69, 32);
            this.button.TabIndex = 0;
            this.button.Text = "button";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click_1);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label.Location = new System.Drawing.Point(309, 29);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(156, 32);
            this.label.TabIndex = 1;
            this.label.Text = "Application";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label.Click += new System.EventHandler(this.label_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "button";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(774, 504);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.button);
            this.DoubleBuffered = true;
            this.Name = "App";
            this.Text = "App";
            this.Load += new System.EventHandler(this.App_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button button2;
    }
}


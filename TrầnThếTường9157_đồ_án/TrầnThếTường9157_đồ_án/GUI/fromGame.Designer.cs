namespace TrầnThếTường9157_đồ_án
{
    partial class formGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGame));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_location_p2 = new System.Windows.Forms.Label();
            this.lb_path = new System.Windows.Forms.Label();
            this.location_p1 = new System.Windows.Forms.Label();
            this.bullet_location = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.bullet_player1 = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet_player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_location_p2
            // 
            this.lb_location_p2.AutoSize = true;
            this.lb_location_p2.Location = new System.Drawing.Point(1301, 130);
            this.lb_location_p2.Name = "lb_location_p2";
            this.lb_location_p2.Size = new System.Drawing.Size(0, 17);
            this.lb_location_p2.TabIndex = 3;
            // 
            // lb_path
            // 
            this.lb_path.AutoSize = true;
            this.lb_path.Location = new System.Drawing.Point(291, 245);
            this.lb_path.Name = "lb_path";
            this.lb_path.Size = new System.Drawing.Size(46, 17);
            this.lb_path.TabIndex = 4;
            this.lb_path.Text = "label1";
            // 
            // location_p1
            // 
            this.location_p1.AutoSize = true;
            this.location_p1.Location = new System.Drawing.Point(12, 20);
            this.location_p1.Name = "location_p1";
            this.location_p1.Size = new System.Drawing.Size(46, 17);
            this.location_p1.TabIndex = 8;
            this.location_p1.Text = "label1";
            // 
            // bullet_location
            // 
            this.bullet_location.AutoSize = true;
            this.bullet_location.Location = new System.Drawing.Point(64, 20);
            this.bullet_location.Name = "bullet_location";
            this.bullet_location.Size = new System.Drawing.Size(46, 17);
            this.bullet_location.TabIndex = 9;
            this.bullet_location.Text = "label1";
            // 
            // player
            // 
            this.player.Image = global::TrầnThếTường9157_đồ_án.Properties.Resources.plane1;
            this.player.InitialImage = ((System.Drawing.Image)(resources.GetObject("player.InitialImage")));
            this.player.Location = new System.Drawing.Point(0, 403);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(189, 86);
            this.player.TabIndex = 7;
            this.player.TabStop = false;
            this.player.LocationChanged += new System.EventHandler(this.player_LocationChanged);
            // 
            // bullet_player1
            // 
            this.bullet_player1.Location = new System.Drawing.Point(113, 159);
            this.bullet_player1.Name = "bullet_player1";
            this.bullet_player1.Size = new System.Drawing.Size(27, 24);
            this.bullet_player1.TabIndex = 6;
            this.bullet_player1.TabStop = false;
            this.bullet_player1.LocationChanged += new System.EventHandler(this.bullet_player1_LocationChanged);
            // 
            // player2
            // 
            this.player2.Image = global::TrầnThếTường9157_đồ_án.Properties.Resources.bullet1;
            this.player2.InitialImage = global::TrầnThếTường9157_đồ_án.Properties.Resources.player;
            this.player2.Location = new System.Drawing.Point(131, 417);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(106, 72);
            this.player2.TabIndex = 2;
            this.player2.TabStop = false;
            this.player2.LocationChanged += new System.EventHandler(this.player2_LocationChanged);
            // 
            // formGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 653);
            this.Controls.Add(this.bullet_location);
            this.Controls.Add(this.location_p1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.bullet_player1);
            this.Controls.Add(this.lb_path);
            this.Controls.Add(this.lb_location_p2);
            this.Controls.Add(this.player2);
            this.Name = "formGame";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_game_Closing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IsKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.IsKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet_player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.Label lb_location_p2;
        private System.Windows.Forms.Label lb_path;
        private System.Windows.Forms.PictureBox bullet_player1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label location_p1;
        private System.Windows.Forms.Label bullet_location;
    }
}


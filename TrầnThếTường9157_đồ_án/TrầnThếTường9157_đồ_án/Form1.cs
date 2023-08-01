using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrầnThếTường9157_đồ_án
{
    public partial class Form1 : Form
    {

        bool top, left, right, down;
        int playerMoveRight = 0;
        int speed = 50;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            player.Top = player.Top + 30;
            player2.Top = player.Top + 30;

            if (left == true && player.Left > 0)
            {
                playerMoveRight -= speed;
                if (playerMoveRight < 0)
                {
                    playerMoveRight = 0;
                }
                player.Left = playerMoveRight;
            }
            if (right == true && player.Left < 1050)
            {
                playerMoveRight += speed; 
                //if (playerLeft > this.Width - player.Width)
                //{
                //    playerLeft = this.Width - player.Width; 
                //}
                // player.Image = new Bitmap("image\\player_dambay.gif");
                //  player.Image = Image.FromFile(@"Resources\\player.png");
               
               
                // player.Image = new Bitmap(imagePath);
                player.Left = playerMoveRight;
            }
            if (top == true && player.Top > 0)
            {
                player.Top -= speed;
            }
            if (down == true && player.Top < 600)
            {
                player.Top += speed;
            }



        }

        private void player_LocationChanged(object sender, EventArgs e)
        {
            lb_location_p1.Text = $@"{player.Top.ToString()}, { player.Left.ToString()}";
            
            if (player.Top > 350)
            {
                player.Top = 350;
               
            }
        }

        private void player2_LocationChanged(object sender, EventArgs e)
        {
            lb_location_p2.Text = $@"{player2.Top.ToString()}, { this.Height}";

            if (player2.Top > 370)
            {
                player2.Top = 370;

            }
        }

        private void IsKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                right = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                down = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                top = true;
            }
        }

        private void IsKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                down = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                top = false;
            }
        }
    }
}

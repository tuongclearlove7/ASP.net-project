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
    public partial class formGame : Form
    {

        bool top, left, right, down;
        int playerMoveRight = 0;
        int speed = 50;
        bool shoot;

        public formGame()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            player.Top = player.Top + 30;
            player2.Top = player.Top + 30;

           
            bullet_player1.Image = new Bitmap(Application.StartupPath + "\\Resources\\bullet.png");
            bullet_player1.Top = bullet_player1.Top + 30;
       

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
            location_p1.Text = $@"{player.Top.ToString()}, { player.Left.ToString()}";
            if (player.Top < 0)
            {
                player.Top = -20;

            }
            if (player.Top > 460)
            {
                player.Top = 460;
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


        private void bullet_player1_LocationChanged(object sender, EventArgs e)
        {
            bullet_location.Text = $@"{bullet_player1.Top.ToString()}, { bullet_player1.Left.ToString()}";
            if (bullet_player1.Left > 1200)
            {
                bullet_player1.Left = 100;
            }

            if (bullet_player1.Top > 400)
            {
                bullet_player1.Top = 400;
            }
        }

    
        private void IsKeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.S)
            {
                shoot = true;
            }


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

            if (e.KeyCode == Keys.S)
            {
                shoot = false;
            }

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


        private void form_game_Closing(object sender, FormClosingEventArgs e)
        {

            if (sender is formGame)
            {
                Application.Exit();
            }
        }




    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrầnThếTường9157_đồ_án
{
    public partial class formUser : Form
    {
        public formUser()
        {
            InitializeComponent();
        }

        private void formUser_Closing(object sender, FormClosingEventArgs e)
        {

            if (sender is formUser)
            {
                Application.Exit();
            }
        }

        private void btnDX_Click(object sender, EventArgs e)
        {
            
                formLogin login = new formLogin();
                this.Hide();
                login.Show();
            
        }
    }
}

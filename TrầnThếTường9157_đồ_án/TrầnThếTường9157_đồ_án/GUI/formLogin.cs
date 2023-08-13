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
    public partial class formLogin : Form
    {
        
        BLL.BLL_dangnhap bll_dn;
        public formLogin()
        {
            InitializeComponent();
            bll_dn = new BLL.BLL_dangnhap(this);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            bll_dn.blldangnhap();
            
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            form_register register = new form_register();
            this.Hide();
            register.Show();
        }
    }
}

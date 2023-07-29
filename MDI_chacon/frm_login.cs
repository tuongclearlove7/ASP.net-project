using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_chacon
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
            txt_matkhau.UseSystemPasswordChar = true;


        }

        int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (txt_tendangnhap.Text == "dtu" && txt_matkhau.Text == "123456")
            {
                frm_cha cha = new frm_cha();
                i = 0;
                cha.Show();
            }
            else
            {
                i++;
                MessageBox.Show("login failed " + i);
            }

            if (i == 3)
            {
                MessageBox.Show("ban da nhap sai "+ i +" lan chuong trinh phai thoat");
                Application.Exit();
            }

        }
    }
}

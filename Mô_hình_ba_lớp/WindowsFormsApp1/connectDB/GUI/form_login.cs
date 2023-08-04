using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace connectDB
{
    public partial class form_login : Form
    {
        connectDB ketnoi = new connectDB();
        BLL.BLL_dangnhap bll_dn;

        public form_login()
        {
            InitializeComponent();
            bll_dn = new BLL.BLL_dangnhap(this);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            bll_dn.blldangnhap();
        }

       

     
    }
}

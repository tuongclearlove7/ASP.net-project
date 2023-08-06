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
    public partial class form_register : Form
    {
        int c = 0;
        BLL.BLL_nguoichoidangky BLL_NCDK;
        BLL.BLL_nguoichoi BLL_NC;
        ketnoi_database ketnoi;

        public form_register()
        {
            InitializeComponent();
            ketnoi = new ketnoi_database();
            BLL_NC = new BLL.BLL_nguoichoi(this);
            BLL_NCDK = new BLL.BLL_nguoichoidangky(this);
            BLL_NCDK.BLL_loadDataNhanvat();
        }

        private void cb_nhanvat_SelectedIndexChanged(object sender, EventArgs e)
        {
                string sql = $@"SELECT * FROM NHANVAT WHERE manhanvat = {((DataRowView)cb_nhanvat.SelectedItem)["manhanvat"]}";
                DataTable dt = BLL_NC.BLL_loadData(sql);
                lb_tennhanvat.Text = dt.Rows[0]["tennhanvat"].ToString();
                string hinh_nv = dt.Rows[0]["hinhanh"].ToString();
                img_player.ImageLocation = Application.StartupPath + $@"\\Resources\\{hinh_nv}";
          
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            BLL_NCDK.BLL_dangky();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            formLogin login = new formLogin();
            this.Hide();
            login.Show();
        }

        private void img_player_Click(object sender, EventArgs e)
        {

        }

        private void form_register_Closing(object sender, FormClosingEventArgs e)
        {

            if (sender is form_register) Application.Exit();
        }



    }
}

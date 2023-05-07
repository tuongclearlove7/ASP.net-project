using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webform_leaning1
{
    public partial class thuc_hien_phep_tinh : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void cong(object sender, EventArgs e)
        {

            int so_thu_nhat = Convert.ToInt32(so_thu1.Text);
            int so_thu_hai = Convert.ToInt32(so_thu2.Text);
            int ket_qua = so_thu_nhat + so_thu_hai;

            label_hienthi.Text = "Kết quả tính cộng là : " + ket_qua;

        }
        protected void tru(object sender, EventArgs e)
        {

            int so_thu_nhat = Convert.ToInt32(so_thu1.Text);
            int so_thu_hai = Convert.ToInt32(so_thu2.Text);
            int ket_qua = so_thu_nhat - so_thu_hai;

            label_hienthi.Text = "Kết quả tính trừ là : " + ket_qua;

        }
        protected void nhan(object sender, EventArgs e)
        {

            int so_thu_nhat = Convert.ToInt32(so_thu1.Text);
            int so_thu_hai = Convert.ToInt32(so_thu2.Text);
            int ket_qua = so_thu_nhat * so_thu_hai;

            label_hienthi.Text = "Kết quả tính nhân là : " + ket_qua;

        }
        protected void chia(object sender, EventArgs e)
        {

            int so_thu_nhat = Convert.ToInt32(so_thu1.Text);
            int so_thu_hai = Convert.ToInt32(so_thu2.Text);
            int ket_qua = so_thu_nhat / so_thu_hai;

            label_hienthi.Text = "Kết quả tính chia là : " + ket_qua;

        }
    }
}
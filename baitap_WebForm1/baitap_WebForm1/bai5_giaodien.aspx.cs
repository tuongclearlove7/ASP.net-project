using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace baitap_WebForm1
{
    public partial class bai5_giaodien : System.Web.UI.Page
    {

        private int mabm;

        protected void Page_Load(object sender, EventArgs e)
        {

            Random random = new Random();
            int randomNumber = random.Next(10000, 99999);
            mabm = randomNumber;
            lblMaBM.Text = "<p style='color :red;'>"+mabm.ToString()+"</p>";
        }

        protected void kiemtra(object sender, EventArgs e)
        {
            try
            {
                int ma_bm = Convert.ToInt32(ma_baomat.Text);
                if (mabm == ma_bm)
                    kiemtra_mabaomat.Text = "Mã bảo mật đúng";
                else if (mabm != ma_bm)
                    kiemtra_mabaomat.Text = "Nhập không đúng mã bảo mật!";
            }
            catch(Exception err)
            {
                kiemtra_mabaomat.Text = err.Message;
            }
          

        }

    }
}
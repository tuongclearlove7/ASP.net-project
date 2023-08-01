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

        protected void rand()
        {
            Random random = new Random();
            int so_ngau_nhien = random.Next(10000, 99999);
            lblMaBM.Text = so_ngau_nhien.ToString();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                rand();

            }
            
        }

        protected void serverValidate(object source, ServerValidateEventArgs args)
        {
            int value;
            bool isNumber = int.TryParse(args.Value, out value);
            args.IsValid = isNumber && value % 2 == 0;
        }

        protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string lblMaBMValue = lblMaBM.Text;

            args.IsValid = (args.Value == lblMaBMValue);
        }

        protected void kiemtra_mabaomat(object sender, EventArgs e)
        {
         

            if (lblMaBM.Text != ma_baomat.Text)
            {
             
                CustomValidator2.IsValid = false;
                CustomValidator2.ErrorMessage = "Nhập không đúng mã bảo mật!";
                success.Text = "";
                rand();
            }
            else
            {
                CustomValidator2.IsValid = true;
                CustomValidator2.ErrorMessage = "";
                success.Text = "đúng mã bảo mật!";

            }

            

            Page.Validate();

        }

    }
}
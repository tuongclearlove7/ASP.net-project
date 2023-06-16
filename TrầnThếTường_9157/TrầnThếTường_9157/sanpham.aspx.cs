using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrầnThếTường_9157
{
    public partial class sanpham : System.Web.UI.Page
    {
        lopketnoi ketnoi = new lopketnoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            string sql = "select * from thietbi, dathang where thietbi.mathietbi = dathang.mathietbi";
            ds_sanpham.DataSource = ketnoi.docdulieu(sql);
            ds_sanpham.DataBind();
        }
    }
}
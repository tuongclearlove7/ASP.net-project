using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrầnThếTường9157_QLbanhang
{
    public partial class bai2_mathang : System.Web.UI.Page
    {
        lopketnoi ketnoi = new lopketnoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            string sql = "select * from mathang";
            ds_mathang.DataSource = ketnoi.docdulieu(sql);
            ds_mathang.DataBind();
        }
    }
}
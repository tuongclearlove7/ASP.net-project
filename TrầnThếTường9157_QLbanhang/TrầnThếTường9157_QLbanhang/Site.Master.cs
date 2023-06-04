using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrầnThếTường9157_QLbanhang
{
    public partial class Site : System.Web.UI.MasterPage
    {
        lopketnoi ketnoi = new lopketnoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            string sql = "select * from loaihang";
            ds_loaihang.DataSource = ketnoi.docdulieu(sql);
            ds_loaihang.DataBind();
        }
    }
}
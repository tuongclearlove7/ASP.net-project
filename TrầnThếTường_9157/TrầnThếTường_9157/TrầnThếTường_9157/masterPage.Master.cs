using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrầnThếTường_9157
{
    public partial class masterPage : System.Web.UI.MasterPage
    {
        lopketnoi ketnoi = new lopketnoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            string sql = "select * from danhmuc";
            ds_danhmuc.DataSource = ketnoi.docdulieu(sql);
            ds_danhmuc.DataBind();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrầnThếTường_9157
{
    public partial class giohang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lopketnoi ketnoi = new lopketnoi();
            if (!IsPostBack)
            {
               
                //if (Request.QueryString["sanpham"] != null)
                //{
                    string mathietbi = Request.QueryString["sanpham"];
                    string sql = "select * from thietbi, dathang where thietbi.mathietbi = dathang.mathietbi";
                   
                    ds_dathang.DataSource = ketnoi.docdulieu(sql);
                    DataTable dt = ketnoi.docdulieu(sql);
                    ds_dathang.DataBind();


                //}
                //else
                //{
                //    Response.Redirect("sanpham.aspx");
                //}


            }


        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace webform_csdl
{
    public partial class ds_loaihang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionVsDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Server.MapPath("/App_Data/ql_banhang.mdf") + ";Integrated Security=True";

            if (!IsPostBack)
            {
                lopketnoi kn = new lopketnoi();
                string sql1 = "select * from loaihang";
                DataTable dt = kn.docdulieu(connectionVsDB, sql1);
                DataList1.DataSource = dt;
                DataList1.DataBind();

            }

        }

        protected void themmoi_loaihang(object sender, EventArgs e)
        {

            Response.Redirect("them_loaihang.aspx");
        }

        protected void xoa(object source, DataListCommandEventArgs e)
        {
            string connectionVsDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Server.MapPath("/App_Data/ql_banhang.mdf") + ";Integrated Security=True";

            if (e.CommandName == "Delete")
            {
                int itemIndex = e.Item.ItemIndex;
                TextBox maloaiTextBox = (TextBox)DataList1.Items[itemIndex].FindControl("maloai");
                string maloai = maloaiTextBox.Text;
                string sql1 = "DELETE FROM loaihang WHERE maloai = '" + maloai + "'";
                lopketnoi kn = new lopketnoi();
                DataTable dt = kn.docdulieu(connectionVsDB, sql1);
                DataList1.DataSource = dt;
                DataList1.DataBind();
                Response.Redirect("ds_loaihang.aspx?");
            }
        }

    }
}
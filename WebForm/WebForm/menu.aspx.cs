using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void next(object sender, EventArgs e)
        {

            label1.Text = "<h1>next</h1>";

        }
        protected void previous(object sender, EventArgs e)
        {

            label1.Text = "<h1>previous</h1>";

        }
        protected void home(object sender, EventArgs e)
        {

            label1.Text = "<h1>Trang chủ</h1>";

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class trang_chu : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            userInput.Text = "<h1 style='color:black;'>" + 
                                username.Text + "<br>" + 
                                password.Text + "<br>" +
                                checkboxlist1.Text + "<br>" +
                                date.Text + "<br>" +
                             "</h1>";
        }
    }
}












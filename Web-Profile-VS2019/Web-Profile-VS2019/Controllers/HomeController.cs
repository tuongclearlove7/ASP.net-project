using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using Web_Profile_VS2019.Models;

namespace Web_Profile_VS2019.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ViewBag.documentation = new documentation()
            {
                image = "../image/error1.png",
                text = "The Blazor startup process via the Blazor script (blazor.{webassembly|server}.js) is automatic and asynchronous. The Blazor <script> tag is found in the wwwroot/index.html file (Blazor WebAssembly) or Pages/_Host.cshtml file (Blazor Server), except for the ASP.NET Core 6.0 release of Blazor Server (Pages/_Layout.cshtml)."

            };



            ViewBag.infomation = new infomation()
            {

                fb = "Facebook",
                git = "Github",
                ins = "Instagram",
                id = "756464",
                name = "Tường Trần",
                firstname = "Trần",
                lastname = "Tường",
                fullname = "Trần Thế Tường",
                nickname = "clearlove7",
                email = "lol00sever@gmail.com",
                address = "31 Nguyen Khuyen",
                nation = "VietNam",
                city = "Da Nang",

            };

            return View();
        }

        public ActionResult About()
        {

            ViewBag.documentation = new documentation()
            {
                image = "../image/error1.png",
                text = "The Blazor startup process via the Blazor script (blazor.{webassembly|server}.js) is automatic and asynchronous. The Blazor <script> tag is found in the wwwroot/index.html file (Blazor WebAssembly) or Pages/_Host.cshtml file (Blazor Server), except for the ASP.NET Core 6.0 release of Blazor Server (Pages/_Layout.cshtml)."

            };



            ViewBag.infomation = new infomation()
            {

                fb = "Facebook",
                git = "Github",
                ins = "Instagram",
                id = "756464",
                name = "Tường Trần",
                firstname = "Trần",
                lastname = "Tường",
                fullname = "Trần Thế Tường",
                nickname = "clearlove7",
                email = "lol00sever@gmail.com",
                address = "31 Nguyen Khuyen",
                nation = "VietNam",
                city = "Da Nang",

            };

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {

            ViewBag.documentation = new documentation()
            {
                image = "../image/error1.png",
                text = "The Blazor startup process via the Blazor script (blazor.{webassembly|server}.js) is automatic and asynchronous. The Blazor <script> tag is found in the wwwroot/index.html file (Blazor WebAssembly) or Pages/_Host.cshtml file (Blazor Server), except for the ASP.NET Core 6.0 release of Blazor Server (Pages/_Layout.cshtml)."

            };



            ViewBag.infomation = new infomation()
            {

                fb = "Facebook",
                git = "Github",
                ins = "Instagram",
                id = "756464",
                name = "Tường Trần",
                firstname = "Trần",
                lastname = "Tường",
                fullname = "Trần Thế Tường",
                nickname = "clearlove7",
                email = "lol00sever@gmail.com",
                address = "31 Nguyen Khuyen",
                nation = "VietNam",
                city = "Da Nang",

            };

            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
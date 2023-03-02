using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web_profile_MVC_VS2019.Models;

namespace web_profile_MVC_VS2019.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var obj = new documentation()
            {
                image = "../image/error1.png",
                text = "The Blazor startup process via the Blazor script (blazor.{webassembly|server}.js) is automatic and asynchronous. The Blazor <script> tag is found in the wwwroot/index.html file (Blazor WebAssembly) or Pages/_Host.cshtml file (Blazor Server), except for the ASP.NET Core 6.0 release of Blazor Server (Pages/_Layout.cshtml)."

            };

            return View(obj);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Net;
using web_Profile_MVC.Models;

namespace web_Profile_MVC.Controllers {

    public class HomeController : Controller {

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) {

            _logger = logger;
        }

        public IActionResult homePage() {

            ViewBag.product = new product()
            {

                name = "dữ liệu người dùng",
                address = "31 nguyen khuyen",
                city = "Da Nang",
                nation = "Viet Nam",
                postalCode = "44236"
            };

            ViewBag.infomation = new infomation()
            {

                fb = "Facebook",
                git = "Github",
                ins = "Instagram",

            };

            ViewBag.documentation = new documentation()
            {

                image = "../css/image/error1.png",
                text = "The Blazor startup process via the Blazor script (blazor.{webassembly|server}.js) is automatic and asynchronous. The Blazor <script> tag is found in the wwwroot/index.html file (Blazor WebAssembly) or Pages/_Host.cshtml file (Blazor Server), except for the ASP.NET Core 6.0 release of Blazor Server (Pages/_Layout.cshtml)."

            };

            ViewBag.number = new number()
            {

                num_1 = 1,
                num_2 = 2,
                num_3 = 3,
                num_4 = 4,
                num_5 = 5,

            };



            return View();
        }

  

        public string Example(){

            return "This is the Example action method...";
        }

        public IActionResult About() {

            string brCard = "<br>";

            ViewData["Message"] = "Your application description page.";

            ViewBag.product = new product() {

                name = "dữ liệu người dùng",
                address = "31 nguyen khuyen",
                city = "Da Nang",
                nation = "Viet Nam",
                postalCode = "44236"
            };

            ViewBag.infomation = new infomation() {

                fb = "Facebook",
                git = "Github",
                ins = "Instagram",
          
            };

            ViewBag.number = new number()
            {

                num_1 = 1,
                num_2 = 2,
                num_3 = 3,
                num_4 = 4,
                num_5 = 5,

            };

            return View();
        }

        public IActionResult Product() {

            ViewBag.Greeting = "Hello  World! Chào mừng bạn đến với website của chúng tôi ^^";

            ViewBag.product = new product() {

                name = "dữ liệu người dùng",
                address = "31 nguyen khuyen",
                city = "Da Nang",
                nation = "Viet Nam",
                postalCode = "44236"
            };

            ViewBag.infomation = new infomation() {

                fb = "Facebook",
                git = "Github",
                ins = "Instagram",

            };

            ViewBag.number = new number()
            {

                num_1 = 1,
                num_2 = 2,
                num_3 = 3,
                num_4 = 4,
                num_5 = 5,

            };

            return View();
        }

        public IActionResult Documentation() {

            ViewBag.product = new product()
            {

                name = "dữ liệu người dùng",
                address = "31 nguyen khuyen",
                city = "Da Nang",
                nation = "Viet Nam",
                postalCode = "44236"
            };

            ViewBag.infomation = new infomation()
            {

                fb = "Facebook",
                git = "Github",
                ins = "Instagram",

            };

            ViewBag.documentation = new documentation() {

                image = "../css/image/error1.png",
                text = "The Blazor startup process via the Blazor script (blazor.{webassembly|server}.js) is automatic and asynchronous. The Blazor <script> tag is found in the wwwroot/index.html file (Blazor WebAssembly) or Pages/_Host.cshtml file (Blazor Server), except for the ASP.NET Core 6.0 release of Blazor Server (Pages/_Layout.cshtml)."

            };


            ViewBag.number = new number()
            {

                num_1 = 1,
                num_2 = 2,
                num_3 = 3,
                num_4 = 4,
                num_5 = 5,

            };


            return View();
        }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Error() {

            return View(new ErrorViewModel { 
                
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier 
            });
        }
    }
}
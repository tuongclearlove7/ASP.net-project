using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Net;
using System.Text.Json;
using web_Profile_MVC.Models;

namespace web_Profile_MVC.Controllers {

    public class HomeController : Controller {

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) {

            _logger = logger;
        }

        public IActionResult homePage() {

            string skill = "<p align='left'><a href='https://github.com/tuongclearlove7'><img height='180em' src='https://github-readme-stats-eight-theta.vercel.app/api?username=tuongclearlove7&show_icons=true&theme=algolia&include_all_commits=true&count_private=true'/><img height='180em' src='https://github-readme-stats-eight-theta.vercel.app/api/top-langs/?username=tuongclearlove7&layout=compact&langs_count=8&theme=algolia'/></a></p>";

            Console.WriteLine(skill);

            ViewData[nameof(skill)] = skill;

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
                id = "7",
                name = " tuong tran",
                firstname = "tran",
                lastname = "tuong",
                fullname = "Tran The Tuong",
                nickname = "clearlove7",
                email = "lol00sever@gmail.com"

            };

            ViewBag.documentation = new documentation()
            {

                image = "../image/error1.png",
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

  

        public IActionResult Example(){


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
                id = "7",
                name = " tuong tran",
                firstname = "tran",
                lastname = "tuong",
                fullname = "Tran The Tuong",
                nickname = "clearlove7",
                email = "lol00sever@gmail.com"
            };

            ViewBag.number = new number()
            {

                num_1 = 1,
                num_2 = 2,
                num_3 = 3,
                num_4 = 4,
                num_5 = 5,

            };

            string json = JsonSerializer.Serialize(ViewBag.infomation);

            ViewData["json"] = json;

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
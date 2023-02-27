using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace web_Profile_MVC.Controllers
{
    public class NewsController : Controller
    {
        // GET: NewsController
        public ActionResult Index(string id, string name)
        {

            id = "7e5w3r0er";
            name = "tuongclearlove7";

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
                id = id,
                name = name,
                firstname = "tran",
                lastname = "tuong",
                fullname = "Tran The Tuong",
                nickname = "clearlove7",
                email = "lol00sever@gmail.com"

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

        // GET: NewsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NewsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NewsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NewsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NewsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NewsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NewsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

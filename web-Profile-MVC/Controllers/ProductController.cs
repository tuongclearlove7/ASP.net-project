using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace web_Profile_MVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductController
        public ActionResult Index()
        {

            ViewBag.Greeting = "Hello  World! Chào mừng bạn đến với website của chúng tôi ^^";

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

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
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

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
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

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
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

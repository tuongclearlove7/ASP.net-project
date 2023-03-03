using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Profile_VS2019.Models;

namespace Web_Profile_VS2019.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index(string id,string firstname,string lastname,string fullname,string notfound)
        {

            switch (id) { 
                case "16":

                    firstname = "Tường";
                    lastname = "Trần";
                    fullname = "Trần Thế Tường";

                    break;

                case "9":

                    firstname = "Thảo";
                    lastname = "Hồ";
                    fullname = "Hồ Phương Thảo";

                    break;

                case null:

                    notfound = "ko tìm thấy";

                    break;

                default:

                    break;
            }

             

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

        
            var obj = new documentation()
            {
                image = "../image/error1.png",
                text = "The Blazor startup process via the Blazor script (blazor.{webassembly|server}.js) is automatic and asynchronous. The Blazor <script> tag is found in the wwwroot/index.html file (Blazor WebAssembly) or Pages/_Host.cshtml file (Blazor Server), except for the ASP.NET Core 6.0 release of Blazor Server (Pages/_Layout.cshtml)."

            };

            ViewData["firstname"] = firstname;
            ViewData["lastname"] = lastname;
            ViewData["fullname"] = fullname;
            ViewData["notfound"] = notfound;


            return View(obj);
        }

        

        // GET: News/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: News/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: News/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: News/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: News/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: News/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: News/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

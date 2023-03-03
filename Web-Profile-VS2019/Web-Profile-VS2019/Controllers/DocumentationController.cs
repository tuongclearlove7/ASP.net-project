using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Profile_VS2019.Models;

namespace Web_Profile_VS2019.Controllers
{
    public class DocumentationController : Controller
    {
        // GET: Documentation
        public ActionResult Index()
        {

            var obj = new documentation()
            {
                image = "../image/error1.png",
                text = "The Blazor startup process via the Blazor script (blazor.{webassembly|server}.js) is automatic and asynchronous. The Blazor <script> tag is found in the wwwroot/index.html file (Blazor WebAssembly) or Pages/_Host.cshtml file (Blazor Server), except for the ASP.NET Core 6.0 release of Blazor Server (Pages/_Layout.cshtml)."

            };

            return View(obj);
        }

        // GET: Documentation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Documentation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Documentation/Create
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

        // GET: Documentation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Documentation/Edit/5
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

        // GET: Documentation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Documentation/Delete/5
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

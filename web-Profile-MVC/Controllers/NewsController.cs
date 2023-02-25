using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Text.Json;

namespace web_Profile_MVC.Controllers
{
    public class NewsController : Controller {

       

        public IActionResult Index(string id, string name) {

            id = "7eddfsf25353535";

            name = "tuong";

            ViewBag.infomation = new infomation()
            {

                id = id,
                name = name,
                fb = "tuong tran",
                git = "tuongclearlove7",
                ins = "warkerYTt"

            };

            string obj = JsonSerializer.Serialize(ViewBag.infomation);

            ViewData["json"] = obj;

            return View();
        }




    }
}

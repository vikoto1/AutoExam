using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoExam.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();  //home view
        }

        public ActionResult About()
        {
            ViewBag.Message = "Информация относно провеждането на изпита";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Контакти";

            return View();
        }
    }
}
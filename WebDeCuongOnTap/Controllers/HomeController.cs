using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebDeCuongOnTap.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Giới thiệu chung về trường";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Liên hệ với nhà trường và giáo viên, CBCNV";

            return View();
        }
    }
}
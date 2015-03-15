using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReactBundling.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetName()
        {
            return Json(new { name = "Dunia dari sisi server" }, JsonRequestBehavior.AllowGet);
        }

    }
}
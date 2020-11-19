using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace $safeprojectname$.Controllers
{
    public class ErrorController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View("Error");
        }

        [AllowAnonymous]
        public ActionResult JsonErrorResult(string message)
        {
            return Json(new { success = false, message = message }, JsonRequestBehavior.AllowGet);
        }

        [AllowAnonymous]
        public ActionResult NoAutorizado()
        {
            return View();
        }
    }
}
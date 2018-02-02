using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ClientsideValidation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ClientsideValidation(Models.DataValidation model)
        {
            return View();
        }

        public ActionResult CustomHtmlHelper()
        {
           return View(new Models.HtmlHelpers());
        }
        [HttpPost]
        public ActionResult CustomHtmlHelper(Models.HtmlHelpers modle)
        {
            return View();
        }

        public ActionResult AngularJs()
        {
            return View();
        }

        public ActionResult CustomValidation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CustomValidation(Models.CustomValidation model)
        {
            return View(model);
        }
    }
}
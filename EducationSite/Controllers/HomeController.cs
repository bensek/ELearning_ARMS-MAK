using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EducationSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        /*Taked us to the Account Controller to GET:: SignIn*/
        public ActionResult SignIn()
        {
            return RedirectToAction("SignIn","Auth");
        }

        /*Taked us to the Account Controller to GET:: SignUp*/
        public ActionResult SignUp()
        {
            return RedirectToAction("SignUp", "Auth");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}
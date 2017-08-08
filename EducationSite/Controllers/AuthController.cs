using EducationSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EducationSite.Controllers
{
    public class AuthController : Controller
    {
        private ApplicationDbContext _dbContext;
        public AuthController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Auth
        public ActionResult Index()
        {
            return View();
        }

        /* ACTION FOR LOADING THE LOG-IN/SIGN-IN PAGE*/
        public ActionResult SignIn()
        {
            return View();
        }

        /* ACTION FOR LOADING THE Register/SIGN-UP PAGE*/
        public ActionResult SignUp()
        {
            return View();
        }

        /* POST METHOD FOR REGISTRATION*/
        public ActionResult SignMeUp(User user)
        {
            if (user == null)
                return RedirectToAction("SignUp");

            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();

            return RedirectToAction("Dashboard", "Home");
        }
        /*POST METHOD FOR LOG IN */
        public ActionResult SignMeIn(User user)
        {
           
            var currentUser = _dbContext.Users.SingleOrDefault(v => v.Email == user.Email);
            if (currentUser == null)
            {
                // Display Incorrect Credentials
            }
            return RedirectToAction("Dashboard", "Home");
               
        }

    }
}
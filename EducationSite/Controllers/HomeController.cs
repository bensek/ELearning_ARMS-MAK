using EducationSite.Models;
using EducationSite.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EducationSite.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext _dbContext;
        public HomeController()
        {
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            return View();
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
            DashboardModel mymodel = new DashboardModel();
            mymodel.Posts = GetPosts();
            return View(mymodel);
        }
        public List<Post> GetPosts()
        {
            //List<Post> postModel = new List<Post>;
             var posts = _dbContext.Posts.ToList();
            return posts;
       
        }

    }
}
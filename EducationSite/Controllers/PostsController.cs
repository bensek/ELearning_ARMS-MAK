using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EducationSite.Models;

namespace EducationSite.Controllers
{
    public class PostsController : Controller
    {
        private ApplicationDbContext _dbContext;
        public PostsController() 
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Posts
        public ActionResult NewPost()
        {
           // var Posts = _dbContext.Posts.ToList();
            return View();
        }
        public ActionResult Add(Post post)
        {
            _dbContext.Posts.Add(post);
            _dbContext.SaveChanges();

            return RedirectToAction("Dashboard","Home");
        }
           
        
    }
}
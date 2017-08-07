using EducationSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EducationSite.Controllers
{
    public class CourseUnitController : Controller
    {
        public ApplicationDbContext _dbContext;

        public CourseUnitController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: CourseUnit
        public ActionResult Index()
        {
            return View();
        }
    }
}
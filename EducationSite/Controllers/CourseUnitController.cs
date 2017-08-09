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
        /*public ActionResult CourseUnit(int id)
        {
            var courseunit = _dbContext.CourseUnits.SingleOrDefault(c => c.Id == id);
            Console.WriteLine("course unit exists");
            if (courseunit == null)
                return HttpNotFound();
            return View(courseunit);
        }*/
        public ActionResult CourseUnit(int CuId)
        {
            var courseunit = _dbContext.CourseUnits.SingleOrDefault(c => c.Id == CuId);
            return View(courseunit);
        }
    }
}
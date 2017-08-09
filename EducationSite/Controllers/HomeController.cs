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
        public ActionResult LoadCourseUnit(int id)
        {

            return RedirectToAction("CourseUnit", "CourseUnit", new { id=id});
        }
        public ActionResult Dashboard()
        {
            var courseunits = _dbContext.CourseUnits.ToList();
            DashboardModel mymodel = new DashboardModel();
            mymodel.Programme = GetProgramme();
            mymodel.CourseUnits = GetCourseUnits();
            return View(mymodel);
        }

       /* private List<CourseUnit> GetCourseUnits()
        {
            List<CourseUnit> cuModel = new List<CourseUnit>();
            cuModel.Add(new CourseUnit() { BlogID = 1, CommentID = 1, Comment = "Good One", CommentedBy = "Vijay" });
            
            return cuModel;
        }*/

        public Programme GetProgramme()
        {
            Programme pModel = new Programme()
            {
                Id = 1,
                Name = "Bsc Electrical Engineering",
                Code = "BELE"
            };
            return pModel;
        }

        public List<CourseUnit> GetCourseUnits()
        {
            List<CourseUnit> cuModel = new List<CourseUnit>();
            cuModel.Add(new CourseUnit()
            {Id=1, Name="Engineering Mathematics II", Code="CMP101", CreditUnit=4, Description="An Introduction to Electronics", Instructor="Ms Shiela", ProgrammeId=1, SemesterOffered=2, YearOffered=2
            });
            cuModel.Add(new CourseUnit()
            {
                Id = 1,
                Name = "Programming Fundamentals",
                Code = "CMP103",
                CreditUnit = 4,
                Description = "Functional Programming with C language",
                Instructor = "Mr Ephraim",
                ProgrammeId = 1,
                SemesterOffered = 2,
                YearOffered = 2
            });
            return cuModel;
        }

       
    }
}
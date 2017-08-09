using EducationSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EducationSite.ViewModel
{
    public class DashboardModel
    {
        
        
        
        
        
        
        
        
        
        
        
        public List<Post> Posts { get; set; }

        /* VIEWMODEL ALLOWS ATTACH MULTIPLE MODELS TO THE DASHBOARD PAGE*/
        public Programme Programme { get; set; }
        public List<CourseUnit> CourseUnits { get; set; }
        
    }
}
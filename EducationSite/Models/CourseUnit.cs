using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EducationSite.Models
{
    public class CourseUnit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int CreditUnit { get; set; }
        public string Description { get; set; }
        public string Instructor { get; set; }
        public int ProgrammeId { get; set; }
        public int YearOffered { get; set; }
        public int SemesterOffered { get; set; }

    }
}
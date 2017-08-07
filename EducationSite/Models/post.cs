using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EducationSite.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public int StudentId { get; set; }
        public string TimeStamp { get; set; }
        public string ImageURL { get; set; }
        public int CourseUnitId { get; set; }
       // public CourseUnit CourseUnit { get; set; }
        
    }

   /* public enum CourseUnit
    {
        Engineering Mathematics II = 1,
        Computer Programming Fundamentals,
        Electronics II,
        Computer Architecture and Organization,
        Electricity and Magnetism,
        Workshop Practice
    }*/
}

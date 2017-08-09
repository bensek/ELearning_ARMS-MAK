using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EducationSite.Models
{
    public class Deadline
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Timestamp { get; set; }
        public int CourseunitId { get; set; }
    }
}
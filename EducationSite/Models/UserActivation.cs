using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EducationSite.Models
{
    public partial class UserActivation
    {
        public int CodeId { get; set; }
        public string ActivationCode { get; set; }
        public int Id { get; set; }
        public virtual User User { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EducationSite.Models
{
    public class USER
    {
        public int Id { get; set; }
        public string fullname { get; set; }
        public string username { get; set; }
        public string RegNo { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
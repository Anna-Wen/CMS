﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassManagementSystem.Models
{
    public class ClassGroup
    {
        public Student Leader { get; set; }
        public List<Student> Members { get; set; }
    }
}
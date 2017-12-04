﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassManagementSystem.Models
{
    public class SeminarGradeDetail
    {
        public string GroupName { get; set; }
        public string LeaderName { get; set; }
        public int PresentationGrade { get; set; }
        public int ReportGrade { get; set; }
        public int Grade { get; set; }
    }
}

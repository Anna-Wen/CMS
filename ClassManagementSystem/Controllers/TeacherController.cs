﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ClassManagementSystem.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult CreateTopic()
        {
            return View();
        }
        public IActionResult TeacherCourseHome()
        {
            return View();
        }
        
            public IActionResult CheckClassInfo()
        {
            return View(); 
        }
        public IActionResult CheckSeminar()
        {
            return View();
        }
        public IActionResult CheckTopic()
        {
            return View();
        }
    }
}
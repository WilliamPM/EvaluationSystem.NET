﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EvaluationSystemUI.Models;

namespace EvaluationSystemUI.Controllers
{
    public class TeacherController : Controller
    {
      
        // GET: Teacher
        public ActionResult TeacherMain()
        {
            return View();
        }

    }
}
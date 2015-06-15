using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EvaluationSystemUI.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult LoginDefault()
        {
            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Message = "Register an user or a teacher.";
            return View();
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EvaluationSystemBLL;
namespace EvaluationSystemUI.Controllers
{
    public class QuestionController : Controller
    {
        //
        // GET: /Question/
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(question question)
        {

            QuestionBLL NewQuestion = new QuestionBLL();
            NewQuestion.create(question);
            return View();
        }
	}
}
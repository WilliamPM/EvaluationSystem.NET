using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvaluationSystemUI.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string Enunciation { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }
        public string AnswerE { get; set; }
        public string CorrectAnswer { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvaluationSystemUI.Models
{
    public class Commentary
    {
        public int QuestionId { get; set; }
        public int CommentaryId { get; set; }
        public string FeedBack { get; set; }
    }
}
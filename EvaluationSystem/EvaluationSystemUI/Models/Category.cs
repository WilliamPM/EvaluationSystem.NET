using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvaluationSystemUI.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string TagDescription { get; set; }
        public int QuestionId { get; set; }
    }
}
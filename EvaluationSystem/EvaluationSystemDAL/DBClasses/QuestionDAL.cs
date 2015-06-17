using EvaluationSystemDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSystemDAL.DBClasses
{
    public class QuestionDAL : IQuestionDAL
    {
        public void create(question question)
        {
            evaluationsystemEntities1 containner = new evaluationsystemEntities1();
            containner.question.Add(question);
        }
    }
}

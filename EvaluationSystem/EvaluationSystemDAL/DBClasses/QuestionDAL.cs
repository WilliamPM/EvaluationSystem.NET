using EvaluationSystemDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvaluationSystemModel;

namespace EvaluationSystemDAL.DBClasses
{
    public class QuestionDAL : IQuestionDAL
    {
        public void create(question question)
        {
            
            EvaluationSystemEntities context = new EvaluationSystemEntities();

            context.question.Add(question);
            context.SaveChanges();
            
        }
    }
}

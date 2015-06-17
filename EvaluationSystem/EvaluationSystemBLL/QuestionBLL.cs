using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSystemBLL
{
    public class QuestionBLL
    {
        public Boolean create(EvaluationSystemDAL.question question)
        {
            if ((question.AnswerA =="") || (question.AnswerB =="") ||  (question.AnswerC=="") || (question.AnswerD =="") || 
                (question.AnswerE =="") || (question.category == null) || (question.commentary ==null) ||
                (question.CorrectAnswer == "") || (question.Enunciation == ""))
            {                
                return false;
            }

            return true;
        } 
    }
}

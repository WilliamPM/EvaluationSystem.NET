using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSystemBLL
{
    public class QuestionBLL
    {
        public Boolean create(EvaluationSystemDAL.question NewQuestion)
        {
            if ((NewQuestion.AnswerA == "") || (NewQuestion.AnswerB == "") || (NewQuestion.AnswerC == "") || (NewQuestion.AnswerD == "") ||
                (NewQuestion.AnswerE == "") || (NewQuestion.category == null) || (NewQuestion.commentary == null) ||
                (NewQuestion.CorrectAnswer == "") || (NewQuestion.Enunciation == ""))
            {                
                return false;
            }
            
            
            return true;
        } 
    }
}

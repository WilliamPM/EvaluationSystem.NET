using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using EvaluationSystemModel;
using EvaluationSystemDAL.DBClasses;

namespace EvaluationSystemBLL
{
    public class QuestionBLL
    {
        public Boolean create(question NewQuestion)
        {
            string strCorrectAnswer = NewQuestion.CorrectAnswer.ToString();
            int CountCorrectAnswer = Regex.Matches(strCorrectAnswer,@"[A-E]").Count;
            
            if ((NewQuestion.AnswerA == "") || (NewQuestion.AnswerB == "") || (NewQuestion.AnswerC == "") ||
                (NewQuestion.AnswerD == "") || (NewQuestion.AnswerE == "") || ( CountCorrectAnswer == 0 )|| 
                (NewQuestion.Enunciation == ""))    
            {                

                return false;
            }

            QuestionDAL q = new QuestionDAL();
            q.create(NewQuestion);
             
            return true;
        } 
    }
}

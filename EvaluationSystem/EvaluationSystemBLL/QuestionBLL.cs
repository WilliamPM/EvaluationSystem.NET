using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using EvaluationSystemModel;
using EvaluationSystemDAL.DBClasses;
using System.Collections;

namespace EvaluationSystemBLL
{
    public class QuestionBLL
    {
        private QuestionDAL questionDAL;
        public QuestionBLL() {
            questionDAL = new QuestionDAL();
        }

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

            questionDAL.create(NewQuestion);
             
            return true;
        }

        public List<question> list()
        {
            return questionDAL.list();
        }


    }
}

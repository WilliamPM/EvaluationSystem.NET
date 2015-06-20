using EvaluationSystemDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvaluationSystemModel;
using System.Collections;

namespace EvaluationSystemDAL.DBClasses
{
    public class QuestionDAL : IQuestionDAL
    {
        private EvaluationSystemEntities context;

        public QuestionDAL()
        {
            context = new EvaluationSystemEntities();
        }

        public bool create(question objQuestion)
        {
            bool created;

            try
            {
                context.question.Add(objQuestion);
                created = (context.SaveChanges() == 0) ? false : true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

            return created;
        }

        public List<question> list()
        {
            return context.question.ToList<question>(); 
        }

        public bool addCategory(question objQuestion,category objCategory)
        {
            bool created;

            try
            {
                context.question.FirstOrDefault(m=> m.QuestionId == objQuestion.QuestionId).category.Add(objCategory);
                created = (context.SaveChanges() == 0) ? false : true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

            return created;
        }

        public bool addCommentary(question objQuestion,commentary objCommentary)
        {
            bool created;

            try
            {
                context.question.FirstOrDefault(m => m.QuestionId == objQuestion.QuestionId).commentary.Add(objCommentary);
                created = (context.SaveChanges() == 0) ? false : true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

            return created;
        }

        public List<question> listAllCategoriesFromQuestion(question objQuestion)
        {
            throw new NotImplementedException();
        }

        public List<question> listAllCommtariesFromQuestion(question objQuestion)
        {
            throw new NotImplementedException();
        }

        public List<question> listAllQuestionFromEvaluation(question objQuestion)
        {
            throw new NotImplementedException();
        }

        public bool remCategory(question objQuestion, category objCategory)
        {
            throw new NotImplementedException();
        }

        public bool remCategory(question objQuestion, commentary objCommentary)
        {
            throw new NotImplementedException();
        }
    }
}

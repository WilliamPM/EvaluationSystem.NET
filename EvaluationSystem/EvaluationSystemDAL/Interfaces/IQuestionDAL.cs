using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvaluationSystemModel;
using System.Collections;

namespace EvaluationSystemDAL.Interfaces
{
    interface IQuestionDAL
    {
        bool create(question question);
        
        List<question> list();

        List<question> listAllCategoriesFromQuestion(question objQuestion);

        List<question> listAllCommtariesFromQuestion(question objQuestion);

        List<question> listAllQuestionFromEvaluation(question objQuestion);

        bool addCategory(question objQuestion, category objCategory);

        bool addCommentary(question objQuestion,commentary objCommentary);

        bool remCategory(question objQuestion, category objCategory);

        bool remCategory(question objQuestion, commentary objCommentary);
    }
}

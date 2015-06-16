using EvaluationSystemDAL.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSystemDAL.DBClasses
{
    class UsersEvaluationQuestionDAL : IUsersEvaluationQuestionDAL
    {
        public List<IEnumerable> GetStudentGrade(users us, evaluation ev)
        {
            List<IEnumerable> List = null;
            return List;
        }
    }
}

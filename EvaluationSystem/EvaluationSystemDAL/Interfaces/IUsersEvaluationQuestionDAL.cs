using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSystemDAL.Interfaces
{
    interface IUsersEvaluationQuestionDAL
    {
        List<IEnumerable> GetStudentGrade(users us, evaluation ev);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvaluationSystemModel;

namespace EvaluationSystemDAL.Interfaces
{
    interface IUsersEvaluationQuestionDAL
    {
        List<IEnumerable> GetStudentGrade(User user);
    }
}

﻿using EvaluationSystemDAL.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvaluationSystemModel;

namespace EvaluationSystemDAL.DBClasses
{
    class UsersEvaluationQuestionDAL : IUsersEvaluationQuestionDAL
    {
        public List<IEnumerable> GetStudentGrade(User us, Evaluation ev, Question qu)
        {
            List<IEnumerable> List = null;
            return List;
        }
    }
}

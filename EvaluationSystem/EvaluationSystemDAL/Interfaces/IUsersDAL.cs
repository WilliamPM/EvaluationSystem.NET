﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSystemDAL.Interfaces
{
    interface IUsersDAL
    {
        users CreateNewUser(users NewUser);
    }
}

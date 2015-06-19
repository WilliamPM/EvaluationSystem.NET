using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EvaluationSystemModel;

namespace EvaluationSystemDAL
{
    public class Context : DbContext
    {
        public DbSet<Category> Category { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Question> Commentary { get; set; }
        public DbSet<Question> Evaluation { get; set; }
        public DbSet<Question> User { get; set; }
        public DbSet<Question> UserEvaluationQuestion { get; set; }        
    }
}


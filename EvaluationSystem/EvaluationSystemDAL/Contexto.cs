using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EvaluationSystemModel;
namespace EvaluationSystemDAL
{
    public class Contexto : DbContext
    {
        public DbSet<Category> Category { get; set; }
        public DbSet<Question> Question { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvaluationSystemModel
{
    [Table("UserEvaluationQuestion")]
    public class UserEvaluationQuestion
    {
        [ForeignKey("Users")]
        public virtual User User { get; set; }

        [ForeignKey("EvaluationId")]
        public virtual Evaluation Evaluation { get; set; }

        [ForeignKey("QuestionId")]
        public virtual Question Question { get; set; }

        [Required(ErrorMessage="The field Answer is required.")]
        public string Answer { get; set; }
    }
}

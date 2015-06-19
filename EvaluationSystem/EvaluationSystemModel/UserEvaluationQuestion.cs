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
        [ForeignKey("EvaluationId")]
        public virtual Evaluation Evaluation { get; set; }

        [ForeignKey("QuestionId")]
        public virtual Question Question { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [Required(ErrorMessage="The field answer is required.")]
        public string Answer { get; set; }
    }
}

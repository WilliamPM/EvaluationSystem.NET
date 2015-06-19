using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvaluationSystemModel
{
    [Table("Commentary")]
    public class Commentary
    {
        [ForeignKey("QuestionId")]
        public virtual Question Question { get; set; }
        
        public int CommentaryId{ get; set; }

        [Required(ErrorMessage="The field Feedback is required")]
        public string Feedback { get; set; }    
    }
}

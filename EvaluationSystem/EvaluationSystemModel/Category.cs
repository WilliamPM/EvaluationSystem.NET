using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvaluationSystemModel
{
    [Table("Category")]
    public class Category
    {
        public int CategoryId{ get; set; }
        
        [Required(ErrorMessage="The field descrition is required.")]
        public string TagDescription{ get; set; }

        [ForeignKey("QuestionId")]
        public virtual Question Question{ get; set; }    

    }
}

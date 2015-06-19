using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvaluationSystemModel
{
     [Table("Evaluation")]
    public class Evaluation
    {
         public int EvaluationId {get; set;}

         [Required(ErrorMessage = "The field EvaluationType is required")]         
         public string EvaluationType {get; set;}
         public string ClosedCode { get; set; }
            

    }
}

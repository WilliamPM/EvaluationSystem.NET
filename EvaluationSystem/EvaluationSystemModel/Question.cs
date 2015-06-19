using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EvaluationSystemModel
{
    [Table("Question")]
    public class Question
    {
        public int QuestionId { get; set; }

        [Required(ErrorMessage="The field Enunciation is required.")]
        public string Enunciation { get; set; }

        [Required(ErrorMessage = "The field Answer A is required.")]
        public string AnswerA { get; set; }

        [Required(ErrorMessage = "The field Answer B is required.")]
        public string AnswerB { get; set; }

        [Required(ErrorMessage = "The field Answer C is required.")]
        public string AnswerC { get; set; }
        
        [Required(ErrorMessage = "The field Answer D is required.")]
        public string AnswerD { get; set; }
        
        [Required(ErrorMessage = "The field Answer E is required.")]
        public string AnswerE { get; set; }

        [Required(ErrorMessage="The field Correct Awnswer is required.")]
        public char CorrectAnswer { get; set; }
    }
}

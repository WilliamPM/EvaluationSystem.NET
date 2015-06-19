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

        [Required(ErrorMessage="The field enunciation is required.")]
        public string Enunciation { get; set; }

        [Required(ErrorMessage = "The field answer A is required.")]
        public string AnswerA { get; set; }

        [Required(ErrorMessage = "The field answer B is required.")]
        public string AnswerB { get; set; }

        [Required(ErrorMessage = "The field answer C is required.")]
        public string AnswerC { get; set; }
        
        [Required(ErrorMessage = "The field answer D is required.")]
        public string AnswerD { get; set; }
        
        [Required(ErrorMessage = "The field answer E is required.")]
        public string AnswerE { get; set; }

        [Required(ErrorMessage="The correct awnswer is required.")]
        public char CorrectAnswer { get; set; }
    }
}

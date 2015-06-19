using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvaluationSystemModel
{
    [Table("Users")]
    public class User
    {
        public int UsersId { get; set; }

        [Required(ErrorMessage="The field Login is required")]
        public string Login { get; set; }
        [Required(ErrorMessage = "The field Password is required")]
        public string Password { get; set; }
        [Required(ErrorMessage = "The field Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "The field UserType is required")]
        public int UsersTypeId { get; set; }
    }
}

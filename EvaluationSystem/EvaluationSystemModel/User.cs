//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EvaluationSystemModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.usersevaluationquestion = new HashSet<UsersEvaluationQuestion>();
        }
    
        public int UsersId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string UsersType { get; set; }
    
        public virtual ICollection<UsersEvaluationQuestion> usersevaluationquestion { get; set; }
    }
}

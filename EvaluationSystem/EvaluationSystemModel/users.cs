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
    
    public partial class users
    {
        public users()
        {
            this.usersevaluationquestion = new HashSet<usersevaluationquestion>();
        }
    
        public int UsersId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string UsersType { get; set; }
    
        public virtual ICollection<usersevaluationquestion> usersevaluationquestion { get; set; }
    }
}

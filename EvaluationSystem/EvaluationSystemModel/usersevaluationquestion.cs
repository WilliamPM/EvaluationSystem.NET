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
    
    public partial class usersevaluationquestion
    {
        public int EvaluationId { get; set; }
        public int QuestionId { get; set; }
        public int UsersId { get; set; }
        public string Answer { get; set; }
    
        public virtual evaluation evaluation { get; set; }
        public virtual question question { get; set; }
        public virtual users users { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EvaluationSystemDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class evaluationtype
    {
        public evaluationtype()
        {
            this.evaluation = new HashSet<evaluation>();
        }
    
        public int EvaluationTypeId { get; set; }
        public string Description { get; set; }
        public string ClosedCode { get; set; }
    
        public virtual ICollection<evaluation> evaluation { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchedulePlan.Base
{
    using System;
    using System.Collections.Generic;
    
    public partial class Request
    {
        public int RequestId { get; set; }
        public int DataId { get; set; }
        public string Number { get; set; }
        public int SatusId { get; set; }
        public string Comment { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Status Status { get; set; }
        public virtual Users Users { get; set; }
    }
}

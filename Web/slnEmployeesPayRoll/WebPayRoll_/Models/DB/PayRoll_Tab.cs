//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebPayRoll_.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class PayRoll_Tab
    {
        public int PayRollID { get; set; }
        public Nullable<System.DateTime> InitialPeriod { get; set; }
        public Nullable<System.DateTime> EndPeriod { get; set; }
        public Nullable<System.DateTime> PayRollDate { get; set; }
        public Nullable<int> PayRollInfoID { get; set; }
    
        public virtual PayRollInfo_Tab PayRollInfo_Tab { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PDA.DbContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class BlockedDeliveryUnit
    {
        public string DeliveryUnit { get; set; }
        public int Line { get; set; }
        public System.DateTime BlockedDate { get; set; }
        public int ObjectVersion { get; set; }
    
        public virtual ProductionLine ProductionLine { get; set; }
    }
}
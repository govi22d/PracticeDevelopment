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
    
    public partial class LocationBlocking
    {
        public string LocationId { get; set; }
        public int BlockTypeId { get; set; }
        public string UserId { get; set; }
        public System.DateTime BlockingTime { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public int ObjectVersion { get; set; }
    
        public virtual Location Location { get; set; }
        public virtual LocationBlockingCode LocationBlockingCode { get; set; }
    }
}

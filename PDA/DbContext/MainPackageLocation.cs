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
    
    public partial class MainPackageLocation
    {
        public long Id { get; set; }
        public string MainPackageId { get; set; }
        public string SupplierId { get; set; }
        public string LocationId { get; set; }
        public string LocationCompanionId { get; set; }
        public string GroupLocationId { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public int ObjectVersion { get; set; }
    
        public virtual Location Location { get; set; }
        public virtual Location Location1 { get; set; }
    }
}

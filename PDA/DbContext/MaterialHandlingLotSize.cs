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
    
    public partial class MaterialHandlingLotSize
    {
        public string PartNumber { get; set; }
        public string ReceivingDepartmentId { get; set; }
        public Nullable<int> MaterialHandlingLotSize1 { get; set; }
        public string EmballageTypeId { get; set; }
        public Nullable<int> QuantityOfMaterialToHandle { get; set; }
        public Nullable<int> QuantityOfMaterialToHandleInTransport { get; set; }
        public string PickUpLocation { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public int ObjectVersion { get; set; }
    
        public virtual Part Part { get; set; }
    }
}

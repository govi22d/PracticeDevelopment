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
    
    public partial class ShipmentDispatchNotePackagePartProdOrder
    {
        public int Id { get; set; }
        public int ShipmentDispatchNotePackagePartId { get; set; }
        public string CPOId { get; set; }
        public string InternalOrderNumber { get; set; }
        public string ChassisType { get; set; }
        public string ChassisNumber { get; set; }
        public string ProductionOrderID { get; set; }
        public string ExecutionOrderID { get; set; }
        public string UsePoint { get; set; }
        public int Quantity { get; set; }
        public int ObjectVersion { get; set; }
    
        public virtual ShipmentDispatchNotePackagePart ShipmentDispatchNotePackagePart { get; set; }
    }
}

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
    
    public partial class LoosePartItemKDPick
    {
        public int Id { get; set; }
        public Nullable<int> LoosePartItemId { get; set; }
        public string MainOrderId { get; set; }
        public string MasterItemId { get; set; }
        public string ProductionOrderId { get; set; }
        public string ExecutionOrderId { get; set; }
        public string CPOId { get; set; }
        public int Quantity { get; set; }
        public int PickedQuantity { get; set; }
        public string AssemblyOrder { get; set; }
        public string ChassisType { get; set; }
        public string ChassisNumber { get; set; }
        public int DispatchedQty { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public int ObjectVersion { get; set; }
    
        public virtual LoosePartItem LoosePartItem { get; set; }
    }
}

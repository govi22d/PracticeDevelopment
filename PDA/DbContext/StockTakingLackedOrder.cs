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
    
    public partial class StockTakingLackedOrder
    {
        public int Id { get; set; }
        public string ReceivingMHA { get; set; }
        public string OrderLocation { get; set; }
        public string PartNumber { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string ExecutionOrderId { get; set; }
        public int ObjectVersion { get; set; }
    }
}
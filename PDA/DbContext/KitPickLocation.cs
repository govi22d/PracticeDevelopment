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
    
    public partial class KitPickLocation
    {
        public string KitOrderNumber { get; set; }
        public string MasterGroupId { get; set; }
        public string LocationId { get; set; }
        public string PartNumber { get; set; }
        public bool Picked { get; set; }
        public Nullable<System.DateTime> PickedDate { get; set; }
        public Nullable<int> ObjectVersion { get; set; }
    
        public virtual KitPickDeliveryUnit KitPickDeliveryUnit { get; set; }
    }
}

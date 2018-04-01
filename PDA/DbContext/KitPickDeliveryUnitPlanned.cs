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
    
    public partial class KitPickDeliveryUnitPlanned
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KitPickDeliveryUnitPlanned()
        {
            this.KitPickDeliveryUnitKitPlanneds = new HashSet<KitPickDeliveryUnitKitPlanned>();
            this.KitPickDeliveryUnitPartPlanneds = new HashSet<KitPickDeliveryUnitPartPlanned>();
        }
    
        public string KitOrderNumber { get; set; }
        public string KitId { get; set; }
        public string DeliveryUnit { get; set; }
        public string SerialNumber { get; set; }
        public Nullable<System.DateTime> PlannedStartTime { get; set; }
        public bool IsEmpty { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public string ModifiedBy { get; set; }
        public int ObjectVersion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KitPickDeliveryUnitKitPlanned> KitPickDeliveryUnitKitPlanneds { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KitPickDeliveryUnitPartPlanned> KitPickDeliveryUnitPartPlanneds { get; set; }
    }
}

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
    
    public partial class HistoryEvent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HistoryEvent()
        {
            this.HistoryFields = new HashSet<HistoryField>();
        }
    
        public int EventId { get; set; }
        public Nullable<System.Guid> EventGuid { get; set; }
        public int EventTypeId { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public string PartNo { get; set; }
        public string CostCenter { get; set; }
        public string SiteId { get; set; }
        public string MainPackage { get; set; }
        public string Supplier { get; set; }
        public string SubPackageId { get; set; }
        public string SupplierSubPackageId { get; set; }
        public string SerialNumber { get; set; }
        public string DeliveryUnit__ { get; set; }
        public string ChassisId { get; set; }
        public string ChassisType { get; set; }
        public string PartOrderNumber { get; set; }
        public string TransportAssignmentNumber { get; set; }
        public Nullable<int> ObjectVersion { get; set; }
    
        public virtual EventType EventType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoryField> HistoryFields { get; set; }
    }
}

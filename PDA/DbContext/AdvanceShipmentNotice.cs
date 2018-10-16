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
    
    public partial class AdvanceShipmentNotice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AdvanceShipmentNotice()
        {
            this.ASNMainPackages = new HashSet<ASNMainPackage>();
            this.ASNMOSOrARQs = new HashSet<ASNMOSOrARQ>();
            this.ASNParts = new HashSet<ASNPart>();
            this.CustomerOrderHeads = new HashSet<CustomerOrderHead>();
            this.InspectionRequests = new HashSet<InspectionRequest>();
        }
    
        public int Id { get; set; }
        public string SupplierId { get; set; }
        public string ShipmentNoticeId { get; set; }
        public System.DateTime ShipmentTime { get; set; }
        public string CarrierName { get; set; }
        public string ConsignmentNumber { get; set; }
        public string TrailerId { get; set; }
        public Nullable<System.DateTime> PlannedArrivalTime { get; set; }
        public Nullable<System.DateTime> ArrivedTime { get; set; }
        public Nullable<decimal> GrossWeight { get; set; }
        public string DeliveryAddress { get; set; }
        public int StatusId { get; set; }
        public Nullable<int> FlightExpressId { get; set; }
        public Nullable<System.DateTime> DocumentDate { get; set; }
        public string TransportDocument { get; set; }
        public string GrossWeightUnit { get; set; }
        public string SiteId { get; set; }
        public string EntryDocument { get; set; }
        public Nullable<System.DateTime> EntryDocumentDate { get; set; }
        public string Esugam { get; set; }
        public Nullable<decimal> FreightCost { get; set; }
        public Nullable<decimal> InsuranceCost { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public int ObjectVersion { get; set; }
    
        public virtual FlightExpress FlightExpress { get; set; }
        public virtual ReceivingStatu ReceivingStatu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ASNMainPackage> ASNMainPackages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ASNMOSOrARQ> ASNMOSOrARQs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ASNPart> ASNParts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerOrderHead> CustomerOrderHeads { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InspectionRequest> InspectionRequests { get; set; }
    }
}
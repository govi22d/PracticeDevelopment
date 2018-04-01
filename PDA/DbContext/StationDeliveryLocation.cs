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
    
    public partial class StationDeliveryLocation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StationDeliveryLocation()
        {
            this.StationDeliveryLocationKits = new HashSet<StationDeliveryLocationKit>();
            this.StationDeliveryLocationParts = new HashSet<StationDeliveryLocationPart>();
        }
    
        public int StationDeliveryLocationId { get; set; }
        public string LocationId { get; set; }
        public int PhysicalStationId { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public int ObjectVersion { get; set; }
    
        public virtual Location Location { get; set; }
        public virtual PhysicalStation PhysicalStation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StationDeliveryLocationKit> StationDeliveryLocationKits { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StationDeliveryLocationPart> StationDeliveryLocationParts { get; set; }
    }
}

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
    
    public partial class ProductionLine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductionLine()
        {
            this.ActivityLocations = new HashSet<ActivityLocation>();
            this.BlockedDeliveryUnits = new HashSet<BlockedDeliveryUnit>();
            this.ComponentActivities = new HashSet<ComponentActivity>();
            this.ComponentProductionFlows = new HashSet<ComponentProductionFlow>();
            this.ComponentTransports = new HashSet<ComponentTransport>();
            this.ComponentTransports1 = new HashSet<ComponentTransport>();
            this.ConnectedExecutionOrderTypes = new HashSet<ConnectedExecutionOrderType>();
            this.DeliveryUnitHasPassedStations = new HashSet<DeliveryUnitHasPassedStation>();
            this.DeliveryUnitParts = new HashSet<DeliveryUnitPart>();
            this.DeliveryUnitPartWorkcells = new HashSet<DeliveryUnitPartWorkcell>();
            this.Departments = new HashSet<Department>();
            this.HardConnectedCBUs = new HashSet<HardConnectedCBU>();
            this.HardConnectedCBUFaileds = new HashSet<HardConnectedCBUFailed>();
            this.NewSequenceDeliveryUnits = new HashSet<NewSequenceDeliveryUnit>();
            this.PendingTransports = new HashSet<PendingTransport>();
            this.PendingTransports1 = new HashSet<PendingTransport>();
            this.Stations = new HashSet<Station>();
            this.StationChangeNotes = new HashSet<StationChangeNote>();
            this.StationWorkcells = new HashSet<StationWorkcell>();
        }
    
        public int Id { get; set; }
        public string BusinessKey { get; set; }
        public string Description { get; set; }
        public string OrderSystem { get; set; }
        public int ObjectVersion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityLocation> ActivityLocations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BlockedDeliveryUnit> BlockedDeliveryUnits { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComponentActivity> ComponentActivities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComponentProductionFlow> ComponentProductionFlows { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComponentTransport> ComponentTransports { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComponentTransport> ComponentTransports1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConnectedExecutionOrderType> ConnectedExecutionOrderTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeliveryUnitHasPassedStation> DeliveryUnitHasPassedStations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeliveryUnitPart> DeliveryUnitParts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeliveryUnitPartWorkcell> DeliveryUnitPartWorkcells { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Department> Departments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HardConnectedCBU> HardConnectedCBUs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HardConnectedCBUFailed> HardConnectedCBUFaileds { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NewSequenceDeliveryUnit> NewSequenceDeliveryUnits { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PendingTransport> PendingTransports { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PendingTransport> PendingTransports1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Station> Stations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StationChangeNote> StationChangeNotes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StationWorkcell> StationWorkcells { get; set; }
    }
}

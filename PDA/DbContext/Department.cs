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
    
    public partial class Department
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Department()
        {
            this.AllowedPackages = new HashSet<AllowedPackage>();
            this.AutoreplyOnParts = new HashSet<AutoreplyOnPart>();
            this.AutoreplyOnPartAndDeliveryPoints = new HashSet<AutoreplyOnPartAndDeliveryPoint>();
            this.DeliveryLocationPerZones = new HashSet<DeliveryLocationPerZone>();
            this.DepartmentOrderNeedTimes = new HashSet<DepartmentOrderNeedTime>();
            this.DepartmentPrinters = new HashSet<DepartmentPrinter>();
            this.InventoryWithdrawalOnLocations = new HashSet<InventoryWithdrawalOnLocation>();
            this.Locations = new HashSet<Location>();
            this.MaterialHandlingLotSizeExceptions = new HashSet<MaterialHandlingLotSizeException>();
            this.PartCharacteristics = new HashSet<PartCharacteristic>();
            this.PickingGroups = new HashSet<PickingGroup>();
            this.StoragingAllowedElseWheres = new HashSet<StoragingAllowedElseWhere>();
            this.ValidCranes = new HashSet<ValidCrane>();
        }
    
        public string DepartmentId { get; set; }
        public string Description { get; set; }
        public string FactoryCode { get; set; }
        public string TypeOfOperationId { get; set; }
        public string StorageTypeId { get; set; }
        public string CostCenter { get; set; }
        public int AssemblyLineId { get; set; }
        public int CapacityPerHour { get; set; }
        public bool NeedAssembly { get; set; }
        public bool TakeAway { get; set; }
        public bool PutAway { get; set; }
        public bool ForkliftTransport { get; set; }
        public string MainStorage { get; set; }
        public bool AllowMPackage { get; set; }
        public bool AllowGPackage { get; set; }
        public bool PreparedForCustomer { get; set; }
        public bool TransportBlueBoxOnPallet { get; set; }
        public bool StrappingRequired { get; set; }
        public bool SplitGPackage { get; set; }
        public bool SplitMPackage { get; set; }
        public Nullable<int> PickingPalletTypeId { get; set; }
        public Nullable<int> ProcessId { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public int ObjectVersion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AllowedPackage> AllowedPackages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AutoreplyOnPart> AutoreplyOnParts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AutoreplyOnPartAndDeliveryPoint> AutoreplyOnPartAndDeliveryPoints { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeliveryLocationPerZone> DeliveryLocationPerZones { get; set; }
        public virtual Factory Factory { get; set; }
        public virtual ProductionLine ProductionLine { get; set; }
        public virtual StorageType StorageType { get; set; }
        public virtual TypeOfOperation TypeOfOperation { get; set; }
        public virtual ValidCostCenter ValidCostCenter { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DepartmentOrderNeedTime> DepartmentOrderNeedTimes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DepartmentPrinter> DepartmentPrinters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryWithdrawalOnLocation> InventoryWithdrawalOnLocations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Location> Locations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialHandlingLotSizeException> MaterialHandlingLotSizeExceptions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartCharacteristic> PartCharacteristics { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PickingGroup> PickingGroups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoragingAllowedElseWhere> StoragingAllowedElseWheres { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ValidCrane> ValidCranes { get; set; }
    }
}

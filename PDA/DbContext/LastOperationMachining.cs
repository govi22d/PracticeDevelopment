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
    
    public partial class LastOperationMachining
    {
        public string PackingLocation { get; set; }
        public string PartNumber { get; set; }
        public bool IndividualReply { get; set; }
        public string PickUpLocation { get; set; }
        public System.DateTime RegisterTime { get; set; }
        public string UserId { get; set; }
        public string StationDescription { get; set; }
        public int LoadLength { get; set; }
        public int LoadWidth { get; set; }
        public int LoadHeight { get; set; }
        public int QuantityOfMaterialToHandleInTransport { get; set; }
        public bool InternalPackage { get; set; }
        public bool VendorManagedInventoryWarehouse { get; set; }
        public int QuantityOfMaterialToHandle { get; set; }
        public int PalletFrames { get; set; }
        public string PackageType { get; set; }
        public string DeliveryLocation { get; set; }
        public int PackageWeight { get; set; }
        public string LabelType { get; set; }
        public bool Label { get; set; }
        public Nullable<int> StatusOfPackage { get; set; }
        public Nullable<int> PackageBlockingCode { get; set; }
        public bool TNTReply { get; set; }
        public string EmballageTypeId { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public int ObjectVersion { get; set; }
    
        public virtual EmballageType EmballageType { get; set; }
        public virtual Location Location { get; set; }
        public virtual Part Part { get; set; }
    }
}

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
    
    public partial class USP_GetMainPackagesOnYardArea_Result
    {
        public long Id { get; set; }
        public string SupplierId { get; set; }
        public string MainPackageId { get; set; }
        public string DeliveryLocation { get; set; }
        public string CurrentLocation { get; set; }
        public System.DateTime PackageTime { get; set; }
        public decimal PackageWeight { get; set; }
        public int PalletTypeId { get; set; }
        public string PackageType { get; set; }
        public string Status { get; set; }
        public string CostCenter { get; set; }
        public string DeliveryUnit { get; set; }
        public string MaterialUnitType { get; set; }
        public string KitOrderNumber { get; set; }
        public Nullable<int> ComponentGroupId { get; set; }
        public string PackReferenceNumber { get; set; }
        public string EmballageNumber { get; set; }
        public string SiteId { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public int ObjectVersion { get; set; }
        public Nullable<int> TransportAssignmentId { get; set; }
        public Nullable<int> TransportAssignmentReferenceId { get; set; }
        public string SupplierId1 { get; set; }
        public string PackageNumber { get; set; }
        public string PickUpLocation { get; set; }
        public string DeliveryLocation1 { get; set; }
        public Nullable<int> TransportAssignmentPriority { get; set; }
        public Nullable<System.DateTime> TransportAssignmentStatusTime { get; set; }
        public Nullable<int> TransportAssignmentCodeId { get; set; }
        public string UserId { get; set; }
        public string TransportSystem { get; set; }
        public Nullable<int> PartOrderCategory { get; set; }
        public string TransportUnitId { get; set; }
        public string MasterGroupId { get; set; }
        public Nullable<int> ComponentPosition { get; set; }
        public string AuthorityCode { get; set; }
        public string OrderSystem { get; set; }
        public string EmballageType { get; set; }
        public Nullable<int> ReservedQuantity { get; set; }
        public Nullable<int> MaxReservedQuantity { get; set; }
        public Nullable<int> PalletFrames { get; set; }
        public Nullable<int> PackageWeight1 { get; set; }
        public string PalletType { get; set; }
        public string ComponentFamily { get; set; }
        public Nullable<int> SerialNumber { get; set; }
        public string PartNumber { get; set; }
        public string CostReceivingCenter { get; set; }
        public string PartNumberverification { get; set; }
        public string CarrierId { get; set; }
        public Nullable<System.DateTime> AdmissibleStartTime { get; set; }
        public Nullable<int> LoadLength { get; set; }
        public Nullable<int> LoadWidth { get; set; }
        public Nullable<int> LoadHeight { get; set; }
        public Nullable<bool> IsOrderable { get; set; }
        public string IndividualNumber { get; set; }
        public Nullable<bool> LogicalPackage { get; set; }
        public string TrailerId { get; set; }
        public Nullable<bool> CommingAssignment { get; set; }
        public Nullable<int> Level { get; set; }
        public Nullable<int> Stow { get; set; }
        public Nullable<int> StowPosition { get; set; }
        public string MHA { get; set; }
        public string CreatedBy1 { get; set; }
        public Nullable<System.DateTime> CreatedTime1 { get; set; }
        public string ModifiedBy1 { get; set; }
        public Nullable<System.DateTime> ModifiedTime1 { get; set; }
        public Nullable<int> ObjectVersion1 { get; set; }
        public Nullable<int> PalletFrames1 { get; set; }
        public string ShipmentNoticeId { get; set; }
    }
}
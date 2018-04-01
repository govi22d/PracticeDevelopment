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
    
    public partial class USP_GetMainPackagesOnSupplierDespatch_Result
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
    }
}

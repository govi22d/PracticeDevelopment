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
    
    public partial class USP_GetUnverifiedGoods_Result
    {
        public string SupplierId { get; set; }
        public string MainPackageId { get; set; }
        public string SubPackageId { get; set; }
        public string PartNumber { get; set; }
        public string PartDescription { get; set; }
        public Nullable<bool> Express { get; set; }
        public int PackageQuantity { get; set; }
        public System.DateTime FifoTime { get; set; }
        public string MaterialHandlingUnit { get; set; }
        public int ASNId { get; set; }
        public string ShipmentNoticeId { get; set; }
        public string Status { get; set; }
        public string CurrentLocation { get; set; }
        public int ObjectVersion { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public string MainPackageSupplierId { get; set; }
        public string SupplierBatchNumber { get; set; }
        public string OriginalSupplierId { get; set; }
        public string OriginalPackageId { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public int Expr1 { get; set; }
        public string PackageType { get; set; }
        public string SiteId { get; set; }
        public System.DateTime ShipmentTime { get; set; }
    }
}

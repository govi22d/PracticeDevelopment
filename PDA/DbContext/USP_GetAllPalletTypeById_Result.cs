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
    
    public partial class USP_GetAllPalletTypeById_Result
    {
        public int PalletTypeId { get; set; }
        public string PackageTypeId { get; set; }
        public int PalletFrames { get; set; }
        public string Description { get; set; }
        public int MaximumNumberOfPalletFrames { get; set; }
        public decimal PackageWeight { get; set; }
        public decimal PackageWeightDifference { get; set; }
        public decimal PackageMaximumWeight { get; set; }
        public int LoadLength { get; set; }
        public int LoadWidth { get; set; }
        public int LoadHeight { get; set; }
        public int NumberOfZeroWidthLocation { get; set; }
        public bool IsTrusted { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public int ObjectVersion { get; set; }
    }
}

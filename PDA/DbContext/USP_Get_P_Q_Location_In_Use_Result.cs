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
    
    public partial class USP_Get_P_Q_Location_In_Use_Result
    {
        public string LocationId { get; set; }
        public string LocationDescription { get; set; }
        public string LocationType { get; set; }
        public string LocationStatus { get; set; }
        public int LocationCapacity { get; set; }
        public string OwningDepartment { get; set; }
        public int PalletFrames { get; set; }
        public int Crane { get; set; }
        public string Storage { get; set; }
        public int StorageSurface { get; set; }
        public int StorageLevel { get; set; }
        public Nullable<int> LocationDepth { get; set; }
        public int ZoneNumber { get; set; }
        public int AccessTime { get; set; }
        public string LocationCompanionId { get; set; }
        public Nullable<int> LocationPackageHandling { get; set; }
        public bool EmptyPallet { get; set; }
        public int MaximumTransportTo { get; set; }
        public string Gate { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public string ImportedBy { get; set; }
        public Nullable<System.DateTime> ImportedTime { get; set; }
        public int ObjectVersion { get; set; }
    }
}

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
    
    public partial class USP_GetAllMasterGroups_Result
    {
        public string MasterTypeDescription { get; set; }
        public string ConfirmationModeDescription { get; set; }
        public string MasterGroupId { get; set; }
        public string Description { get; set; }
        public bool TransportAssignmentButtonActivated { get; set; }
        public int MasterTypeId { get; set; }
        public Nullable<int> ConfirmationModeId { get; set; }
        public string SinglepackageLabelType { get; set; }
        public string MixedpackageLabelType { get; set; }
        public int TuggerCapacity { get; set; }
        public bool PickBoxByBox { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public int ObjectVersion { get; set; }
    }
}
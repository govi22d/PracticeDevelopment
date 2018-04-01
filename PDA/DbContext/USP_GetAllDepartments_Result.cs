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
    
    public partial class USP_GetAllDepartments_Result
    {
        public string DepartmentId { get; set; }
        public string Description { get; set; }
        public string FactoryCode { get; set; }
        public Nullable<int> VC_ProfitCenter { get; set; }
        public string TypeOfOperationId { get; set; }
        public string TypeOfOperationDesc { get; set; }
        public string StorageTypeId { get; set; }
        public string StorageTypeDesc { get; set; }
        public string CostCenter { get; set; }
        public int AssemblyLineId { get; set; }
        public string ProductionLineDesc { get; set; }
        public int CapacityPerHour { get; set; }
        public bool NeedAssembly { get; set; }
        public bool TakeAway { get; set; }
        public bool PutAway { get; set; }
        public bool ForkliftTransport { get; set; }
        public bool AllowMPackage { get; set; }
        public bool AllowGPackage { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public int ObjectVersion { get; set; }
        public string MainStorage { get; set; }
        public Nullable<int> PickingPalletTypeId { get; set; }
        public Nullable<int> ProcessId { get; set; }
        public string ProcessName { get; set; }
        public bool PreparedForCustomer { get; set; }
        public bool TransportBlueBoxOnPallet { get; set; }
        public bool StrappingRequired { get; set; }
        public bool SplitMPackage { get; set; }
        public bool SplitGPackage { get; set; }
    }
}

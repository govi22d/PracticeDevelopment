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
    
    public partial class USP_EditableConditionCondition_Result
    {
        public string LocationId { get; set; }
        public Nullable<int> LocationCapacity { get; set; }
        public string LocationType { get; set; }
        public Nullable<int> LocationPackageHandling { get; set; }
        public string IsInventoryWithdrawalTypeSame { get; set; }
        public string IsDeliveryLocation { get; set; }
        public string IsPartOrderPrepared { get; set; }
        public string IsBookingPresentForMainPackage { get; set; }
        public string IsPkgBlocked { get; set; }
        public Nullable<int> TotalPkgsPresentAndInTransition { get; set; }
        public string NewLocationSiteId { get; set; }
        public string OldLocationSiteId { get; set; }
    }
}
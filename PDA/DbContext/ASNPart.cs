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
    
    public partial class ASNPart
    {
        public int ASNId { get; set; }
        public string PartNumber { get; set; }
        public string UnitCode { get; set; }
        public string DispatchedQuantity { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public int NumberOfSubPackages { get; set; }
        public string MaterialHandlingUnit { get; set; }
        public int NetWeight { get; set; }
        public string OrderReference { get; set; }
        public string BatchNumber { get; set; }
        public string OriginCountry { get; set; }
        public string OriginItem { get; set; }
        public string CurrencyCode { get; set; }
        public decimal InvoiceValue { get; set; }
        public string PartRevision { get; set; }
        public bool DocumentDmissing { get; set; }
        public int OriginalASNQuantity { get; set; }
        public bool ReleasedToProd { get; set; }
        public string ManualInvoiceNumber { get; set; }
        public Nullable<System.DateTime> ManualInvoiceDate { get; set; }
        public string ManualPurchaseOrderNumber { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public int ObjectVersion { get; set; }
    
        public virtual AdvanceShipmentNotice AdvanceShipmentNotice { get; set; }
    }
}
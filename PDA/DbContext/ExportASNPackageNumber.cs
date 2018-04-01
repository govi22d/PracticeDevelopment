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
    
    public partial class ExportASNPackageNumber
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExportASNPackageNumber()
        {
            this.ExportASNPackages = new HashSet<ExportASNPackage>();
        }
    
        public string AdvanceShipmentNotice { get; set; }
        public string PackageNumber { get; set; }
        public string PackageType { get; set; }
        public Nullable<decimal> GrossWeight { get; set; }
        public int PackageSize { get; set; }
        public string EmballageReferenceCode { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public int ObjectVersion { get; set; }
    
        public virtual ExportASN ExportASN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExportASNPackage> ExportASNPackages { get; set; }
    }
}

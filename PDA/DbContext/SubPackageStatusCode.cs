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
    
    public partial class SubPackageStatusCode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SubPackageStatusCode()
        {
            this.AllowedPackages = new HashSet<AllowedPackage>();
            this.CustomerReceivers = new HashSet<CustomerReceiver>();
            this.CustomerReceiverParts = new HashSet<CustomerReceiverPart>();
            this.LoadLists = new HashSet<LoadList>();
            this.MainPackagePickings = new HashSet<MainPackagePicking>();
            this.SubPackageStatus = new HashSet<SubPackageStatu>();
        }
    
        public int SubPackageStatusCodeId { get; set; }
        public string Description { get; set; }
        public bool Reserved { get; set; }
        public bool AddAllowed { get; set; }
        public bool DeleteAllowed { get; set; }
        public Nullable<int> StatusCodeType { get; set; }
        public string ShortName { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public int ObjectVersion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AllowedPackage> AllowedPackages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerReceiver> CustomerReceivers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerReceiverPart> CustomerReceiverParts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoadList> LoadLists { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MainPackagePicking> MainPackagePickings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubPackageStatu> SubPackageStatus { get; set; }
        public virtual SubPackageStatusCodeType SubPackageStatusCodeType { get; set; }
    }
}

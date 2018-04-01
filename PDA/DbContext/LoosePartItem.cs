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
    
    public partial class LoosePartItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoosePartItem()
        {
            this.LoosePartItem1 = new HashSet<LoosePartItem>();
            this.LoosePartItemPicks = new HashSet<LoosePartItemPick>();
            this.PartOrders = new HashSet<PartOrder>();
            this.SubPackages = new HashSet<SubPackage>();
            this.LoosePartItemKDPicks = new HashSet<LoosePartItemKDPick>();
        }
    
        public int Id { get; set; }
        public string CPOId { get; set; }
        public string PartNumber { get; set; }
        public int Quantity { get; set; }
        public Nullable<int> ParentPartId { get; set; }
        public int PickedQuantity { get; set; }
        public System.DateTime PickDate { get; set; }
        public System.DateTime PickDateTime { get; set; }
        public bool Kit { get; set; }
        public int OrderedQuantity { get; set; }
        public int BookedQuantity { get; set; }
        public int PackedQuantity { get; set; }
        public bool DocumentDuty { get; set; }
        public Nullable<int> KitStructureQuantity { get; set; }
        public Nullable<System.DateTime> PickedDate { get; set; }
        public System.DateTime PackDate { get; set; }
        public Nullable<System.DateTime> PackedDate { get; set; }
        public Nullable<int> StructureLevel { get; set; }
        public string ExecutionOrderId { get; set; }
        public Nullable<int> StatusOfPackage { get; set; }
        public decimal SummerizedUoM { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public int ObjectVersion { get; set; }
        public string UsePoint { get; set; }
        public bool ToPick { get; set; }
        public string RequisitionNumber { get; set; }
        public bool Visible { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoosePartItem> LoosePartItem1 { get; set; }
        public virtual LoosePartItem LoosePartItem2 { get; set; }
        public virtual LoosePartOrder LoosePartOrder { get; set; }
        public virtual LoosePartItemBlocking LoosePartItemBlocking { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoosePartItemPick> LoosePartItemPicks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartOrder> PartOrders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubPackage> SubPackages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoosePartItemKDPick> LoosePartItemKDPicks { get; set; }
    }
}

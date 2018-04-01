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
    
    public partial class AvailableLocation
    {
        public string LocationId { get; set; }
        public string LocationDescription { get; set; }
        public string LocationType { get; set; }
        public int LocationCapacity { get; set; }
        public bool LocationOccupied { get; set; }
        public int PalletFrames { get; set; }
        public int Crane { get; set; }
        public string Rack { get; set; }
        public int RackSurface { get; set; }
        public int RackLevelNumber { get; set; }
        public int LocationDepth { get; set; }
        public int ZoneNumber { get; set; }
        public string Area { get; set; }
        public int AccessTime { get; set; }
        public string LocationCompanionId { get; set; }
        public bool EmptyPalletFlag { get; set; }
        public int TransportAssignmentMaxiumOngoing { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public int ObjectVersion { get; set; }
    
        public virtual Location Location { get; set; }
    }
}

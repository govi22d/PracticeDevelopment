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
    
    public partial class ComponentProductionFlow
    {
        public string DeliveryUnit { get; set; }
        public int ProductionFlowSequence { get; set; }
        public string ProductionFlow { get; set; }
        public string Activity { get; set; }
        public Nullable<System.DateTime> PlanStartDay { get; set; }
        public Nullable<System.DateTime> PlanEndDay { get; set; }
        public string ExecutionOrderId { get; set; }
        public string NextExecutionOrder { get; set; }
        public string NextUsePoint { get; set; }
        public string ExecutionOrderState { get; set; }
        public bool IsMain { get; set; }
        public Nullable<System.DateTime> ActualStartTime { get; set; }
        public Nullable<System.DateTime> ActualEndTime { get; set; }
        public Nullable<int> Department { get; set; }
        public Nullable<System.DateTime> ResequencedStartTime { get; set; }
        public string EventType { get; set; }
        public Nullable<System.DateTime> EventTime { get; set; }
        public bool HasBeenFinished { get; set; }
        public int ObjectVersion { get; set; }
    
        public virtual ProductionLine ProductionLine { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Plant_Smart.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sensor
    {
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Token { get; set; }
        public string Type { get; set; }
        public Nullable<int> WateringDuration { get; set; }
        public string WateringSchedule { get; set; }
        public bool ShouldWater { get; set; }
    
        public virtual User User { get; set; }
    }
}

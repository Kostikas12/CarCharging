//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarCharging
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cars
    {
        public int ID_Car { get; set; }
        public int ID_Driver { get; set; }
        public string CarType { get; set; }
        public Nullable<double> CarBatteryLevel { get; set; }
        public Nullable<double> CarTimeToCharge { get; set; }
    
        public virtual Drivers Drivers { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectNew
{
    using System;
    using System.Collections.Generic;
    
    public partial class MeasuringUnit
    {
        public int ID { get; set; }
        public string UnitName { get; set; }
        public int PID { get; set; }
    
        public virtual Product Product { get; set; }
    }
}

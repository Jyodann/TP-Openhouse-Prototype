//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TP_OH_IIT_2020_API
{
    using System;
    using System.Collections.Generic;
    
    public partial class EventTiming
    {
        public int eventTimingID { get; set; }
        public int eventIDFK { get; set; }
        public System.DateTime startTimeOfEvent { get; set; }
        public System.DateTime endTimeOfEvent { get; set; }
    
        public virtual EventsTable EventsTable { get; set; }
    }
}
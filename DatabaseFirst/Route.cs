//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class Route
    {
        public int RouteID { get; set; }
        public int RouteUserID { get; set; }
        public int RouteOwnerID { get; set; }
        public string DestinationAirportID { get; set; }
    
        public virtual Airport Airport { get; set; }
        public virtual FlightCompany FlightCompany { get; set; }
        public virtual FlightCompany FlightCompany1 { get; set; }
    }
}

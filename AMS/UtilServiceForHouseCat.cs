//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class UtilServiceForHouseCat
    {
        public int Id { get; set; }
        public Nullable<int> HouseCatId { get; set; }
        public Nullable<int> UtilServiceId { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
    
        public virtual HouseCategory HouseCategory { get; set; }
        public virtual UtilityService UtilityService { get; set; }
    }
}

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
    
    public partial class UserRateAroundProvider
    {
        public int Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> AroundProviderId { get; set; }
        public Nullable<int> Point { get; set; }
    
        public virtual AroundProvider AroundProvider { get; set; }
        public virtual User User { get; set; }
    }
}
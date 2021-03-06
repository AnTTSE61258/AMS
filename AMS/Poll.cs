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
    
    public partial class Poll
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Poll()
        {
            this.BlockPolls = new HashSet<BlockPoll>();
            this.UserAnswerPolls = new HashSet<UserAnswerPoll>();
        }
    
        public int Id { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<System.DateTime> PublishDate { get; set; }
        public Nullable<int> Status { get; set; }
        public string Question { get; set; }
        public Nullable<int> Mode { get; set; }
        public Nullable<int> Priority { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public string Answer5 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BlockPoll> BlockPolls { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserAnswerPoll> UserAnswerPolls { get; set; }
    }
}

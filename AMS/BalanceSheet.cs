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
    
    public partial class BalanceSheet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BalanceSheet()
        {
            this.Transactions = new HashSet<Transaction>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.DateTime> ForMonth { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> ClosingDate { get; set; }
        public Nullable<System.DateTime> LastModified { get; set; }
        public Nullable<int> ManagerId { get; set; }
        public Nullable<double> TotalIncome { get; set; }
        public Nullable<double> TotalExpense { get; set; }
        public Nullable<double> TotalIncomeInCash { get; set; }
        public Nullable<double> TotalExpenseInCash { get; set; }
        public Nullable<double> RedundancyStartMonth { get; set; }
        public Nullable<double> RedundancyEndMonth { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual User User { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PortfolioManager_MingxuanJiang
{
    using System;
    using System.Collections.Generic;
    
    public partial class Instrument
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Instrument()
        {
            this.Prices = new HashSet<Price>();
            this.Trades = new HashSet<Trade>();
        }
    
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Ticker { get; set; }
        public string Exchange { get; set; }
        public string Underlying { get; set; }
        public Nullable<double> Strike { get; set; }
        public Nullable<double> Tenor { get; set; }
        public Nullable<bool> IsCall { get; set; }
        public Nullable<double> Rebate { get; set; }
        public Nullable<double> Barrier { get; set; }
        public string BarrierType { get; set; }
        public int InstTypeId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Price> Prices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trade> Trades { get; set; }
        public virtual InstType InstType { get; set; }
    }
}

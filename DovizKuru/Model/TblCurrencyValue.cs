//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DovizKuru.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblCurrencyValue
    {
        public int ID { get; set; }
        public Nullable<int> CurrencyID { get; set; }
        public Nullable<decimal> CureencyBuying { get; set; }
        public Nullable<decimal> CureencySelling { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual TblCurrency TblCurrency { get; set; }
    }
}

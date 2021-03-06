//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DynamicControl.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class State
    {
        public State()
        {
            this.Cities = new HashSet<City>();
            this.Customers = new HashSet<Customer>();
        }
    
        public System.Guid StateId_PK { get; set; }
        public string Name { get; set; }
        public Nullable<System.Guid> CountryID_FK { get; set; }
    
        public virtual ICollection<City> Cities { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}

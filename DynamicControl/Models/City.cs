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
    
    public partial class City
    {
        public City()
        {
            this.Customers = new HashSet<Customer>();
        }
    
        public System.Guid CityId_PK { get; set; }
        public string Name { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.Guid> StateID_FK { get; set; }
    
        public virtual State State { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}

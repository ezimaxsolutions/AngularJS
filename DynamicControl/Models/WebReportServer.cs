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
    
    public partial class WebReportServer
    {
        public System.Guid RSID_PK { get; set; }
        public Nullable<System.Guid> Reportid_FK { get; set; }
        public string ServerName { get; set; }
        public string ServerURL { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        public Nullable<bool> isActive { get; set; }
    
        public virtual WebReportCatalogue WebReportCatalogue { get; set; }
    }
}
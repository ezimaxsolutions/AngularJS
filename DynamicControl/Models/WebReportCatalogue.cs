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
    
    public partial class WebReportCatalogue
    {
        public WebReportCatalogue()
        {
            this.WebReportParameters = new HashSet<WebReportParameter>();
            this.WebReportServers = new HashSet<WebReportServer>();
        }
    
        public System.Guid ReportId_PK { get; set; }
        public string Name { get; set; }
        public Nullable<bool> isActive { get; set; }
        public string ReportPath { get; set; }
    
        public virtual ICollection<WebReportParameter> WebReportParameters { get; set; }
        public virtual ICollection<WebReportServer> WebReportServers { get; set; }
    }
}
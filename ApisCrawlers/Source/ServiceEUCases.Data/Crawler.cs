//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceEUCases.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Crawler
    {
        public Crawler()
        {
            this.DocumentGroups = new HashSet<DocumentGroup>();
        }
    
        public int CrawlerId { get; set; }
        public string CrawlerName { get; set; }
    
        public virtual ICollection<DocumentGroup> DocumentGroups { get; set; }
    }
}
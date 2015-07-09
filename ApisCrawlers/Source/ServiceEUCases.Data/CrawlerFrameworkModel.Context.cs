﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CrawlerFrameworkEntities : DbContext
    {
        public CrawlerFrameworkEntities()
            : base("name=CrawlerFrameworkEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Crawler> Crawlers { get; set; }
        public virtual DbSet<DocumentGroup> DocumentGroups { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<CrawlerLog> CrawlerLogs { get; set; }
    
        public virtual int p_DeleteDocumentGroup(string identifier)
        {
            var identifierParameter = identifier != null ?
                new ObjectParameter("identifier", identifier) :
                new ObjectParameter("identifier", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("p_DeleteDocumentGroup", identifierParameter);
        }
    }
}

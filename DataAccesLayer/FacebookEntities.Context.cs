﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccesLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FacebookEntities : DbContext
    {
        public FacebookEntities()
            : base("name=FacebookEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Friends> Friends { get; set; }
        public virtual DbSet<Images> Images { get; set; }
        public virtual DbSet<Request> Request { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersRequests> UsersRequests { get; set; }
    }
}
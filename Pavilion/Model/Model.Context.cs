﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pavilion.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_kingEntities : DbContext
    {
        public db_kingEntities()
            : base("name=db_kingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<employers> employers { get; set; }
        public virtual DbSet<pavilions> pavilions { get; set; }
        public virtual DbSet<postes> postes { get; set; }
        public virtual DbSet<rent> rent { get; set; }
        public virtual DbSet<shops_centers> shops_centers { get; set; }
        public virtual DbSet<statuses> statuses { get; set; }
        public virtual DbSet<tenants> tenants { get; set; }
    }
}
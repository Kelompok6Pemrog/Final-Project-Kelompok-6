﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace laundry_1._0
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class laundryEntities1 : DbContext
    {
        public laundryEntities1()
            : base("name=laundryEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<paket> pakets { get; set; }
        public virtual DbSet<pelanggan> pelanggans { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<transaksi_ambil> transaksi_ambil { get; set; }
        public virtual DbSet<transaksi_masuk> transaksi_masuk { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<detail_tm> detail_tm { get; set; }
    }
}

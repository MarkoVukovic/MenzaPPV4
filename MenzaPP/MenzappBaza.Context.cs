﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MenzaPP
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class menzappEntities : DbContext
    {
        public menzappEntities()
            : base("name=menzappEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Fakultet> Fakultets { get; set; }
        public virtual DbSet<Iksica> Iksicas { get; set; }
        public virtual DbSet<Jelovnik> Jelovniks { get; set; }
        public virtual DbSet<Komentari> Komentaris { get; set; }
        public virtual DbSet<Korisnik> Korisniks { get; set; }
        public virtual DbSet<Menza> Menzas { get; set; }
    }
}

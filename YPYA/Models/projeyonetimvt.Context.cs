﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YPYA.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class projeyonetimvtEntities : DbContext
    {
        public projeyonetimvtEntities()
            : base("name=projeyonetimvtEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bildirim> Bildirims { get; set; }
        public virtual DbSet<Durum> Durums { get; set; }
        public virtual DbSet<IsTakibi> IsTakibis { get; set; }
        public virtual DbSet<Kullanici> Kullanicis { get; set; }
        public virtual DbSet<KullaniciSurec> KullaniciSurecs { get; set; }
        public virtual DbSet<MusteriIsteri> MusteriIsteris { get; set; }
        public virtual DbSet<Oncelik> Onceliks { get; set; }
        public virtual DbSet<Proje> Projes { get; set; }
        public virtual DbSet<ProjeKullanici> ProjeKullanicis { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<Surec> Surecs { get; set; }
    }
}
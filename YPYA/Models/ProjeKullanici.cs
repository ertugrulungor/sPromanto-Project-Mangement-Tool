//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class ProjeKullanici
    {
        public int Id { get; set; }
        public Nullable<int> KullaniciId { get; set; }
        public Nullable<int> ProjeId { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public Nullable<bool> Durum { get; set; }
    
        public virtual Kullanici Kullanici { get; set; }
        public virtual Proje Proje { get; set; }
    }
}

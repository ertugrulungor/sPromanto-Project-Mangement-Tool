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
    
    public partial class MusteriIsteri
    {
        public int Id { get; set; }
        public string Icerik { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public Nullable<int> ProjeId { get; set; }
        public Nullable<int> MusteriId { get; set; }
        public string Baslik { get; set; }
    
        public virtual Kullanici Kullanici { get; set; }
        public virtual Proje Proje { get; set; }
    }
}

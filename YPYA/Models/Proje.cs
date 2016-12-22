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
    
    public partial class Proje
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proje()
        {
            this.MusteriIsteris = new HashSet<MusteriIsteri>();
            this.ProjeKullanicis = new HashSet<ProjeKullanici>();
            this.Surecs = new HashSet<Surec>();
        }
    
        public int Id { get; set; }
        public string Baslik { get; set; }
        public Nullable<int> OlusturanKullaniciId { get; set; }
        public Nullable<System.DateTime> PlanBaslangic { get; set; }
        public Nullable<System.DateTime> PlanBitis { get; set; }
        public Nullable<System.DateTime> GercekBaslangic { get; set; }
        public Nullable<System.DateTime> GercekBitis { get; set; }
        public Nullable<System.DateTime> Olusturulma { get; set; }
        public Nullable<decimal> Butce { get; set; }
    
        public virtual Kullanici Kullanici { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MusteriIsteri> MusteriIsteris { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjeKullanici> ProjeKullanicis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Surec> Surecs { get; set; }
    }
}

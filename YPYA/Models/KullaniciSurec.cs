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
    
    public partial class KullaniciSurec
    {
        public int Id { get; set; }
        public Nullable<int> KullaniciId { get; set; }
        public Nullable<int> SurecId { get; set; }
        public Nullable<int> RolId { get; set; }
        public Nullable<int> IstakibiId { get; set; }
    
        public virtual IsTakibi IsTakibi { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        public virtual Rol Rol { get; set; }
        public virtual Surec Surec { get; set; }
    }
}

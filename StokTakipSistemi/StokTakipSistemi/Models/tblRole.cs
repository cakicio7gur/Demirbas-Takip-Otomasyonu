//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StokTakipSistemi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblRole
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblRole()
        {
            this.tblKullanıcı = new HashSet<tblKullanıcı>();
        }
    
        public int roleId { get; set; }
        public string roleAd { get; set; }
        public Nullable<int> departmanId { get; set; }

        internal static List<tblRole> ToList()
        {
            throw new NotImplementedException();
        }

        public virtual tblDepartman tblDepartman { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKullanıcı> tblKullanıcı { get; set; }
    }
}

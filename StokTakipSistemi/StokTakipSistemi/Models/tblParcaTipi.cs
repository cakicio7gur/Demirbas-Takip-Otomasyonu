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
    
    public partial class tblParcaTipi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblParcaTipi()
        {
            this.tblUrunGenel = new HashSet<tblUrunGenel>();
        }
    
        public int urunParcaId { get; set; }
        public string parcaTipi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUrunGenel> tblUrunGenel { get; set; }
    }
}

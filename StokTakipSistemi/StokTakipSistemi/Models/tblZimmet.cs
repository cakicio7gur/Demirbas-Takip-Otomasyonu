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
    
    public partial class tblZimmet
    {
        public int zimmetId { get; set; }
        public Nullable<int> personelId { get; set; }
        public Nullable<int> urunId { get; set; }
    
        public virtual tblPersonel tblPersonel { get; set; }
        public virtual tblUrun tblUrun { get; set; }
    }
}

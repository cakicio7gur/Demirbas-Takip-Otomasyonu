//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemirbasOtomasyon.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Personeller
    {
        public Personeller()
        {
            this.Zimmetler = new HashSet<Zimmetler>();
        }
    
        public int personelID { get; set; }
        public string adi { get; set; }
        public string soyadi { get; set; }
        public string cepTelefonu { get; set; }
        public Nullable<int> departmanID { get; set; }
        public Nullable<System.DateTime> iseGirisTarihi { get; set; }
        public Nullable<System.DateTime> cikisTarihi { get; set; }
        public Nullable<bool> calismaDurumu { get; set; }
    
        public virtual Departmanlar Departmanlar { get; set; }
        public virtual ICollection<Zimmetler> Zimmetler { get; set; }
    }
}

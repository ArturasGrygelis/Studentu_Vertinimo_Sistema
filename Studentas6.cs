//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SVSistema
{
    using System;
    using System.Collections.Generic;
    
    public partial class Studentas6
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Studentas6()
        {
            this.Pazimys6 = new HashSet<Pazimys6>();
        }
    
        public int ID { get; set; }
        public string Studento_Vardas { get; set; }
        public string Studento_Pavardė { get; set; }
        public int Studento_GrupesNr { get; set; }
        public Nullable<int> Studento_ID { get; set; }
    
        public virtual Grupe_6 Grupe_6 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pazimys6> Pazimys6 { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjF1Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Piloto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Piloto()
        {
            this.PilotoCarroes = new HashSet<PilotoCarro>();
        }
    
        public int id { get; set; }
        public string nome { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PilotoCarro> PilotoCarroes { get; set; }

        public override string ToString() { return $"ID: {this.id}\nNome: {this.nome}\n"; }
    }
}

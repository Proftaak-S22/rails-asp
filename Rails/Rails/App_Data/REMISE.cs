//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rails.App_Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class REMISE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public REMISE()
        {
            this.LIJN = new HashSet<LIJN>();
            this.SPOOR = new HashSet<SPOOR>();
            this.TRAM = new HashSet<TRAM>();
            this.TRANSFER = new HashSet<TRANSFER>();
            this.TRANSFER1 = new HashSet<TRANSFER>();
        }
    
        public int ID { get; set; }
        public string Naam { get; set; }
        public Nullable<int> GroteServiceBeurtenPerDag { get; set; }
        public Nullable<int> KleineServiceBeurtenPerDag { get; set; }
        public Nullable<int> GroteSchoonmaakBeurtenPerDag { get; set; }
        public Nullable<int> KleineSchoonmaakBeurtenPerDag { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LIJN> LIJN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SPOOR> SPOOR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRAM> TRAM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANSFER> TRANSFER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANSFER> TRANSFER1 { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Backend.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class MESA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MESA()
        {
            this.ORDENES = new HashSet<ORDENE>();
        }
    
        public int ID_MESA { get; set; }
        public Nullable<int> CAPACIDAD { get; set; }
        public Nullable<int> ID_ESTADO { get; set; }
    
        public virtual ESTADO_MESAS ESTADO_MESAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDENE> ORDENES { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITravel_OnTour.Models.ORM_Agencia
{
    using System;
    using System.Collections.Generic;
    
    public partial class TIPOACTIVIDADVIAJE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPOACTIVIDADVIAJE()
        {
            this.ACTIVIDADVIAJE = new HashSet<ACTIVIDADVIAJE>();
        }
    
        public decimal IDTIPOACTIVIDADVIAJE { get; set; }
        public string NOMBRE { get; set; }
        public string DESCRIPCION { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACTIVIDADVIAJE> ACTIVIDADVIAJE { get; set; }
    }
}

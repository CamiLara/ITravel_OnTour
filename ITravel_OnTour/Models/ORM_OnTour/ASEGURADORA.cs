//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITravel_OnTour.Models.ORM_OnTour
{
    using System;
    using System.Collections.Generic;
    
    public partial class ASEGURADORA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ASEGURADORA()
        {
            this.POLIZASEGURO = new HashSet<POLIZASEGURO>();
        }
    
        public decimal IDASEGURADORA { get; set; }
        public string NOMBRE { get; set; }
        public string DIRECCION { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<POLIZASEGURO> POLIZASEGURO { get; set; }
    }
}

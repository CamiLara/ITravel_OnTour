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
    
    public partial class POLIZASEGURO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public POLIZASEGURO()
        {
            this.CONTRATO = new HashSet<CONTRATO>();
        }
    
        public decimal IDPOLIZASEGUROS { get; set; }
        public decimal IDALUMNO { get; set; }
        public decimal IDTIPOSEGURO { get; set; }
        public decimal IDASEGURADORA { get; set; }
        public Nullable<decimal> DESCRIPCIÓN { get; set; }
        public Nullable<System.DateTime> VIGENCIAINICIO { get; set; }
        public Nullable<System.DateTime> VIGENCIATERMINO { get; set; }
        public Nullable<System.DateTime> FECHACONTRATACION { get; set; }
        public Nullable<decimal> MONTOASEGURADO { get; set; }
    
        public virtual ALUMNO ALUMNO { get; set; }
        public virtual ASEGURADORA ASEGURADORA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTRATO> CONTRATO { get; set; }
        public virtual TIPOSEGURO TIPOSEGURO { get; set; }
    }
}

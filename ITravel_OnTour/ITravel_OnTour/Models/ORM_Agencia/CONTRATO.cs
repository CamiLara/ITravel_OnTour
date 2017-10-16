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
    
    public partial class CONTRATO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONTRATO()
        {
            this.ANEXOS = new HashSet<ANEXOS>();
            this.ITINERARIO = new HashSet<ITINERARIO>();
        }
    
        public decimal IDCONTRATO { get; set; }
        public decimal IDALUMNO { get; set; }
        public decimal IDCOLABORADOR { get; set; }
        public decimal IDTIPOCONTRATO { get; set; }
        public decimal IDPOLIZASEGUROS { get; set; }
        public Nullable<System.DateTime> FECHAINICIO { get; set; }
        public Nullable<System.DateTime> FECHATERMINO { get; set; }
        public decimal IDSERVICIO { get; set; }
        public string NOMBRE { get; set; }
    
        public virtual ALUMNO ALUMNO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ANEXOS> ANEXOS { get; set; }
        public virtual COLABORADOR COLABORADOR { get; set; }
        public virtual POLIZASEGURO POLIZASEGURO { get; set; }
        public virtual TIPOCONTRATO TIPOCONTRATO { get; set; }
        public virtual SERVICIO SERVICIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITINERARIO> ITINERARIO { get; set; }
    }
}
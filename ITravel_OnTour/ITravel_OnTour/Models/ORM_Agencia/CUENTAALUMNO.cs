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
    
    public partial class CUENTAALUMNO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CUENTAALUMNO()
        {
            this.ACTIVIDADAPORTES = new HashSet<ACTIVIDADAPORTES>();
            this.ESTADOCUENTA = new HashSet<ESTADOCUENTA>();
            this.PAGO = new HashSet<PAGO>();
        }
    
        public decimal IDCUENTAALUMNOS { get; set; }
        public decimal IDTIPOCUENTA { get; set; }
        public decimal IDALUMNO { get; set; }
        public Nullable<decimal> CUPOTOTAL { get; set; }
        public Nullable<decimal> CUPOUTILIZADO { get; set; }
        public decimal APORTE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACTIVIDADAPORTES> ACTIVIDADAPORTES { get; set; }
        public virtual ALUMNO ALUMNO { get; set; }
        public virtual TIPOCUENTA TIPOCUENTA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ESTADOCUENTA> ESTADOCUENTA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAGO> PAGO { get; set; }
    }
}
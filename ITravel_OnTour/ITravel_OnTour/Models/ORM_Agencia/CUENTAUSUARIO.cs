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
    
    public partial class CUENTAUSUARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CUENTAUSUARIO()
        {
            this.COLABORADOR = new HashSet<COLABORADOR>();
        }
    
        public decimal IDCUENTAUSUARIO { get; set; }
        public decimal IDPERFIL { get; set; }
        public string NOMBREUSUARIO { get; set; }
        public byte[] CONTRASENA { get; set; }
        public string APELLIDO { get; set; }
        public string CORREOELECTRONICO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COLABORADOR> COLABORADOR { get; set; }
        public virtual PERFIL PERFIL { get; set; }
    }
}

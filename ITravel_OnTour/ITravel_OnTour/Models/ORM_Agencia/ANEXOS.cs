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
    
    public partial class ANEXOS
    {
        public decimal IDANEXO { get; set; }
        public decimal IDCONTRATO { get; set; }
        public string ARCHIVO { get; set; }
        public string TOKEN { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
    
        public virtual CONTRATO CONTRATO { get; set; }
    }
}

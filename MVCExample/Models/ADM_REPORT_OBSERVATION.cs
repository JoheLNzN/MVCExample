//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCExample.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ADM_REPORT_OBSERVATION
    {
        public int RPTOBS_ID { get; set; }
        public int RPTOBS_ID_CUS { get; set; }
        public int RPTOBS_ID_SHIP { get; set; }
        public string RPTOBS_OBSERVATION { get; set; }
        public bool ISACTIVE { get; set; }
        public System.DateTime AUD_DATE_REGISTERED { get; set; }
        public Nullable<System.DateTime> AUD_DATE_LASTUPDATED { get; set; }
        public Nullable<int> AUD_USERID_REGISTERED { get; set; }
        public Nullable<int> AUD_USERID_LASTUPDATED { get; set; }
    
        public virtual ADM_CUSTOMER ADM_CUSTOMER { get; set; }
        public virtual ADM_SHIPMENT ADM_SHIPMENT { get; set; }
    }
}

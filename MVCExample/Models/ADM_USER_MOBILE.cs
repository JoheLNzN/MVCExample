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
    
    public partial class ADM_USER_MOBILE
    {
        public int UMOB_ID { get; set; }
        public int UMOB_USER_ID { get; set; }
        public string UMOB_TOKEN { get; set; }
        public Nullable<int> UMOB_ID_PHONE { get; set; }
        public string UMOB_STATUS { get; set; }
        public System.DateTime AUD_DATE_REGISTERED { get; set; }
        public Nullable<System.DateTime> AUD_DATE_LASTUPDATED { get; set; }
        public Nullable<int> AUD_USERID_REGISTERED { get; set; }
        public Nullable<int> AUD_USERID_LASTUPDATED { get; set; }
    
        public virtual ADM_USER ADM_USER { get; set; }
    }
}

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
    
    public partial class ADM_DISTRIBUTION_PALET
    {
        public int DPAL_ID { get; set; }
        public int DPAL_CONT_ID { get; set; }
        public string DPAL_ITEM_NRO { get; set; }
        public string DPAL_POSITION { get; set; }
        public string DPAL_LOTE_CODE { get; set; }
        public string DPAL_CODE_PALETA { get; set; }
        public string DPAL_ITEM_STATUS { get; set; }
        public string DPAL_ITEM_PHOTO { get; set; }
        public string DPAL_OBS_DESCRIPTION { get; set; }
        public bool ISACTIVE { get; set; }
        public System.DateTime AUD_DATE_REGISTERED { get; set; }
        public Nullable<System.DateTime> AUD_DATE_LASTUPDATED { get; set; }
        public Nullable<int> AUD_USERID_REGISTERED { get; set; }
        public Nullable<int> AUD_USERID_LASTUPDATED { get; set; }
    
        public virtual ADM_CONTAINER ADM_CONTAINER { get; set; }
    }
}
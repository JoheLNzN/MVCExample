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
    
    public partial class ADM_PHOTO
    {
        public int PHO_ID { get; set; }
        public int PHO_PHOTYPE_ID { get; set; }
        public int PHO_CONT_ID { get; set; }
        public string PHO_DESCRIPTION { get; set; }
        public string PHO_PATH { get; set; }
        public bool ISACTIVE { get; set; }
        public System.DateTime AUD_DATE_REGISTERED { get; set; }
        public Nullable<System.DateTime> AUD_DATE_LASTUPDATED { get; set; }
        public Nullable<int> AUD_USERID_REGISTERED { get; set; }
        public Nullable<int> AUD_USERID_LASTUPDATED { get; set; }
    
        public virtual ADM_CONTAINER ADM_CONTAINER { get; set; }
        public virtual ADM_PHOTO_TYPE ADM_PHOTO_TYPE { get; set; }
    }
}

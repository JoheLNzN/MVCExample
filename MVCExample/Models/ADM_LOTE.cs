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
    
    public partial class ADM_LOTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ADM_LOTE()
        {
            this.ADM_DISTRIBUTION = new HashSet<ADM_DISTRIBUTION>();
        }
    
        public int LOTE_ID { get; set; }
        public string LOTE_CODE { get; set; }
        public int LOTE_AMOUNT_ITEM { get; set; }
        public System.DateTime LOTE_DATE_REGISTERED { get; set; }
        public int LOTE_ITEMTY_ID { get; set; }
        public bool ISACTIVE { get; set; }
        public System.DateTime AUD_DATE_REGISTERED { get; set; }
        public Nullable<System.DateTime> AUD_DATE_LASTUPDATED { get; set; }
        public Nullable<int> AUD_USERID_REGISTERED { get; set; }
        public Nullable<int> AUD_USERID_LASTUPDATED { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADM_DISTRIBUTION> ADM_DISTRIBUTION { get; set; }
        public virtual ADM_ITEM_TYPE ADM_ITEM_TYPE { get; set; }
    }
}
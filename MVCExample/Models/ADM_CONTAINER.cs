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
    
    public partial class ADM_CONTAINER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ADM_CONTAINER()
        {
            this.ADM_ACTIVITY = new HashSet<ADM_ACTIVITY>();
            this.ADM_DISTRIBUTION_PALET = new HashSet<ADM_DISTRIBUTION_PALET>();
            this.ADM_NOTIFICATION = new HashSet<ADM_NOTIFICATION>();
            this.ADM_OBSERVATION = new HashSet<ADM_OBSERVATION>();
            this.ADM_PHOTO = new HashSet<ADM_PHOTO>();
        }
    
        public int CONT_ID { get; set; }
        public string CONT_CODE { get; set; }
        public int CONT_SHIP_ID { get; set; }
        public Nullable<int> CONT_USER_ID { get; set; }
        public Nullable<int> CONT_AMOUNT_ITEM { get; set; }
        public Nullable<int> CONT_GROUP_ITEM { get; set; }
        public Nullable<decimal> CONT_WEIGHT { get; set; }
        public string CONT_PREC_ADUANA { get; set; }
        public string CONT_PREC_LINE { get; set; }
        public string CONT_PREC_ITK { get; set; }
        public string CONT_PREC_CUS { get; set; }
        public string CONT_OBS { get; set; }
        public string CONT_STATE { get; set; }
        public Nullable<int> CONT_STATE_INSPECTION { get; set; }
        public Nullable<int> CONT_STATE_DETECTION { get; set; }
        public bool ISACTIVE { get; set; }
        public System.DateTime AUD_DATE_REGISTERED { get; set; }
        public Nullable<System.DateTime> AUD_DATE_LASTUPDATED { get; set; }
        public Nullable<int> AUD_USERID_REGISTERED { get; set; }
        public Nullable<int> AUD_USERID_LASTUPDATED { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADM_ACTIVITY> ADM_ACTIVITY { get; set; }
        public virtual ADM_SHIPMENT ADM_SHIPMENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADM_DISTRIBUTION_PALET> ADM_DISTRIBUTION_PALET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADM_NOTIFICATION> ADM_NOTIFICATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADM_OBSERVATION> ADM_OBSERVATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADM_PHOTO> ADM_PHOTO { get; set; }
    }
}

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
    
    public partial class ADM_USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ADM_USER()
        {
            this.ADM_ACTIVITY = new HashSet<ADM_ACTIVITY>();
            this.ADM_NOTIFICATION = new HashSet<ADM_NOTIFICATION>();
            this.ADM_USER_MOBILE = new HashSet<ADM_USER_MOBILE>();
        }
    
        public int USER_ID { get; set; }
        public string USER_NAME { get; set; }
        public string USER_LASTNAME { get; set; }
        public string USER_EMAIL { get; set; }
        public string USER_PASSWORD { get; set; }
        public string USER_DNI { get; set; }
        public Nullable<System.DateTime> USER_BIRTHDATE { get; set; }
        public string USER_MOB_PHONE { get; set; }
        public string USER_PHONE { get; set; }
        public string USER_TOKEN { get; set; }
        public int USER_ROL_ID { get; set; }
        public bool ISACTIVE { get; set; }
        public System.DateTime AUD_DATE_REGISTERED { get; set; }
        public Nullable<System.DateTime> AUD_DATE_LASTUPDATED { get; set; }
        public Nullable<int> AUD_USERID_REGISTERED { get; set; }
        public Nullable<int> AUD_USERID_LASTUPDATED { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADM_ACTIVITY> ADM_ACTIVITY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADM_NOTIFICATION> ADM_NOTIFICATION { get; set; }
        public virtual ADM_ROL ADM_ROL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADM_USER_MOBILE> ADM_USER_MOBILE { get; set; }
    }
}

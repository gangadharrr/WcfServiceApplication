//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfServiceApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LMS_SUPPLIERS_DETAILS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LMS_SUPPLIERS_DETAILS()
        {
            this.LMS_BOOK_DETAILS = new HashSet<LMS_BOOK_DETAILS>();
        }
    
        public string SUPPLIER_ID { get; set; }
        public string SUPPLIER_NAME { get; set; }
        public string ADDRESS_ { get; set; }
        public Nullable<int> CONTACT { get; set; }
        public string EMAIL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LMS_BOOK_DETAILS> LMS_BOOK_DETAILS { get; set; }
    }
}

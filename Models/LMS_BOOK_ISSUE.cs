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
    
    public partial class LMS_BOOK_ISSUE
    {
        public int BOOK_ISSUE_NO { get; set; }
        public string MEMBER_ID { get; set; }
        public string BOOK_CODE { get; set; }
        public Nullable<System.DateTime> DATE_ISSUE { get; set; }
        public Nullable<System.DateTime> DATE_RETURN { get; set; }
        public Nullable<System.DateTime> DATE_RETURNED { get; set; }
        public string FINE_RANGE { get; set; }
    
        public virtual LMS_BOOK_DETAILS LMS_BOOK_DETAILS { get; set; }
        public virtual LMS_MEMBERS LMS_MEMBERS { get; set; }
        public virtual LMS_FINE_DETAILS LMS_FINE_DETAILS { get; set; }
    }
}
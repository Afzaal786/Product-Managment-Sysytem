//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Product_Managment
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRO_ISSUENCE
    {
        public int issueId { get; set; }
        public int bookId { get; set; }
        public int memberId { get; set; }
        public int employeeId { get; set; }
        public System.DateTime issueOn { get; set; }
        public System.DateTime returnDate { get; set; }
    
        public virtual EMPLOYEE EMPLOYEE { get; set; }
        public virtual MEMBER MEMBER { get; set; }
        public virtual PROD PROD { get; set; }
    }
}

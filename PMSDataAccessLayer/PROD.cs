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
    
    public partial class PROD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROD()
        {
            this.PRO_ISSUENCE = new HashSet<PRO_ISSUENCE>();
            this.MANUs = new HashSet<MANU>();
        }
    
        public int bookId { get; set; }
        public string bookName { get; set; }
        public int purchasePrice { get; set; }
        public Nullable<int> publisherId { get; set; }
        public Nullable<int> catagoryId { get; set; }
        public Nullable<int> rackId { get; set; }
        public Nullable<int> sectionId { get; set; }
    
        public virtual CATAGORY CATAGORY { get; set; }
        public virtual PPUBLISHER PPUBLISHER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRO_ISSUENCE> PRO_ISSUENCE { get; set; }
        public virtual RACK RACK { get; set; }
        public virtual SECTION SECTION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MANU> MANUs { get; set; }
    }
}
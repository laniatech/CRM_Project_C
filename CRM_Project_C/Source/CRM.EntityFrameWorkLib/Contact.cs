namespace CRM.EntityFrameWorkLib
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contact
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contact()
        {
            this.EmailLists = new HashSet<EmailList>();
        }
    
        public int ContactId { get; set; }
        public string FullName { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public System.Guid GuID { get; set; }
        public System.DateTime DateInserted { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmailList> EmailLists { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UniversityManagementSystem.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Instructors
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Instructors()
        {
            this.Courses = new HashSet<Courses>();
        }
    
        public int i_id { get; set; }
        public string i_name { get; set; }
        public string i_lastname { get; set; }
        public string i_username { get; set; }
        public Nullable<System.DateTime> i_birthdate { get; set; }
        public string i_email { get; set; }
        public string i_password { get; set; }
        public Nullable<byte> dep_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Courses> Courses { get; set; }
        public virtual Department Department { get; set; }
    }
}

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
    
    public partial class StudentNotes
    {
        public int n_id { get; set; }
        public Nullable<int> student_id { get; set; }
        public Nullable<int> course_id { get; set; }
        public Nullable<short> n_midterm { get; set; }
        public Nullable<short> n_final { get; set; }
        public Nullable<decimal> n_avarage { get; set; }
        public string n_grade { get; set; }
        public Nullable<bool> n_status { get; set; }
    
        public virtual Courses Courses { get; set; }
        public virtual Students Students { get; set; }
    }
}

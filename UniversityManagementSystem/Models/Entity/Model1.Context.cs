﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UniversityDbEntities1 : DbContext
    {
        public UniversityDbEntities1()
            : base("name=UniversityDbEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Instructors> Instructors { get; set; }
        public virtual DbSet<StudentNotes> StudentNotes { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
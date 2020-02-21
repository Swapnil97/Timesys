using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NessTechnologies.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace NessTechnologies.DAL
{
    public class NessContext: DbContext
    {
        public NessContext() : base("NessContext") {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {   
            /*This is to keep table names as singular and not plurals*/
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NessTechnologies.Models;
using System.Data.Entity;



namespace NessTechnologies.DAL
{
    public class NessInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<NessContext> //if any change in model drop the database
    {
        protected override void Seed(NessContext context)
        {
            var employees = new List<Employee> {
            new Employee{ID=1,Fname="Swapnil",Lname="Kshirsagar",EnrollmentDate=DateTime.Parse("2019-09-12")},
            new Employee {ID=2,Fname="Rudrakant",Lname="Tiwari",EnrollmentDate=DateTime.Parse("2015-09-12") },
            new Employee{ID=3,Fname="Pankaj",Lname="Thapliyal",EnrollmentDate=DateTime.Parse("2010-09-12") },
            new Employee{ID=4,Fname="Rakesh",Lname="Lad",EnrollmentDate=DateTime.Parse("2008-09-12")}
                                               };
                employees.ForEach(s=>context.Employees.Add(s));
                context.SaveChanges();


            var departments = new List<Department> {
                new Department{DepartmentID=1,Name="De Beers",TeamCount=21},
                new Department{DepartmentID=2,Name="Pearson",TeamCount=100},
                new Department{DepartmentID=3,Name="LNF",TeamCount=5}
            };

            departments.ForEach(s => context.Departments.Add(s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
                new Enrollment{DepartmentID=1,EmployeeID=1,EnrollmentID=1,Domain=Domain.Dev},
                new Enrollment{DepartmentID=2,EmployeeID=2,EnrollmentID=2,Domain=Domain.Lead},
                new Enrollment{DepartmentID=3,EmployeeID=3,EnrollmentID=3,Domain=Domain.Manager},
                new Enrollment{DepartmentID=3,EmployeeID=2,EnrollmentID=4,Domain=Domain.Tester},
                new Enrollment{DepartmentID=2,EmployeeID=4,EnrollmentID=5,Domain=Domain.Dev}
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();

        }
    }
}
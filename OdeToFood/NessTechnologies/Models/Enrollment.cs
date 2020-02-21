using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NessTechnologies.Models
{
    public class Enrollment
    {
        public int DepartmentID { get; set; }
        public int EmployeeID { get; set; }
        public int EnrollmentID { get; set; }
        public Domain? Domain { get; set; }

        public virtual Department Department { get; set; }
        public virtual Employee Employee { get; set; }
       
    }
    public enum Domain
    {
        Dev,
        Tester,
        BA,
        Lead,
        Manager
    }
}
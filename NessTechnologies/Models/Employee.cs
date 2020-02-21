using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NessTechnologies.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string Gender { get; set; }
        public Boolean IsActive { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
        
    }
}
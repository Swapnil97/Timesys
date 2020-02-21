using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NessTechnologies.Models
{
    public class Department
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DepartmentID{ get; set; }
        public string Name { get; set; }
        public int TeamCount { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
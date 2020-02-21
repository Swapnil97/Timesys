using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnderstandViewdataViewbag.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public Boolean Present { get; set; }
        public decimal Salary { get; set; }
    }
}
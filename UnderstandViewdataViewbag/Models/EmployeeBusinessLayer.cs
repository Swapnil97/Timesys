using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnderstandViewdataViewbag.Models
{
    public class EmployeeBusinessLayer
    {
        public Employee GetEmployeeDetails(int ID)
        {
            Employee employee=new Employee()
            {
                ID=ID,
                Name="Durgesh",
                Gender="Male",
                Address="Thane",


            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class UserViewModel
    {
        public Member Members { get; set; }
        public Team Teams { get; set; }
        public TimesheetExcel TimesheetExcels { get; set; } 

    }
}
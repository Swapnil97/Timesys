using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class UserViewModel
    {
        public Member Members { get; set; }
        public Team Teams { get; set; }
        public TimesheetExcel TimesheetExcels { get; set; } 
        public Shift Shifts { get; set; }
        public Application Applications { get; set; }
        public Task Tasks { get; set; }
        public Activity Activities { get; set; }
        public Priority_Severity Priority { get; set; }
        public string Description { get; set; }
        public string Release { get; set; }

        [DataType(DataType.Date)]
        public DateTime Start_Date;
    }
}
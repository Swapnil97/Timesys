using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using static RegForm.Models.Types;

namespace RegForm.Models
{
    public class Reg
    {
        [Required(ErrorMessage = "Please enter id.")]/*[Range(1,500)]*/[StringLength(8)]
        public string Id { get; set; }


        [Required(ErrorMessage = "Please enter department name.")]
        public DepartmentNames Department { get; set; }


        [Required(ErrorMessage = "Please enter DOB.")]
        public DateTime Dob { get; set; }



        [Required(ErrorMessage = "Please enter email.")]
        /* [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]*/
        [EmailAddress]
        public string Email { get; set; }


        [Required(ErrorMessage = "Please enter designation.")]
        public DesignationTypes Designation { get; set; }
    }
}
    

    
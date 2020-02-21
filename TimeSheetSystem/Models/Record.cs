using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TimeSheetSystem.Models
{
    public class Record
    {
        [Key]
        [Display(Name = "Team")]
        public string Team { get; set; }
        [Display(Name = "L3 Dev")]
        public float L3Dev { get; set; }
        [Display(Name = "L3 Qa")]
        public float L3Qa { get; set; }
        [Display(Name = "L2 Support")]
        public float L2Support { get; set; }
        [Display(Name = "L3 Ba")]
        public float L3Ba { get; set; }
        [Display(Name = "Adhoc")]
        public float Adhoc { get; set; }
        [Display(Name = "Others")]
        public float Others { get; set; }
        [Display(Name = "Leave")]
        public float Leave { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Member
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int TeamID { get; set; }
        public int PostID { get; set; }
    
        public virtual Post Post { get; set; }
        public virtual Team Team { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularWebApi.Models
{
    public class EntityFormViewModel
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string Gender { get; set; }
        public Nullable<bool> Java { get; set; }
        public Nullable<bool> Net { get; set; }
        public Nullable<bool> UI { get; set; }
        public string[] City { get; set; }

    }
}
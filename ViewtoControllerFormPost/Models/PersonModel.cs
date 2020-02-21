using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewtoControllerFormPost.Models
{
    public class PersonModel    //first made the model and wrote properties inside it
    {
            public int PersonId { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
            public string City { get; set; }
    }
}
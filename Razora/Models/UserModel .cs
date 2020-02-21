using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Razora.Models
{
    public enum Country
    {
        India,
        USA,
        UK,
        Canada
    }
    public class UserModel
    {
        public Country Countries { get; set; }
        public IEnumerable <SelectListItem> CountryList { get; set; }
        public UserModel()
        {
            CountryList = Enum.GetNames(typeof(Country)).Select(name => new SelectListItem()
            {
                Text = name,
                Value = name
            });
        }
    }
}
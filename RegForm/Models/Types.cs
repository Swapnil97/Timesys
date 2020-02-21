using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegForm.Models
{
    public class Types
    {
        public enum DesignationTypes
        {
            None,
            Developer,
            Tester,
            BA,
            Manager
        }

        public enum DepartmentNames
        {
            Bench,
            Pearson,
            DeBeers,
            Vix
        }
    }
}
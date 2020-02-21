using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TimeSheetSystem.Models
{
    public class TimesheetContext : DbContext
    {
        public TimesheetContext()
            : base("name=Constring")
        {
        }

        public virtual DbSet<Entry> Entries { get; set; }
    }
}
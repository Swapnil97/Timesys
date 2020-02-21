using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TimeSheetSystem.Models;

namespace MVCSimpleApp.Models
{
    public class RecordContext : DbContext
    {
        public DbSet<Record> Record { get; set; }

    }
}
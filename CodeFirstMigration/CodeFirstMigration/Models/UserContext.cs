using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;

namespace CodeFirstMigration.Models
{
    public class UserContext:DbContext       
    {
        public UserContext():base("ConnectionStr")
        {

        }
        public DbSet<UserInfo> UserInfo { get; set; }
    }
}
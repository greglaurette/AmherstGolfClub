using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AmherstGolfClub.DAL
{
    public class GolfContext:DbContext
    {
        public GolfContext() : base("DefaultConnection") { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
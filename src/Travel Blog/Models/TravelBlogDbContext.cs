using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Travel_Blog.Models
{
    public class TravelBlogDbContext : DbContext
    {
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<People> Peoples { get; set; }
    }
}

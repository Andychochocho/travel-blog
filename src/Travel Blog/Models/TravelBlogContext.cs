using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Travel_Blog.Models
{
    public class TravelBlogContext : DbContext
    {
        public virtual DbSet<Experience> Experiences { get; set; }
        public virtual DbSet<People> Peoples { get; set; }
        protected override void OnConfiguring (DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TravelBlog;integrated security = True");
        }
    }
}
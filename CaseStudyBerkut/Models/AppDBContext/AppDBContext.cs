using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CaseStudyBerkut.Models;
using Microsoft.EntityFrameworkCore;

namespace CaseStudyBerkut.Models.AppDBContext
{
    public class AppDBContext:DbContext
    {
        public AppDBContext() : base()
        {

        }
        private readonly DbContextOptions _options;
        public AppDBContext(DbContextOptions options) : base(options)
        {
            _options = options;
        }

        public virtual DbSet<Users> User { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
 
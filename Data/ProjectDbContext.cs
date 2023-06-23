using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Szkolenie_techniczne_3_projekt.Models;

namespace Szkolenie_techniczne_3_projekt.Data
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions options) : base(options)
        {
        }

       
        public DbSet<Students> Students { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
    }
}

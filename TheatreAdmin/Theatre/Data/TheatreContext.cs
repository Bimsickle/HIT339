using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Theatre.Models;

namespace Theatre.Data
{
    public class TheatreContext : DbContext
    {
        public TheatreContext (DbContextOptions<TheatreContext> options)
            : base(options)
        {
        }

        public DbSet<Theatre.Models.Movie> Movie { get; set; }
    }
}

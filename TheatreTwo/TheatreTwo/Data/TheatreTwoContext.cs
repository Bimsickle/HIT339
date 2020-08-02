using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheatreTwo.Models;

namespace TheatreTwo.Data
{
    public class TheatreTwoContext : DbContext
    {
        public TheatreTwoContext (DbContextOptions<TheatreTwoContext> options)
            : base(options)
        {
        }

        public DbSet<TheatreTwo.Models.Movie> Movie { get; set; }
    }
}

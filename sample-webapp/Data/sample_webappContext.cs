using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using sample_webapp.Models;

namespace sample_webapp.Data
{
    public class sample_webappContext : DbContext
    {
        public sample_webappContext (DbContextOptions<sample_webappContext> options)
            : base(options)
        {
        }

        public DbSet<sample_webapp.Models.Movie> Movie { get; set; }
    }
}

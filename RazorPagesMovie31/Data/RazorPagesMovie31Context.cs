using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie31.Models;

namespace RazorPagesMovie31.Data
{
    public class RazorPagesMovie31Context : DbContext
    {
        public RazorPagesMovie31Context (DbContextOptions<RazorPagesMovie31Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie31.Models.Movie> Movie { get; set; }
    }
}

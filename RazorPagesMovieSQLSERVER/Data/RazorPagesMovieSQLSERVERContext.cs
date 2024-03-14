using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovieSQLSERVER.Models;

namespace RazorPagesMovieSQLSERVER.Data
{
    public class RazorPagesMovieSQLSERVERContext : DbContext
    {
        public RazorPagesMovieSQLSERVERContext (DbContextOptions<RazorPagesMovieSQLSERVERContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovieSQLSERVER.Models.Movie> Movie { get; set; } = default!;
    }
}

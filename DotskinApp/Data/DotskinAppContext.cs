using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DotskinApp.Models;

namespace DotskinApp.Data
{
    public class DotskinAppContext : DbContext
    {
        public DotskinAppContext (DbContextOptions<DotskinAppContext> options)
            : base(options)
        {
        }

        public DbSet<DotskinApp.Models.Pokemon> Pokemon { get; set; } = default!;
    }
}

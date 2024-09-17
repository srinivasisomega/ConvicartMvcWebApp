using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ConvicartMvcWebApp.Models;

namespace ConvicartMvcWebApp.Data
{
    public class ConvicartMvcWebAppContext : DbContext
    {
        public ConvicartMvcWebAppContext (DbContextOptions<ConvicartMvcWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<ConvicartMvcWebApp.Models.User> User { get; set; } = default!;
    }
}

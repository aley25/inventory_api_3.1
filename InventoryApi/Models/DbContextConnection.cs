using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApi.Models
{
    public class DbContextConnection : DbContext
    {
        public DbContextConnection(DbContextOptions<DbContextConnection> options) : base(options)
        {
        }

        public DbSet<Articulo> Articulo { get; set; }

        public DbSet<Marca> Marca { get; set; }
    }
}

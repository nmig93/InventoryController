using InventoryController.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryController.Data
{
    public class InventoryDbContext : DbContext
    {
        public InventoryDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<DbItems> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<DbItems>(x =>
            {
                x.HasKey(x => x.ItemId);
                x.ToTable("Items");
            });
        }
    }
}

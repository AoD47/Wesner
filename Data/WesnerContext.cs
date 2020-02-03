using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Wesner.Models;

namespace Wesner.Data
{
    public class WesnerContext : DbContext
    {
        public WesnerContext(DbContextOptions<WesnerContext> options)
            : base(options)
        {
        }

        public DbSet<Wesner.Models.Item> Items { get; set; }
        public DbSet<ItemPrice> ItemPrices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemPrice>()
                .HasOne(i => i.Item)
                .WithMany(i => i.PriceHistory)
                .HasForeignKey(f => f.ItemId)
                .HasConstraintName("ForeignKey_ItemPrice_Item")
                .HasPrincipalKey(p => p.Id);
        }
    }
}

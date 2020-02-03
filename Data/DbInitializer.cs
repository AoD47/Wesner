using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wesner.Models;

namespace Wesner.Data
{
    public static class DbInitializer
    {
        public static void Initialize(WesnerContext context)
        {
            _ = context.Database.EnsureCreated();

            // Look for any data 
            if (context.Items.Any())
            {
                return; // DB Have been seeded
            }
            else
            {
                var Items = new Item[]
                {
                new Item{Id=1,Name="3D Printer", Description= "Tool to create 3D objects",UnitOfMesure="unit"}
                };

                foreach (var item in Items)
                {
                    context.Items.Add(item);
                }
                context.SaveChanges();
            }
            if (context.ItemPrices.Any())
            {
                return;
            }
            else
            {
                var ItemPrices = new ItemPrice[]
                {
                    new ItemPrice{ItemId=1,Price=3000.50,TimeStamp= new DateTime()}
                };
            }


        }
    }
}

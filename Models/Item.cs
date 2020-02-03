using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wesner.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UnitOfMesure { get; set; }

        public IEnumerable<ItemPrice> PriceHistory { get; set; }
    }
}

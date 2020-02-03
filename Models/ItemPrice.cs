using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Wesner.Models
{
    public class ItemPrice
    {
        public int ItemId { get; set; }
        public double Price { get; set; }
        public DateTime TimeStamp { get; set; }
        public Item Item { get; set; }
    }
}

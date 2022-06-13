using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMarket.Scripts
{
    public class LocalBush
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }

        public LocalBush(string name, int price)
        {
            Name = name; 
            Price = price;
        }

        public LocalBush(string name, int price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
        }
    }
}

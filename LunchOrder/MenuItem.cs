using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchOrder
{
    public class MenuItem
    {
        public string Name { get; }
        public decimal Price { get; }
        public decimal SidePrice { get; }
        public List<string> Sides { get; }

        public MenuItem(string name, decimal price, decimal sidePrice, List<string> sides)
        {
            Name = name;
            Price = price;
            SidePrice = sidePrice;
            Sides = sides;
        }
    }
}

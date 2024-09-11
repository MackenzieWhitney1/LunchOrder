using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchOrder
{
    public class Menu
    {
        public List<MenuItem> Items { get; }

        public Menu()
        {
            Items = new List<MenuItem>
        {
            new MenuItem("Hamburger", 6.95m, 0.75m, new List<string>
            { "Lettuce, tomato, and onions", "Ketchup, mustard, and mayo", "French fries" }),

            new MenuItem("Pizza", 5.95m, 0.5m, new List<string>
            { "Pepperoni", "Sausage", "Olives" }),

            new MenuItem("Salad", 4.95m, 0.25m, new List<string>
            { "Croutons", "Bacon bits", "Bread sticks" })
        };
        }

        public MenuItem GetItemByName(string name)
        {
            return Items.FirstOrDefault(item => item.Name == name);
        }
    }

}

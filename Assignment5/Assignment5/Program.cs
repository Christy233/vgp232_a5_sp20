using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();
            items.Add(new Item("apple", 1, 0));
            items.Add(new Item("apple2", 1, 0));
            items.Add(new Item("apple3", 1, 0));
            items.Add(new Item("apple4", 1, 0));
            items.Add(new Item("apple5", 1, 0));
            items.Remove(new Item("apple", 1, 0));
            foreach (Item item in items)
            {
                Console.WriteLine(items);
            }


            // TODO: initialize the inventory
            // Add a few items
            // Remove a few items
            // show the inventory.

        }
    }
}

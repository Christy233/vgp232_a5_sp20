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
            Inventory inventory = new Inventory(10);
            Item apple = new Item("apple", 1, ItemType.consumable);
            Item apple2 = new Item("apple2", 1, ItemType.consumable);
            Item apple3 = new Item("apple3", 1, ItemType.consumable);
            Item apple4 = new Item("apple4", 1, ItemType.consumable);

            inventory.Add(apple);
            inventory.Add(apple2);
            inventory.Add(apple3);
            inventory.Add(apple4);

            inventory.Remove(apple);
            inventory.ShowInventory();




            // TODO: initialize the inventory
            // Add a few items
            // Remove a few items
            // show the inventory.

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Inventory
    {
        int slots;
        List<Item> items;

        public Inventory(int slots)
        {
            items = new List<Item>(slots);
        }

        public void Add(Item item)
        {
            items.Add(item);
            // TODO: add implementation.
            //throw new NotImplementedException();
        }

        public void Remove(Item item)
        {
            items.Remove(item);
            // TODO: add implementation.

            //throw new NotImplementedException();
        }

        public void ShowInventory()
        {
            // TODO: add implementation.
            foreach (var item in items)
            {
                Console.WriteLine($"Name: {item.Name}, Modifier: {item.Modifier}, Type: {item.IType}");
            }
            //throw new NotImplementedException();
        }
    }
}

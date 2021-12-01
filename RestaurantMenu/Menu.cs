using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    public class Menu
    {
        public List<MenuItem> Items { get; set; }
        public DateTime LastUpdated { get; set; }
        public Menu (List<MenuItem> items, DateTime lastUpdated)
        {
            Items = items;
            LastUpdated = lastUpdated;
        }
        public void AddItem(MenuItem item) 
        {
            Items.Add(item);
        }
        public void RemoveItem(MenuItem item)
        {
            if (Items.Contains(item))
            {
                Items.Remove(item);
            }
            else
            {
                Console.WriteLine("That ain't on the menu.");
            }
        }
        public void CheckLastUpdat()
        {
            Console.WriteLine($"Menu was updated on {LastUpdated}");
        }
        
    }
}

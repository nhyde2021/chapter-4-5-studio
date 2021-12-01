using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuItem burger = new MenuItem("Big af Burger", 9.99, "Its a burger", "Sandwiches", false);
            MenuItem shake = new MenuItem("Milk Shake", 5.00, "Chocolate or Vanilla", "Dessert", true);

            List<MenuItem> newMenu = new List<MenuItem>();
            Menu neilsRestaurant = new Menu(newMenu, new DateTime(2021, 11, 29));

            neilsRestaurant.AddItem(burger);
            burger.ItemIsNew();
        }
    }
}

using System;

namespace RestaurantApp
{
    public class FastFoodMains : IMenu
    {
        public void PrintMenu()
        {
            Console.WriteLine("Burger, Chicken Nuggets, Chicken Sandwich, Tacos, Wrap, Chicken Tenders");
        }
    }
}
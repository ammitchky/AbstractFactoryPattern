using System;

namespace RestaurantApp
{
    public class FastFoodDrinks : IMenu
    {
        public void PrintMenu()
        {
            Console.WriteLine("Soda, Tea, Slushies, Icee, Coffee, Water");
        }
    }
}
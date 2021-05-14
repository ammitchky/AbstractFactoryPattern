using System;

namespace RestaurantApp
{
    public class AsianAppetizers : IMenu
    {
        public void PrintMenu()
        {
            Console.WriteLine("Dumplings, Chicken Wings, Egg Rolls, Spring Rolls, Miso Soup, Onigiri");
        }
    }
}
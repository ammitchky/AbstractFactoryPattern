using System;

namespace RestaurantApp
{
    public class MexicanAppetizers : IMenu
    {
        public void PrintMenu()
        {
            Console.WriteLine("Nachos, Chips and Salsa, Chips and Guacamole");
        }
    }
}
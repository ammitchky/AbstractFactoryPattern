using System;

namespace RestaurantApp
{
    public class FastFoodAppetizers : IMenu
    {
        public void PrintMenu()
        {
            Console.WriteLine("Onion Rings, Tator Tots, Rolls, Biscuits, Cheese Sticks");
        }
    }
}
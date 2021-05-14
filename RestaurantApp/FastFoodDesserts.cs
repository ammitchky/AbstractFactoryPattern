using System;

namespace RestaurantApp
{
    public class FastFoodDesserts : IMenu
    {
        public void PrintMenu()
        {
            Console.WriteLine("Milkshake, Ice Cream, Pizookie, Brownie, Cake");
        }
    }
}
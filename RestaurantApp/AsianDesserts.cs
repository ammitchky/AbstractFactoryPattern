using System;

namespace RestaurantApp
{
    public class AsianDesserts : IMenu
    {
        public void PrintMenu()
        {
            Console.WriteLine("Fortune Cookies, Mochi, Taiyaki, Sweet Custard Buns, Green Tea Ice Cream");
        }
    }
}
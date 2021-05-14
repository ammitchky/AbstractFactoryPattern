using System;

namespace RestaurantApp
{
    public class MexicanDesserts : IMenu
    {
        public void PrintMenu()
        {
            Console.WriteLine("Churros, Sopapillas, Tres Leches, Flan");
        }
    }
}
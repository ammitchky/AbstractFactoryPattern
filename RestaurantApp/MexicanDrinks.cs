using System;

namespace RestaurantApp
{
    public class MexicanDrinks : IMenu
    {
        public void PrintMenu()
        {
            Console.WriteLine("Mexican Soda, Magaritas, Sangria, Water, Dos Equis");
        }
    }
}
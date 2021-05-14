using System;

namespace RestaurantApp
{
    public class AsianMains : IMenu
    {
        public void PrintMenu()
        {
            Console.WriteLine("Sushi, Lo Mein, Pho, Ramen, Peking Duck, Udon, Steamed Fish, Teriyaki Chicken");
        }
    }
}
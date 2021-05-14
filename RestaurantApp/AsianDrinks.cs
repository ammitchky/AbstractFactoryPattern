using System;

namespace RestaurantApp
{
    public class AsianDrinks : IMenu
    {
        public void PrintMenu()
        {
            Console.WriteLine("Boba Tea, Chai Tea, Milk Tea, Ramune, Water, Matcha, Sake, Soju");
        }
    }
}
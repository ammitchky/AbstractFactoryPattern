using System;

namespace RestaurantApp
{
    public class MexicanMains : IMenu
    {
        public void PrintMenu()
        {
            Console.WriteLine("Enchiladas, Tacos, Quesidillas, Burritos, Fajitas, ");
        }
    }
}
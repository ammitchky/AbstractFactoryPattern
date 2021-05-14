using System;
using System.Text;

namespace RestaurantApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Cafe Hub");
            Console.WriteLine("What cuisine do you want to eat? (Asian, Fast Food, Mexican): ");
            var input = Console.ReadLine();
            var factory = GetFoodFactory(input);
            var appetizers = factory.GetAppetizers();
            var desserts = factory.GetDesserts();
            var drinks = factory.GetDrinks();
            var mains = factory.GetMains();
            StringBuilder stringBuilder = new StringBuilder();

            Console.WriteLine("Appetizers: ");
            appetizers.PrintMenu();
            Console.WriteLine("Please make a selection of an Appetizer: ");
            stringBuilder.Append(Console.ReadLine());
            stringBuilder.Append(", ");

            Console.WriteLine("Drinks: ");
            drinks.PrintMenu();
            Console.WriteLine("Please make a selection of a Drink: ");
            stringBuilder.Append(Console.ReadLine());
            stringBuilder.Append(", ");

            Console.WriteLine("Main Dishes: ");
            mains.PrintMenu();
            Console.WriteLine("Please make a selection of a Main Dish: ");
            stringBuilder.Append(Console.ReadLine());
            stringBuilder.Append(", ");

            Console.WriteLine("Desserts: ");
            desserts.PrintMenu();
            Console.WriteLine("Please make a selection of a Dessert: ");
            stringBuilder.Append(Console.ReadLine());

            Console.WriteLine("Full Order Selected: ");
            Console.WriteLine(stringBuilder.ToString());
        }

        public static IOrderFactory GetFoodFactory(string input)
        {
            switch (input)
            {
                case "Asian":
                    return new AsianOrderFactory();
                case "Fast Food":
                    return new FastFoodOrderFactory();
                case "Mexican":
                    return new MexicanOrderFactory();
                default:
                    return new AsianOrderFactory();
            }
        }
    }
}

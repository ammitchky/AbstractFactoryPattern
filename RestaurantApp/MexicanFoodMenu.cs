namespace RestaurantApp
{
    public class MexicanFoodMenu : IMenu
    {
        public string GetAppetizers()
        {
            return "Nachos, Chips and Salsa, Chips and Guacamole";
        }

        public string GetDesserts()
        {
            return "Churros, Sopapillas, Tres Leches, Flan";
        }

        public string GetDrinks()
        {
            return "Mexican Soda, Magaritas, Sangria, Water, Dos Equis";
        }

        public string GetMains()
        {
            return "Enchiladas, Tacos, Quesidillas, Burritos, Fajitas, ";
        }
    }
}
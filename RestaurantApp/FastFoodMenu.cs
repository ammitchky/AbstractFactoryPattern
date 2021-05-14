namespace RestaurantApp
{
    public class FastFoodMenu : IMenu
    {
        public string GetAppetizers()
        {
            return "Onion Rings, Tator Tots, Rolls, Biscuits, Cheese Sticks";
        }

        public string GetDesserts()
        {
            return "Milkshake, Ice Cream, Pizookie, Brownie, Cake";
        }

        public string GetDrinks()
        {
            return "Soda, Tea, Slushies, Icee, Coffee, Water";
        }

        public string GetMains()
        {
            return "Burger, Chicken Nuggets, Chicken Sandwich, Tacos, Wrap, Chicken Tenders";
        }
    }
}
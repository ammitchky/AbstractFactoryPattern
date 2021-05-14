namespace RestaurantApp
{
    public class FastFoodOrderFactory : IOrderFactory
    {
        public IMenu GetAppetizers() => new FastFoodAppetizers();

        public IMenu GetDesserts() => new FastFoodDesserts();

        public IMenu GetDrinks() => new FastFoodDrinks();

        public IMenu GetMains() => new FastFoodMains();
    }
}
namespace RestaurantApp
{
    public class AsianOrderFactory : IOrderFactory
    {
        public IMenu GetAppetizers() => new AsianAppetizers();

        public IMenu GetDesserts() => new AsianDesserts();

        public IMenu GetDrinks() => new AsianDrinks();

        public IMenu GetMains() => new AsianMains();
    }
}
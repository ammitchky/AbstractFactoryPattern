namespace RestaurantApp
{
    public class MexicanOrderFactory : IOrderFactory
    {
        public IMenu GetAppetizers() => new MexicanAppetizers();

        public IMenu GetDesserts() => new MexicanDesserts();

        public IMenu GetDrinks() => new MexicanDrinks();

        public IMenu GetMains() => new MexicanMains();
    }
}
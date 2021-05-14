namespace RestaurantApp
{
    public interface IOrderFactory
    {
        public IMenu GetAppetizers();

        public IMenu GetMains();

        public IMenu GetDesserts();

        public IMenu GetDrinks();
    }
}
namespace RestaurantApp
{
    public class AsianFoodMenu : IMenu
    {
        public string GetAppetizers()
        {
            return "Dumplings, Chicken Wings, Egg Rolls, Spring Rolls, Miso Soup, Onigiri";
        }

        public string GetDesserts()
        {
            return "Fortune Cookies, Mochi, Taiyaki, Sweet Custard Buns, Green Tea Ice Cream";
        }

        public string GetDrinks()
        {
            return "Boba Tea, Chai Tea, Milk Tea, Ramune, Water, Matcha, Sake, Soju";
        }

        public string GetMains()
        {
            return "Sushi, Lo Mein, Pho, Ramen, Peking Duck, Udon, Steamed Fish, Teriyaki Chicken";
        }
    }
}
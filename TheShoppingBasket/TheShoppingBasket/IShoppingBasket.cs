namespace TheShoppingBasket
{
    public interface IShoppingBasket
    {
        void Add(string product, int quantity);
    }

    public class ShoppingBasket : IShoppingBasket
    {
        public void Add(string product, int quantity)
        {
            throw new System.NotImplementedException();
        }
    }
}
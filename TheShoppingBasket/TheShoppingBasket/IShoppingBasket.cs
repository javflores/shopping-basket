namespace TheShoppingBasket
{
    public interface IShoppingBasket
    {
        void Add(Product product, Quantity quantity);
        Money Total();
    }
}
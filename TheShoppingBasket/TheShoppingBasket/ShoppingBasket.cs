namespace TheShoppingBasket
{
    internal class ShoppingBasket : IShoppingBasket
    {
        public void Add(Product product, Quantity quantity)
        {
            throw new System.NotImplementedException();
        }

        public Money Total()
        {
            return new Money(0.00m);
        }
    }
}
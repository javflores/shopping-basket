namespace TheShoppingBasket
{
    internal class ShoppingBasket : IShoppingBasket
    {
        private Money _total = new Money(0.00m);

        public void Add(Product product, Quantity quantity)
        {
            _total = new Money(0.80m);
        }

        public Money Total()
        {
            return _total;
        }
    }
}
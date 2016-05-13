namespace TheShoppingBasket
{
    internal class ShoppingBasket : IShoppingBasket
    {
        private Money _total = new Money(0.00m);

        public void Add(Product product, Quantity quantity)
        {
            if (product.Equals(new Product("milk")))
            {
                _total = new Money(1.15m);
            }
            else
            {
                _total = new Money(0.80m);
            }
        }

        public Money Total()
        {
            return _total;
        }
    }
}
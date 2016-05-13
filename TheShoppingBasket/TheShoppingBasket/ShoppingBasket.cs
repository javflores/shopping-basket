namespace TheShoppingBasket
{
    internal class ShoppingBasket : IShoppingBasket
    {
        private Money _total = new Money(0.00m);
        private readonly IProductCatalogue _productCatalogue;

        public ShoppingBasket()
        {
            _productCatalogue = new ProductCatalogue();
        }

        public void Add(Product product, Quantity quantity)
        {
            _total = _productCatalogue.Cost(product);
        }

        public Money Total()
        {
            return _total;
        }
    }
}
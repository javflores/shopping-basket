namespace TheShoppingBasket
{
    internal class ShoppingBasket : IShoppingBasket
    {
        private readonly IProductCatalogue _productCatalogue;
        private Product _product = new Product("dummy");

        public ShoppingBasket()
        {
            _productCatalogue = new ProductCatalogue();
        }

        public void Add(Product product, Quantity quantity)
        {
            _product = product;
        }

        public Money Total()
        {
            return _productCatalogue.Cost(_product);
        }
    }
}
using TheShoppingBasket.Domain.Discount;
using TheShoppingBasket.Domain.Product;

namespace TheShoppingBasket.Domain
{
    public interface IShoppingBasket
    {
        void Add(Product.Product productName, Quantity quantity);
        Money Total();
    }

    internal class ShoppingBasket : IShoppingBasket
    {
        private readonly Products _products = new Products();
        private readonly Discounts _discounts = new Discounts();

        public void Add(Product.Product product, Quantity quantity)
        {
            quantity.Do(() => _products.Add(product));
        }

        public Money Total()
        {
            return _products.Cost() - _discounts.Apply(_products);
        }
    }
}
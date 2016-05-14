using TheShoppingBasket.Repository;

namespace TheShoppingBasket.Model
{
    public abstract class Discount
    {
        protected readonly IProductCatalogue _productCatalogue;

        public abstract Money Apply(Products products);

        protected Discount()
        {
            _productCatalogue = new ProductCatalogue();
        }
    }
}
using TheShoppingBasket.Domain.Product;
using TheShoppingBasket.Services;

namespace TheShoppingBasket.Domain.Discount
{
    public interface IDiscount
    {
        Money Apply(Products products);
    }
}
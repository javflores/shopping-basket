namespace TheShoppingBasket.Domain.Product
{
    public class Milk : Product
    {
        public override Money Cost()
        {
            return new Money(1.15m);
        }
    }
}
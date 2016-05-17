namespace TheShoppingBasket.Domain.Product
{
    public class Bread : Product
    {
        public override Money Cost()
        {
            return new Money(1.00m);
        }
    }
}
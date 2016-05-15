namespace TheShoppingBasket.Domain.Product
{
    public class Milk : Product
    {
        public Milk() : base("milk")
        {
        }

        public override Money Cost()
        {
            return new Money(1.15m);
        }
    }
}
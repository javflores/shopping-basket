namespace TheShoppingBasket.Domain.Product
{
    public class Milk : Product
    {
        public override Money Price => new Money(1.15m);

        public Milk() : base("milk")
        {
        }
    }
}
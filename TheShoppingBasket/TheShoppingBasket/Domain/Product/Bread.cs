namespace TheShoppingBasket.Domain.Product
{
    public class Bread : Product
    {
        public override Money Price => new Money(1.00m);

        public Bread() : base("bread")
        {
        }
    }
}